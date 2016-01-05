namespace BookSaleManagement
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llblEmail = new System.Windows.Forms.LinkLabel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtxtHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "三联书店图书销售管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本号1.0.0.0";
            // 
            // llblEmail
            // 
            this.llblEmail.AutoSize = true;
            this.llblEmail.LinkArea = new System.Windows.Forms.LinkArea(5, 29);
            this.llblEmail.Location = new System.Drawing.Point(14, 44);
            this.llblEmail.Name = "llblEmail";
            this.llblEmail.Size = new System.Drawing.Size(208, 19);
            this.llblEmail.TabIndex = 2;
            this.llblEmail.TabStop = true;
            this.llblEmail.Text = "联系作者:13307130167@fudan.edu.cn";
            this.llblEmail.UseCompatibleTextRendering = true;
            this.llblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEmail_LinkClicked);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(14, 66);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(208, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "查看系统帮助信息";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtxtHelp
            // 
            this.rtxtHelp.Location = new System.Drawing.Point(12, 111);
            this.rtxtHelp.Name = "rtxtHelp";
            this.rtxtHelp.ReadOnly = true;
            this.rtxtHelp.Size = new System.Drawing.Size(360, 180);
            this.rtxtHelp.TabIndex = 5;
            this.rtxtHelp.Text = "三联书店网上书城系统帮助信息\n……\n帮助信息有待更新";
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 102);
            this.Controls.Add(this.rtxtHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.llblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于图书销售管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblEmail;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtxtHelp;
    }
}