namespace BookSaleManagement
{
    partial class FrmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataBase));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestorePath = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdlgBackup = new System.Windows.Forms.SaveFileDialog();
            this.odlgRestore = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBackupPath);
            this.groupBox1.Controls.Add(this.txtBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备份数据库";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(44, 57);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(333, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Location = new System.Drawing.Point(367, 24);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(27, 23);
            this.btnBackupPath.TabIndex = 2;
            this.btnBackupPath.Text = "…";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(83, 26);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(278, 21);
            this.txtBackup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnRestorePath);
            this.groupBox2.Controls.Add(this.txtRestore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "恢复数据库";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(44, 60);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(333, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "恢复数据库";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestorePath
            // 
            this.btnRestorePath.Location = new System.Drawing.Point(367, 25);
            this.btnRestorePath.Name = "btnRestorePath";
            this.btnRestorePath.Size = new System.Drawing.Size(27, 23);
            this.btnRestorePath.TabIndex = 4;
            this.btnRestorePath.Text = "…";
            this.btnRestorePath.UseVisualStyleBackColor = true;
            this.btnRestorePath.Click += new System.EventHandler(this.btnRestorePath_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(83, 27);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(278, 21);
            this.txtRestore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "恢复路径";
            // 
            // odlgRestore
            // 
            this.odlgRestore.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 247);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库备份与恢复";
            this.Load += new System.EventHandler(this.FrmDataBase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestorePath;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sdlgBackup;
        private System.Windows.Forms.OpenFileDialog odlgRestore;
        private System.Windows.Forms.Button btnClose;
    }
}