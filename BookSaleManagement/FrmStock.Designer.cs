namespace BookSaleManagement
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelect2 = new System.Windows.Forms.TextBox();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtImportAmount = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRise = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelect1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreStock = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtRetail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrdvStock = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgrdvImportList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvImportList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgrdvStock);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存信息";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtSelect2);
            this.panel3.Controls.Add(this.btnWarehouse);
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Controls.Add(this.btnAll);
            this.panel3.Controls.Add(this.txtImportAmount);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.txtImportPrice);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnRise);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSelect1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbSelect);
            this.panel3.Location = new System.Drawing.Point(740, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 238);
            this.panel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "到";
            // 
            // txtSelect2
            // 
            this.txtSelect2.Location = new System.Drawing.Point(148, 37);
            this.txtSelect2.Name = "txtSelect2";
            this.txtSelect2.Size = new System.Drawing.Size(51, 21);
            this.txtSelect2.TabIndex = 11;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(13, 205);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(186, 23);
            this.btnWarehouse.TabIndex = 10;
            this.btnWarehouse.Text = "仓库信息管理";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 176);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(186, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "进货";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(109, 93);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(90, 23);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // txtImportAmount
            // 
            this.txtImportAmount.Location = new System.Drawing.Point(68, 149);
            this.txtImportAmount.Name = "txtImportAmount";
            this.txtImportAmount.Size = new System.Drawing.Size(131, 21);
            this.txtImportAmount.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(13, 93);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(68, 122);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(131, 21);
            this.txtImportPrice.TabIndex = 2;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(109, 64);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(90, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "降序";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "进货数量";
            // 
            // btnRise
            // 
            this.btnRise.Location = new System.Drawing.Point(13, 64);
            this.btnRise.Name = "btnRise";
            this.btnRise.Size = new System.Drawing.Size(90, 23);
            this.btnRise.TabIndex = 4;
            this.btnRise.Text = "升序";
            this.btnRise.UseVisualStyleBackColor = true;
            this.btnRise.Click += new System.EventHandler(this.btnRise_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "进货价";
            // 
            // txtSelect1
            // 
            this.txtSelect1.Location = new System.Drawing.Point(68, 37);
            this.txtSelect1.Name = "txtSelect1";
            this.txtSelect1.Size = new System.Drawing.Size(51, 21);
            this.txtSelect1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "查询值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "查询条件";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "书籍编号",
            "零售价",
            "折扣信息",
            "当前库存"});
            this.cmbSelect.Location = new System.Drawing.Point(68, 11);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(131, 20);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPreStock);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtRetail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(740, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 90);
            this.panel1.TabIndex = 1;
            // 
            // txtPreStock
            // 
            this.txtPreStock.Location = new System.Drawing.Point(68, 61);
            this.txtPreStock.Name = "txtPreStock";
            this.txtPreStock.Size = new System.Drawing.Size(131, 21);
            this.txtPreStock.TabIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(68, 34);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(131, 21);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtRetail
            // 
            this.txtRetail.Location = new System.Drawing.Point(68, 7);
            this.txtRetail.Name = "txtRetail";
            this.txtRetail.Size = new System.Drawing.Size(131, 21);
            this.txtRetail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前库存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "折扣信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "零售价";
            // 
            // dgrdvStock
            // 
            this.dgrdvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvStock.Location = new System.Drawing.Point(6, 20);
            this.dgrdvStock.Name = "dgrdvStock";
            this.dgrdvStock.ReadOnly = true;
            this.dgrdvStock.RowHeadersWidth = 20;
            this.dgrdvStock.RowTemplate.Height = 23;
            this.dgrdvStock.Size = new System.Drawing.Size(728, 334);
            this.dgrdvStock.TabIndex = 0;
            this.dgrdvStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvStock_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.dgrdvImportList);
            this.groupBox2.Location = new System.Drawing.Point(12, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进货清单";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddNewBook);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Location = new System.Drawing.Point(740, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 135);
            this.panel2.TabIndex = 2;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(13, 73);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(186, 23);
            this.btnAddNewBook.TabIndex = 6;
            this.btnAddNewBook.Text = "进新书";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 44);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(186, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "退货";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(13, 15);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(186, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "付款";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgrdvImportList
            // 
            this.dgrdvImportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvImportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvImportList.Location = new System.Drawing.Point(6, 20);
            this.dgrdvImportList.Name = "dgrdvImportList";
            this.dgrdvImportList.ReadOnly = true;
            this.dgrdvImportList.RowHeadersWidth = 20;
            this.dgrdvImportList.RowTemplate.Height = 23;
            this.dgrdvImportList.Size = new System.Drawing.Size(728, 135);
            this.dgrdvImportList.TabIndex = 1;
            this.dgrdvImportList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvImportList_RowHeaderMouseClick);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存信息管理";
            this.Activated += new System.EventHandler(this.FrmStock_Activated);
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvImportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSelect2;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtImportAmount;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelect1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPreStock;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtRetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrdvStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgrdvImportList;
    }
}