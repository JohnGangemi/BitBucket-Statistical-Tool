using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using LibGit2Sharp;

namespace BitBucket_Statistical_Tool
{
    public partial class MainForm : Form
    {

        #region PROGRAM VARS
        string requestedAcct = null;
        string bbName = null;
        string bbPassword = null;
        string gitpyDir = null;
        string outputDir = null;
        List<string> repositories = new List<string>();
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region UI FUNCTIONS
        private void git_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.Description = "Find the install path for GitInspectory.py";
            diag.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gitpyDir = diag.SelectedPath;
                gitFilePath_txt.Text = gitpyDir;
            }
        }

        private void output_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.Description = "Select a folder to store output files created by the program";
            diag.RootFolder = Environment.SpecialFolder.DesktopDirectory;

            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputDir = diag.SelectedPath;
                outputFilePath_txt.Text = outputDir;
            }
        }

        private async void run_btn_Click(object sender, EventArgs e)
        {
            Cleanup();

            if (accountName_txt.Text.Trim().Length == 0)
            {
                string msg = "Please enter an account name";
                MessageBox.Show(msg);
            }
            else if (bbName_txt.Text.Trim().Length == 0)
            {
                string msg = "Please enter a BitBucket name";
                MessageBox.Show(msg);
            }
            else if (bbPassword_txt.Text.Trim().Length == 0)
            {
                string msg = "Please enter a BitBucket password";
                MessageBox.Show(msg);
            }
            else
            {
                requestedAcct = accountName_txt.Text.Trim();
                bbName = bbName_txt.Text.Trim();
                bbPassword = bbPassword_txt.Text.Trim();

                await CallBitBucketApi();
                ParseApiResult();
                CloneRepositories();
            }
        }
        #endregion

        #region UTILITY FUNCTIONS
        private async Task CallBitBucketApi()
        {
            const string uri = @"https://bitbucket.org/api/1.0/user/repositories/";
            string outputFile = outputDir + @"\BitBucket Api Results.txt";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);

                var byteArray = Encoding.ASCII.GetBytes(bbName + ":" + bbPassword);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("basic", Convert.ToBase64String(byteArray));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    result = result.Replace(",", Environment.NewLine);
                    result = result.Replace("{", Environment.NewLine);
                    result += Environment.NewLine;

                    File.WriteAllText(outputFile, result);

                    string msg = @"'BitBucket Api Results.txt' created";
                    MessageBox.Show(msg);
                }
                else
                {
                    string msg = @"Could not generate 'BitBucket Api Results.txt'";
                    MessageBox.Show(msg);
                }
            }
        }

        private void ParseApiResult()
        {
            const char[] separator = null;
            string outputFile = outputDir + @"\BitBucket Api Results.txt";

            // check for bitbucket api file containing info on all repos
            if (File.Exists(outputFile))
            {
                // open the file
                using (FileStream fs = File.OpenRead(outputFile))
                {
                    const string scm_key = "\"scm\":";
                    const string owner_key = "\"owner\":";
                    const string slug_key = "\"slug\":";
                    const string terminator = "\"resource_uri\":";
                    string scm = null;
                    string owner = null;
                    string slug = null;

                    // iterate till end of file by line
                    foreach (string line in File.ReadLines(outputFile))
                    {
                        if (line.Trim().StartsWith(terminator))
                        {
                            if (scm.ToLower().Equals("git") && owner.ToLower().Equals(requestedAcct.ToLower()))
                            {
                                repositories.Add(slug);
                            }

                            scm = null;
                            owner = null;
                            slug = null;
                        }
                        else
                        {
                            // parse line
                            if (line.Trim().StartsWith(scm_key))
                            {
                                string[] buffer = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                scm = buffer[1].Replace('"', ' ').Trim();
                            }
                            else if (line.Trim().StartsWith(owner_key))
                            {
                                string[] buffer = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                owner = buffer[1].Replace('"', ' ').Trim();
                            }
                            else if (line.Trim().StartsWith(slug_key))
                            {
                                string[] buffer = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                                slug = buffer[1].Replace('"', ' ').Trim();
                            }
                        }
                    }
                }

                File.Delete(outputFile);

                // DEBUG CODE
                foreach (string repo in repositories)
                {
                    Console.WriteLine(repo);
                }
            }
            else
            {
                string msg = "Could not find file " + outputFile;
                MessageBox.Show(msg);
            }
        }

        private void CloneRepositories()
        {
            string repoDir = outputDir + @"\BitBucket Repositories\" + requestedAcct + @"\";
            if (Directory.Exists(repoDir))
            {
                DeleteFolderPath(repoDir);
            }


            var creds = new CloneOptions()
            {
                CredentialsProvider = (_url, _user, _pw) => new UsernamePasswordCredentials
                {
                    Username = bbName,
                    Password = bbPassword
                }
            };

            foreach (string repo in repositories)
            {
                string url = @"https://bitbucket.org/" + requestedAcct + "/" + repo;
                string cloneDir = repoDir + repo;

                try
                {
                    LibGit2Sharp.Repository.Clone(url, cloneDir, creds);
                }
                catch
                {
                    string msg = "Handled LibGit2Sharp exception";
                    MessageBox.Show(msg);
                }
            }
        }

        private void DeleteFolderPath(string repoDir)
        {
            DirectoryInfo dir = new DirectoryInfo(repoDir);

            if (dir.Attributes.HasFlag(FileAttributes.ReadOnly))
            {
                dir.Attributes &= ~FileAttributes.ReadOnly;
            }

            string[] fileList = Directory.GetFiles(repoDir);
            string[] dirList = Directory.GetDirectories(repoDir);

            if (dirList.Length > 0)
            {
                foreach (string subDir in dirList)
                {
                    DeleteFolderPath(subDir);
                }
            }

            if (fileList.Length > 0)
            {
                foreach (FileInfo fileInf in fileList.Select(str => new FileInfo(str)))
                {
                    if (fileInf.IsReadOnly)
                    {
                        fileInf.Attributes &= ~FileAttributes.ReadOnly;
                    }

                    fileInf.Delete();
                }
            }

            dir.Delete();
        }

        private void Cleanup()
        {
            repositories.Clear();
        }
        #endregion

    }
}
