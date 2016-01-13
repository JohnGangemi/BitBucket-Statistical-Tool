namespace BitBucket_Statistical_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bbPassword_txt = new System.Windows.Forms.TextBox();
            this.bbName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numRepositories_lbl = new System.Windows.Forms.Label();
            this.numContributors_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.git_btn = new System.Windows.Forms.Button();
            this.output_btn = new System.Windows.Forms.Button();
            this.run_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gitFilePath_txt = new System.Windows.Forms.TextBox();
            this.outputFilePath_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.accountName_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(320, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requested Account";
            // 
            // accountName_txt
            // 
            this.accountName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName_txt.Location = new System.Drawing.Point(151, 44);
            this.accountName_txt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.accountName_txt.Name = "accountName_txt";
            this.accountName_txt.Size = new System.Drawing.Size(161, 25);
            this.accountName_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.bbPassword_txt);
            this.groupBox2.Controls.Add(this.bbName_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(15, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(320, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials";
            // 
            // bbPassword_txt
            // 
            this.bbPassword_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbPassword_txt.Location = new System.Drawing.Point(150, 89);
            this.bbPassword_txt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bbPassword_txt.Name = "bbPassword_txt";
            this.bbPassword_txt.Size = new System.Drawing.Size(162, 25);
            this.bbPassword_txt.TabIndex = 3;
            this.bbPassword_txt.UseSystemPasswordChar = true;
            // 
            // bbName_txt
            // 
            this.bbName_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbName_txt.Location = new System.Drawing.Point(150, 44);
            this.bbName_txt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bbName_txt.Name = "bbName_txt";
            this.bbName_txt.Size = new System.Drawing.Size(162, 25);
            this.bbName_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BitBucket Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BitBucket Name:";
            // 
            // statsList
            // 
            this.statsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.statsList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsList.GridLines = true;
            this.statsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.statsList.Location = new System.Drawing.Point(6, 135);
            this.statsList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.statsList.Name = "statsList";
            this.statsList.Size = new System.Drawing.Size(461, 571);
            this.statsList.TabIndex = 2;
            this.statsList.TabStop = false;
            this.statsList.UseCompatibleStateImageBehavior = false;
            this.statsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contributor";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lines of Code";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Files";
            this.columnHeader3.Width = 144;
            // 
            // numRepositories_lbl
            // 
            this.numRepositories_lbl.AutoSize = true;
            this.numRepositories_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRepositories_lbl.Location = new System.Drawing.Point(6, 80);
            this.numRepositories_lbl.Name = "numRepositories_lbl";
            this.numRepositories_lbl.Size = new System.Drawing.Size(149, 17);
            this.numRepositories_lbl.TabIndex = 3;
            this.numRepositories_lbl.Text = "Number of repositories:";
            // 
            // numContributors_lbl
            // 
            this.numContributors_lbl.AutoSize = true;
            this.numContributors_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numContributors_lbl.Location = new System.Drawing.Point(6, 51);
            this.numContributors_lbl.Name = "numContributors_lbl";
            this.numContributors_lbl.Size = new System.Drawing.Size(150, 17);
            this.numContributors_lbl.TabIndex = 4;
            this.numContributors_lbl.Text = "Number of contributors:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.numContributors_lbl);
            this.groupBox3.Controls.Add(this.statsList);
            this.groupBox3.Controls.Add(this.numRepositories_lbl);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(376, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(473, 713);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global Stats";
            // 
            // git_btn
            // 
            this.git_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.git_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.git_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.git_btn.FlatAppearance.BorderSize = 0;
            this.git_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.git_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.git_btn.ForeColor = System.Drawing.Color.White;
            this.git_btn.Location = new System.Drawing.Point(15, 349);
            this.git_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.git_btn.Name = "git_btn";
            this.git_btn.Size = new System.Drawing.Size(320, 59);
            this.git_btn.TabIndex = 4;
            this.git_btn.Text = "Find GitInspector.py Path";
            this.git_btn.UseVisualStyleBackColor = false;
            this.git_btn.Click += new System.EventHandler(this.git_btn_Click);
            // 
            // output_btn
            // 
            this.output_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.output_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.output_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.output_btn.FlatAppearance.BorderSize = 0;
            this.output_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.output_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_btn.ForeColor = System.Drawing.Color.White;
            this.output_btn.Location = new System.Drawing.Point(15, 429);
            this.output_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.output_btn.Name = "output_btn";
            this.output_btn.Size = new System.Drawing.Size(320, 59);
            this.output_btn.TabIndex = 5;
            this.output_btn.Text = "Select Output Path";
            this.output_btn.UseVisualStyleBackColor = false;
            this.output_btn.Click += new System.EventHandler(this.output_btn_Click);
            // 
            // run_btn
            // 
            this.run_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.run_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.run_btn.FlatAppearance.BorderSize = 0;
            this.run_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.run_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_btn.ForeColor = System.Drawing.Color.White;
            this.run_btn.Location = new System.Drawing.Point(15, 509);
            this.run_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(320, 59);
            this.run_btn.TabIndex = 6;
            this.run_btn.Text = "RUN";
            this.run_btn.UseVisualStyleBackColor = false;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "GitInspector";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 675);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Output";
            // 
            // gitFilePath_txt
            // 
            this.gitFilePath_txt.BackColor = System.Drawing.Color.White;
            this.gitFilePath_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gitFilePath_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gitFilePath_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitFilePath_txt.Location = new System.Drawing.Point(16, 641);
            this.gitFilePath_txt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gitFilePath_txt.Name = "gitFilePath_txt";
            this.gitFilePath_txt.ReadOnly = true;
            this.gitFilePath_txt.Size = new System.Drawing.Size(319, 22);
            this.gitFilePath_txt.TabIndex = 11;
            this.gitFilePath_txt.TabStop = false;
            // 
            // outputFilePath_txt
            // 
            this.outputFilePath_txt.BackColor = System.Drawing.Color.White;
            this.outputFilePath_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFilePath_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outputFilePath_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFilePath_txt.Location = new System.Drawing.Point(16, 696);
            this.outputFilePath_txt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.outputFilePath_txt.Name = "outputFilePath_txt";
            this.outputFilePath_txt.ReadOnly = true;
            this.outputFilePath_txt.Size = new System.Drawing.Size(319, 22);
            this.outputFilePath_txt.TabIndex = 12;
            this.outputFilePath_txt.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(864, 743);
            this.Controls.Add(this.outputFilePath_txt);
            this.Controls.Add(this.gitFilePath_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.output_btn);
            this.Controls.Add(this.git_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitBucket Statistical Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox accountName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bbPassword_txt;
        private System.Windows.Forms.TextBox bbName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView statsList;
        private System.Windows.Forms.Label numRepositories_lbl;
        private System.Windows.Forms.Label numContributors_lbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button git_btn;
        private System.Windows.Forms.Button output_btn;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gitFilePath_txt;
        private System.Windows.Forms.TextBox outputFilePath_txt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

