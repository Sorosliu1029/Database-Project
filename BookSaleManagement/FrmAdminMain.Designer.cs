namespace BookSaleManagement
{
    partial class FrmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMain));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDataBase = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(237, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "欢迎使用图书销售管理系统";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinance);
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.btnDataBase);
            this.groupBox1.Controls.Add(this.btnInformation);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.btnChangeUser);
            this.groupBox1.Controls.Add(this.btnUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择需要进入的子系统";
            // 
            // btnFinance
            // 
            this.btnFinance.Location = new System.Drawing.Point(220, 31);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(180, 40);
            this.btnFinance.TabIndex = 8;
            this.btnFinance.Text = "财务信息管理";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(14, 77);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(180, 40);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "书籍信息管理";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(220, 77);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(180, 40);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "库存信息管理";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnDataBase
            // 
            this.btnDataBase.Location = new System.Drawing.Point(14, 123);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(180, 40);
            this.btnDataBase.TabIndex = 2;
            this.btnDataBase.Text = "备份与恢复数据库";
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(14, 169);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(180, 40);
            this.btnInformation.TabIndex = 5;
            this.btnInformation.Text = "个人信息管理";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(386, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "退出系统";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(220, 169);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(180, 40);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "系统使用帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Location = new System.Drawing.Point(220, 123);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(180, 40);
            this.btnChangeUser.TabIndex = 1;
            this.btnChangeUser.Text = "切换系统用户";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(14, 31);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 40);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "书城用户管理";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserInfo.Location = new System.Drawing.Point(39, 52);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(82, 20);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "lblUserInfo";
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 365);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdminMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDataBase;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lblUserInfo;
    }
}