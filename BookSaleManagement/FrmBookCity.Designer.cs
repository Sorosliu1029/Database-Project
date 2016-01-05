namespace BookSaleManagement
{
    partial class FrmBookCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookCity));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrdvBookCity = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrdvBasket = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.nupNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nupNumberUpdate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateNumber = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvBookCity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvBasket)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumber)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrdvBookCity);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "书城展示";
            // 
            // dgrdvBookCity
            // 
            this.dgrdvBookCity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvBookCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvBookCity.Location = new System.Drawing.Point(6, 17);
            this.dgrdvBookCity.Name = "dgrdvBookCity";
            this.dgrdvBookCity.ReadOnly = true;
            this.dgrdvBookCity.RowHeadersWidth = 20;
            this.dgrdvBookCity.RowTemplate.Height = 23;
            this.dgrdvBookCity.Size = new System.Drawing.Size(625, 255);
            this.dgrdvBookCity.TabIndex = 0;
            this.dgrdvBookCity.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvBookCity_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrdvBasket);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "我的购物篮";
            // 
            // dgrdvBasket
            // 
            this.dgrdvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvBasket.Location = new System.Drawing.Point(6, 20);
            this.dgrdvBasket.Name = "dgrdvBasket";
            this.dgrdvBasket.ReadOnly = true;
            this.dgrdvBasket.RowHeadersWidth = 20;
            this.dgrdvBasket.RowTemplate.Height = 23;
            this.dgrdvBasket.Size = new System.Drawing.Size(625, 215);
            this.dgrdvBasket.TabIndex = 1;
            this.dgrdvBasket.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdvBasket_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.nupNumber);
            this.panel1.Controls.Add(this.btnAddToBasket);
            this.panel1.Controls.Add(this.txtSelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSelect);
            this.panel1.Location = new System.Drawing.Point(655, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 272);
            this.panel1.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(24, 107);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(140, 23);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(24, 77);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(141, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(24, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nupNumber
            // 
            this.nupNumber.Location = new System.Drawing.Point(69, 152);
            this.nupNumber.Name = "nupNumber";
            this.nupNumber.Size = new System.Drawing.Size(96, 21);
            this.nupNumber.TabIndex = 7;
            this.nupNumber.ValueChanged += new System.EventHandler(this.nupNumber_ValueChanged);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(24, 179);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(141, 23);
            this.btnAddToBasket.TabIndex = 6;
            this.btnAddToBasket.Text = "添加到购物篮";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(69, 50);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(96, 21);
            this.txtSelect.TabIndex = 4;
            this.txtSelect.Click += new System.EventHandler(this.txtSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "查询值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询条件";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "书名",
            "作者",
            "出版社"});
            this.cmbSelect.Location = new System.Drawing.Point(69, 24);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(96, 20);
            this.cmbSelect.TabIndex = 0;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nupNumberUpdate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnUpdateNumber);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Location = new System.Drawing.Point(655, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 226);
            this.panel2.TabIndex = 3;
            // 
            // nupNumberUpdate
            // 
            this.nupNumberUpdate.Location = new System.Drawing.Point(69, 133);
            this.nupNumberUpdate.Name = "nupNumberUpdate";
            this.nupNumberUpdate.Size = new System.Drawing.Size(96, 21);
            this.nupNumberUpdate.TabIndex = 11;
            this.nupNumberUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nupNumberUpdate_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "数量";
            // 
            // btnUpdateNumber
            // 
            this.btnUpdateNumber.Location = new System.Drawing.Point(24, 160);
            this.btnUpdateNumber.Name = "btnUpdateNumber";
            this.btnUpdateNumber.Size = new System.Drawing.Size(141, 23);
            this.btnUpdateNumber.TabIndex = 9;
            this.btnUpdateNumber.Text = "更改数量";
            this.btnUpdateNumber.UseVisualStyleBackColor = true;
            this.btnUpdateNumber.Click += new System.EventHandler(this.btnUpdateNumber_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(24, 47);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 23);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "付款";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // FrmBookCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(851, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBookCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎选购";
            this.Load += new System.EventHandler(this.FrmBookCity_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvBookCity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvBasket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumberUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrdvBookCity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrdvBasket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupNumber;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.NumericUpDown nupNumberUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAll;
    }
}