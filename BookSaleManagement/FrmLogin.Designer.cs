namespace BookSaleManagement
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCstRegister = new System.Windows.Forms.Button();
            this.lblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcSet = new System.Windows.Forms.TabControl();
            this.tbpWin = new System.Windows.Forms.TabPage();
            this.txtDataBaseWin = new System.Windows.Forms.TextBox();
            this.txtServerWin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelWin = new System.Windows.Forms.Button();
            this.btnOkWin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpSql = new System.Windows.Forms.TabPage();
            this.txtPasswordSql = new System.Windows.Forms.TextBox();
            this.txtUserSql = new System.Windows.Forms.TextBox();
            this.txtDataBaseSql = new System.Windows.Forms.TextBox();
            this.txtServerSql = new System.Windows.Forms.TextBox();
            this.btnCancelSql = new System.Windows.Forms.Button();
            this.btnOkSql = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSAPassword = new System.Windows.Forms.TextBox();
            this.txtSuperAdmin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSuperSex = new System.Windows.Forms.ComboBox();
            this.txtSuperAge = new System.Windows.Forms.TextBox();
            this.txtSuperName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSAPwdComfirm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcSet.SuspendLayout();
            this.tbpWin.SuspendLayout();
            this.tbpSql.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCstRegister);
            this.groupBox1.Controls.Add(this.lblForgetPassword);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.txtUserPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCstRegister
            // 
            this.btnCstRegister.Location = new System.Drawing.Point(153, 142);
            this.btnCstRegister.Name = "btnCstRegister";
            this.btnCstRegister.Size = new System.Drawing.Size(75, 23);
            this.btnCstRegister.TabIndex = 5;
            this.btnCstRegister.Text = "顾客注册";
            this.btnCstRegister.UseVisualStyleBackColor = true;
            this.btnCstRegister.Click += new System.EventHandler(this.btnCstRegister_Click);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Location = new System.Drawing.Point(212, 90);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(65, 12);
            this.lblForgetPassword.TabIndex = 7;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "忘了密码？";
            this.lblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetPassword_LinkClicked);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(234, 142);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "配置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(209, 66);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(100, 21);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(209, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "用户名/注册邮箱";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(152, 113);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "登录用户";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbcSet
            // 
            this.tbcSet.Controls.Add(this.tbpWin);
            this.tbcSet.Controls.Add(this.tbpSql);
            this.tbcSet.Location = new System.Drawing.Point(12, 312);
            this.tbcSet.Name = "tbcSet";
            this.tbcSet.SelectedIndex = 0;
            this.tbcSet.Size = new System.Drawing.Size(320, 177);
            this.tbcSet.TabIndex = 1;
            this.tbcSet.SelectedIndexChanged += new System.EventHandler(this.tbcSet_SelectedIndexChanged);
            // 
            // tbpWin
            // 
            this.tbpWin.Controls.Add(this.txtDataBaseWin);
            this.tbpWin.Controls.Add(this.txtServerWin);
            this.tbpWin.Controls.Add(this.label4);
            this.tbpWin.Controls.Add(this.btnCancelWin);
            this.tbpWin.Controls.Add(this.btnOkWin);
            this.tbpWin.Controls.Add(this.label3);
            this.tbpWin.Location = new System.Drawing.Point(4, 22);
            this.tbpWin.Name = "tbpWin";
            this.tbpWin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWin.Size = new System.Drawing.Size(312, 151);
            this.tbpWin.TabIndex = 0;
            this.tbpWin.Text = "Windows 身份验证";
            this.tbpWin.UseVisualStyleBackColor = true;
            // 
            // txtDataBaseWin
            // 
            this.txtDataBaseWin.Location = new System.Drawing.Point(95, 67);
            this.txtDataBaseWin.Name = "txtDataBaseWin";
            this.txtDataBaseWin.Size = new System.Drawing.Size(200, 21);
            this.txtDataBaseWin.TabIndex = 12;
            // 
            // txtServerWin
            // 
            this.txtServerWin.Location = new System.Drawing.Point(95, 33);
            this.txtServerWin.Name = "txtServerWin";
            this.txtServerWin.Size = new System.Drawing.Size(200, 21);
            this.txtServerWin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据库名称";
            // 
            // btnCancelWin
            // 
            this.btnCancelWin.Location = new System.Drawing.Point(220, 106);
            this.btnCancelWin.Name = "btnCancelWin";
            this.btnCancelWin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelWin.TabIndex = 14;
            this.btnCancelWin.Text = "取消";
            this.btnCancelWin.UseVisualStyleBackColor = true;
            this.btnCancelWin.Click += new System.EventHandler(this.btnCancelWin_Click);
            // 
            // btnOkWin
            // 
            this.btnOkWin.Location = new System.Drawing.Point(23, 106);
            this.btnOkWin.Name = "btnOkWin";
            this.btnOkWin.Size = new System.Drawing.Size(75, 23);
            this.btnOkWin.TabIndex = 13;
            this.btnOkWin.Text = "确定";
            this.btnOkWin.UseVisualStyleBackColor = true;
            this.btnOkWin.Click += new System.EventHandler(this.btnOkWin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器名称";
            // 
            // tbpSql
            // 
            this.tbpSql.Controls.Add(this.txtPasswordSql);
            this.tbpSql.Controls.Add(this.txtUserSql);
            this.tbpSql.Controls.Add(this.txtDataBaseSql);
            this.tbpSql.Controls.Add(this.txtServerSql);
            this.tbpSql.Controls.Add(this.btnCancelSql);
            this.tbpSql.Controls.Add(this.btnOkSql);
            this.tbpSql.Controls.Add(this.label8);
            this.tbpSql.Controls.Add(this.label7);
            this.tbpSql.Controls.Add(this.label6);
            this.tbpSql.Controls.Add(this.label5);
            this.tbpSql.Location = new System.Drawing.Point(4, 22);
            this.tbpSql.Name = "tbpSql";
            this.tbpSql.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSql.Size = new System.Drawing.Size(312, 151);
            this.tbpSql.TabIndex = 1;
            this.tbpSql.Text = "SQL Server 身份验证";
            this.tbpSql.UseVisualStyleBackColor = true;
            // 
            // txtPasswordSql
            // 
            this.txtPasswordSql.Location = new System.Drawing.Point(94, 92);
            this.txtPasswordSql.Name = "txtPasswordSql";
            this.txtPasswordSql.PasswordChar = '*';
            this.txtPasswordSql.Size = new System.Drawing.Size(202, 21);
            this.txtPasswordSql.TabIndex = 14;
            // 
            // txtUserSql
            // 
            this.txtUserSql.Location = new System.Drawing.Point(94, 65);
            this.txtUserSql.Name = "txtUserSql";
            this.txtUserSql.Size = new System.Drawing.Size(202, 21);
            this.txtUserSql.TabIndex = 13;
            // 
            // txtDataBaseSql
            // 
            this.txtDataBaseSql.Location = new System.Drawing.Point(94, 38);
            this.txtDataBaseSql.Name = "txtDataBaseSql";
            this.txtDataBaseSql.Size = new System.Drawing.Size(202, 21);
            this.txtDataBaseSql.TabIndex = 12;
            // 
            // txtServerSql
            // 
            this.txtServerSql.Location = new System.Drawing.Point(94, 11);
            this.txtServerSql.Name = "txtServerSql";
            this.txtServerSql.Size = new System.Drawing.Size(202, 21);
            this.txtServerSql.TabIndex = 11;
            // 
            // btnCancelSql
            // 
            this.btnCancelSql.Location = new System.Drawing.Point(221, 119);
            this.btnCancelSql.Name = "btnCancelSql";
            this.btnCancelSql.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSql.TabIndex = 16;
            this.btnCancelSql.Text = "取消";
            this.btnCancelSql.UseVisualStyleBackColor = true;
            this.btnCancelSql.Click += new System.EventHandler(this.btnCancelSql_Click);
            // 
            // btnOkSql
            // 
            this.btnOkSql.Location = new System.Drawing.Point(23, 119);
            this.btnOkSql.Name = "btnOkSql";
            this.btnOkSql.Size = new System.Drawing.Size(75, 23);
            this.btnOkSql.TabIndex = 15;
            this.btnOkSql.Text = "确定";
            this.btnOkSql.UseVisualStyleBackColor = true;
            this.btnOkSql.Click += new System.EventHandler(this.btnOkSql_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "用户密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "用 户 名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "数据库名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "服务器名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "用户名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "登录密码";
            // 
            // txtSAPassword
            // 
            this.txtSAPassword.Location = new System.Drawing.Point(70, 44);
            this.txtSAPassword.Name = "txtSAPassword";
            this.txtSAPassword.PasswordChar = '*';
            this.txtSAPassword.Size = new System.Drawing.Size(85, 21);
            this.txtSAPassword.TabIndex = 9;
            // 
            // txtSuperAdmin
            // 
            this.txtSuperAdmin.Location = new System.Drawing.Point(70, 17);
            this.txtSuperAdmin.Name = "txtSuperAdmin";
            this.txtSuperAdmin.Size = new System.Drawing.Size(237, 21);
            this.txtSuperAdmin.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSuperSex);
            this.groupBox2.Controls.Add(this.txtSuperAge);
            this.groupBox2.Controls.Add(this.txtSuperName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtSAPwdComfirm);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSAPassword);
            this.groupBox2.Controls.Add(this.txtSuperAdmin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 101);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "注册超级管理员";
            // 
            // cmbSuperSex
            // 
            this.cmbSuperSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuperSex.FormattingEnabled = true;
            this.cmbSuperSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSuperSex.Location = new System.Drawing.Point(173, 71);
            this.cmbSuperSex.Name = "cmbSuperSex";
            this.cmbSuperSex.Size = new System.Drawing.Size(44, 20);
            this.cmbSuperSex.TabIndex = 16;
            // 
            // txtSuperAge
            // 
            this.txtSuperAge.Location = new System.Drawing.Point(255, 71);
            this.txtSuperAge.Name = "txtSuperAge";
            this.txtSuperAge.Size = new System.Drawing.Size(52, 21);
            this.txtSuperAge.TabIndex = 15;
            // 
            // txtSuperName
            // 
            this.txtSuperName.Location = new System.Drawing.Point(70, 71);
            this.txtSuperName.Name = "txtSuperName";
            this.txtSuperName.Size = new System.Drawing.Size(62, 21);
            this.txtSuperName.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "年龄";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "性别";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "姓名";
            // 
            // txtSAPwdComfirm
            // 
            this.txtSAPwdComfirm.Location = new System.Drawing.Point(220, 44);
            this.txtSAPwdComfirm.Name = "txtSAPwdComfirm";
            this.txtSAPwdComfirm.PasswordChar = '*';
            this.txtSAPwdComfirm.Size = new System.Drawing.Size(87, 21);
            this.txtSAPwdComfirm.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "确认密码";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 192);
            this.Controls.Add(this.tbcSet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcSet.ResumeLayout(false);
            this.tbpWin.ResumeLayout(false);
            this.tbpWin.PerformLayout();
            this.tbpSql.ResumeLayout(false);
            this.tbpSql.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TabControl tbcSet;
        private System.Windows.Forms.TabPage tbpWin;
        private System.Windows.Forms.Button btnCancelWin;
        private System.Windows.Forms.Button btnOkWin;
        private System.Windows.Forms.TextBox txtDataBaseWin;
        private System.Windows.Forms.TextBox txtServerWin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbpSql;
        private System.Windows.Forms.TextBox txtPasswordSql;
        private System.Windows.Forms.TextBox txtUserSql;
        private System.Windows.Forms.TextBox txtDataBaseSql;
        private System.Windows.Forms.TextBox txtServerSql;
        private System.Windows.Forms.Button btnCancelSql;
        private System.Windows.Forms.Button btnOkSql;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblForgetPassword;
        private System.Windows.Forms.Button btnCstRegister;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSAPassword;
        private System.Windows.Forms.TextBox txtSuperAdmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSAPwdComfirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSuperSex;
        private System.Windows.Forms.TextBox txtSuperAge;
        private System.Windows.Forms.TextBox txtSuperName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

