namespace SQLInstall
{
    partial class frmSQLInstall
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
            this.lblSourceDir = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpSQLVersion = new System.Windows.Forms.GroupBox();
            this.radSQL2012 = new System.Windows.Forms.RadioButton();
            this.radSQL2008R2 = new System.Windows.Forms.RadioButton();
            this.btnInstall = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpSQLVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSourceDir
            // 
            this.lblSourceDir.AutoSize = true;
            this.lblSourceDir.Location = new System.Drawing.Point(13, 13);
            this.lblSourceDir.Name = "lblSourceDir";
            this.lblSourceDir.Size = new System.Drawing.Size(70, 13);
            this.lblSourceDir.TabIndex = 0;
            this.lblSourceDir.Text = "File Location:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(89, 10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(137, 20);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = "C:\\V4\\";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(232, 7);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(31, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpSQLVersion
            // 
            this.grpSQLVersion.Controls.Add(this.radSQL2012);
            this.grpSQLVersion.Controls.Add(this.radSQL2008R2);
            this.grpSQLVersion.Location = new System.Drawing.Point(13, 49);
            this.grpSQLVersion.Name = "grpSQLVersion";
            this.grpSQLVersion.Size = new System.Drawing.Size(250, 74);
            this.grpSQLVersion.TabIndex = 3;
            this.grpSQLVersion.TabStop = false;
            this.grpSQLVersion.Text = "SQL Express Version";
            // 
            // radSQL2012
            // 
            this.radSQL2012.AutoSize = true;
            this.radSQL2012.Location = new System.Drawing.Point(6, 43);
            this.radSQL2012.Name = "radSQL2012";
            this.radSQL2012.Size = new System.Drawing.Size(113, 17);
            this.radSQL2012.TabIndex = 1;
            this.radSQL2012.TabStop = true;
            this.radSQL2012.Text = "SQL 2012 Express";
            this.radSQL2012.UseVisualStyleBackColor = true;
            // 
            // radSQL2008R2
            // 
            this.radSQL2008R2.AutoSize = true;
            this.radSQL2008R2.Location = new System.Drawing.Point(6, 19);
            this.radSQL2008R2.Name = "radSQL2008R2";
            this.radSQL2008R2.Size = new System.Drawing.Size(130, 17);
            this.radSQL2008R2.TabIndex = 0;
            this.radSQL2008R2.TabStop = true;
            this.radSQL2008R2.Text = "SQL 2008 R2 Express";
            this.radSQL2008R2.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(92, 140);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "&Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSQLInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 175);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.grpSQLVersion);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSourceDir);
            this.Name = "frmSQLInstall";
            this.Text = "SQL Express Install";
            this.grpSQLVersion.ResumeLayout(false);
            this.grpSQLVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceDir;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox grpSQLVersion;
        private System.Windows.Forms.RadioButton radSQL2012;
        private System.Windows.Forms.RadioButton radSQL2008R2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

