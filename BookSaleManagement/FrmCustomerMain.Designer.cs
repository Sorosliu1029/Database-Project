namespace BookSaleManagement
{
    partial class FrmCustomerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerMain));
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBookSale = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserInfo.Location = new System.Drawing.Point(50, 48);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(84, 14);
            this.lblUserInfo.TabIndex = 3;
            this.lblUserInfo.Text = "lblUserInfo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.btnInformation);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.btnBookSale);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择需要进入的子系统";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 124);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(366, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "退出系统";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(203, 78);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(180, 40);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "系统使用帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(17, 78);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(180, 40);
            this.btnInformation.TabIndex = 4;
            this.btnInformation.Text = "我的个人信息";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(203, 32);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 40);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "我的订单";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBookSale
            // 
            this.btnBookSale.Location = new System.Drawing.Point(17, 32);
            this.btnBookSale.Name = "btnBookSale";
            this.btnBookSale.Size = new System.Drawing.Size(180, 40);
            this.btnBookSale.TabIndex = 0;
            this.btnBookSale.Text = "进入书城";
            this.btnBookSale.UseVisualStyleBackColor = true;
            this.btnBookSale.Click += new System.EventHandler(this.btnBookSale_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWelcome.Location = new System.Drawing.Point(25, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 19);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // FrmCustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 269);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomerMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBookSale;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
    }
}