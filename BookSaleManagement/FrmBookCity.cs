using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookSaleManagement
{
    public partial class FrmBookCity : Form
    {
        string publicSqlString = "select tbl_Stocks.warehouseID, tbl_Book.bookID, tbl_Book.title, tbl_Book.bookAuthor, tbl_Book.bookPublisher, " +
            " tbl_Book.retailPrice, tbl_Book.discountRate from tbl_Book, tbl_Stocks " + 
            " where tbl_Book.bookID = tbl_Stocks.bookID";
        public FrmBookCity()
        {
            InitializeComponent();
        }
        bool RefreshBookData(string sqlStr)
        {
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvBookCity.DataSource = ds.Tables[0];
                dgrdvBookCity.Columns[0].HeaderText = "仓库编号";
                dgrdvBookCity.Columns[0].Width = 100;
                dgrdvBookCity.Columns[1].HeaderText = "书籍编号";
                dgrdvBookCity.Columns[1].Width = 98;
                dgrdvBookCity.Columns[2].HeaderText = "书名";
                dgrdvBookCity.Columns[2].Width = 98;
                dgrdvBookCity.Columns[3].HeaderText = "作者";
                dgrdvBookCity.Columns[3].Width = 80;
                dgrdvBookCity.Columns[4].HeaderText = "出版社";
                dgrdvBookCity.Columns[4].Width = 80;
                dgrdvBookCity.Columns[5].HeaderText = "零售价";
                dgrdvBookCity.Columns[5].Width = 80;
                dgrdvBookCity.Columns[6].HeaderText = "折扣信息";
                dgrdvBookCity.Columns[6].Width = 80;
                return true;
            }
            else
            {
                dgrdvBookCity.DataSource = null;
                return false;
            }
        }
        void RefreshBasketData()
        {
            string sqlStr = "select  tbl_Stocks.warehouseID, tbl_Book.bookID, tbl_Book.title, tbl_Book.retailPrice, tbl_ShoppingBasket.basketNumber, " +
                " tbl_Book.discountRate, tbl_Stocks.leftAmount, tbl_ShoppingBasket.basketStatus " +
                " from tbl_Book, tbl_ShoppingBasket, tbl_Stocks where tbl_Book.bookID = tbl_ShoppingBasket.bookID and " +
                " tbl_Stocks.warehouseID = tbl_ShoppingBasket.warehouseID and " +
                " tbl_Stocks.bookID = tbl_Book.bookID and tbl_ShoppingBasket.customerEmail = '" +
                CPublic.userInfo[0] + "'";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvBasket.DataSource = ds.Tables[0];
                dgrdvBasket.Columns[0].HeaderText = "仓库编号";
                dgrdvBasket.Columns[0].Width = 100;
                dgrdvBasket.Columns[1].HeaderText = "书籍编号";
                dgrdvBasket.Columns[1].Width = 100;
                dgrdvBasket.Columns[2].HeaderText = "书名";
                dgrdvBasket.Columns[2].Width = 80;
                dgrdvBasket.Columns[3].HeaderText = "单价";
                dgrdvBasket.Columns[3].Width = 60;
                dgrdvBasket.Columns[4].HeaderText = "数量";
                dgrdvBasket.Columns[4].Width = 60;
                dgrdvBasket.Columns[5].HeaderText = "折扣信息";
                dgrdvBasket.Columns[5].Width = 80;
                dgrdvBasket.Columns[6].HeaderText = "库存量";
                dgrdvBasket.Columns[6].Width = 80;
                dgrdvBasket.Columns[7].HeaderText = "状态";
                dgrdvBasket.Columns[7].Width = 60;
            }
            else
            {
                dgrdvBasket.DataSource = null;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "delete from tbl_ShoppingBasket where basketStatus = '已付款' or basketStatus ='已删除'";
                if (CDataBase.UpdateDB(sqlStr))
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        void ObjClose()
        {
            txtSelect.Enabled = false;
            nupNumber.Enabled = false;
            nupNumberUpdate.Enabled = false;
        }
        private void FrmBookCity_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshBookData(publicSqlString);
                RefreshBasketData();
                ObjClose();
                btnSelect.Enabled = false;
                btnAddToBasket.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdateNumber.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrdvBookCity_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nupNumber.Enabled = true;
        }

        private void nupNumber_ValueChanged(object sender, EventArgs e)
        {
            btnAddToBasket.Enabled = true;
        }

        private void dgrdvBasket_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dgrdvBasket.CurrentCell.RowIndex;
            string status = dgrdvBasket[7, n].Value.ToString().Trim();
            if (status == "未付款")
            {
                nupNumberUpdate.Enabled = true;
                int m = dgrdvBasket.CurrentCell.RowIndex;
                nupNumberUpdate.Value = Convert.ToInt32(dgrdvBasket[4, n].Value.ToString().Trim());
                btnDelete.Enabled = true;
                btnUpdateNumber.Enabled = true;
            }
            else
            {
                nupNumberUpdate.Enabled = false;
                nupNumberUpdate.Value = 0;
                btnDelete.Enabled = false;
                btnUpdateNumber.Enabled = false;
            }                       
        }
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelect.Enabled = true;
            txtSelect.Text = "支持'%'通配符";
            btnSelect.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                bool fuzzyQuery;
                if (cmbSelect.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择查询条件!", "提示");
                    return;
                }
                if (txtSelect.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要查询的“" + cmbSelect.SelectedItem.ToString().Trim() + "”!", "提示");
                    return;
                }
                fuzzyQuery = txtSelect.Text.Trim().Contains('%');
                string op = fuzzyQuery ? "like" : "=";
                if (cmbSelect.SelectedIndex == 0)
                    sqlStr = publicSqlString + " and tbl_Book.title " + op + " '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 1)
                    sqlStr = publicSqlString + " and tbl_Book.bookAuthor " + op + " '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = publicSqlString + " and tbl_Book.bookPublisher " + op + " '" + txtSelect.Text.Trim() + "'";               
                bool a = RefreshBookData(sqlStr);
                if (a == false)
                {
                    MessageBox.Show("没有符合条件的书籍!", "提示");
                    txtSelect.Text = "";
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = RefreshBookData(publicSqlString);
                cmbSelect.SelectedIndex = -1;
                txtSelect.Text = "";
                txtSelect.Enabled = false;
                btnSelect.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            try
            {                
                if (dgrdvBookCity.DataSource == null)
                {
                    MessageBox.Show("没有能够添加到购物篮的书籍!", "提示");
                    return;
                }
                if (nupNumber.Value <1)
                {
                    MessageBox.Show("请输入要选购的数量!", "提示");
                    nupNumber.Focus();
                    return;
                }
                int n = dgrdvBookCity.CurrentCell.RowIndex;
                string warehouseID = dgrdvBookCity[0, n].Value.ToString().Trim();
                string bookID = dgrdvBookCity[1, n].Value.ToString().Trim();
                int m = dgrdvBasket.RowCount - 1;
                for (int i = 0; i < m; i++)
                {
                    if (dgrdvBasket[0,i].Value.ToString().Trim() == warehouseID && 
                        dgrdvBasket[1,i].Value.ToString().Trim() == bookID &&
                        dgrdvBasket[7,i].Value.ToString().Trim() == "未付款" )
                    {
                        MessageBox.Show("购物篮中已经存在该书，请更改购物篮数量!", "提示");
                        nupNumberUpdate.Focus();
                        return;
                    }
                }                    
                string sqlStr = "insert into tbl_ShoppingBasket values('" + bookID + "','" + warehouseID + "','" +
                CPublic.userInfo[0] + "', " + (int)nupNumber.Value+ " , "  + "'未付款')";
                CDataBase.UpdateDB(sqlStr);
                sqlStr = "delete from tbl_ShoppingBasket where basketStatus = '已付款' or basketStatus ='已删除'";
                CDataBase.UpdateDB(sqlStr);
                RefreshBasketData();
                MessageBox.Show("添加到购物篮成功!", "提示");
                btnPay.Enabled = true;
                nupNumber.Enabled = false;
                nupNumber.Value = 0;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                double totalPay = 0.0;
                double Price;
                double discount;
                int Amount;
                int stockAmount;
                int rowNum = dgrdvBasket.RowCount - 1;
                DateTime dtFinance = System.DateTime.Now;
                string generateDate = dtFinance.ToString().Trim();
                for (int i = 0; i < rowNum; i++)
                {                    
                    Price = Convert.ToDouble(dgrdvBasket[3, i].Value.ToString().Trim());
                    discount = Convert.ToDouble(dgrdvBasket[5, i].Value.ToString().Trim());
                    Amount = Convert.ToInt32(dgrdvBasket[4, i].Value.ToString().Trim());
                    stockAmount = Convert.ToInt32(dgrdvBasket[6, i].Value.ToString().Trim());
                    if (Amount > stockAmount)
                    {
                        MessageBox.Show("书籍：" + dgrdvBasket[2,i].Value.ToString().Trim() +" 库存不足\n     请更改数量!", "提示");
                        nupNumberUpdate.Enabled = true;
                        nupNumberUpdate.Focus();
                        return;
                    }
                    if (dgrdvBasket[7, i].Value.ToString().Trim() == "未付款")
                    {
                        totalPay += (Price * Amount * discount);
                    }
                }
                if (totalPay == 0.0)
                {
                    MessageBox.Show("当前没有购物篮需要付款!", "提示");
                    return;
                }
                if (MessageBox.Show("购物篮付款总额为：" + totalPay.ToString() + "元\n       确定要付款吗?", "购物篮付款",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int rowNum1 = dgrdvBasket.RowCount - 1;
                    string sqlStr3, sqlStr4, sqlStr5, sqlStr6, warehouseID, bookID;
                    int Number;
                    DataSet ds = new DataSet();
                    sqlStr6 = "select balance from tbl_Customer where customerEmail='" + CPublic.userInfo[0] + "'";
                    ds = CDataBase.GetDataFromDB(sqlStr6);
                    double balance = Convert.ToDouble(ds.Tables[0].Rows[0].ItemArray[0].ToString().Trim());
                    if(balance < totalPay)
                    {
                        MessageBox.Show("您的余额不足，未能完成付款!", "很遗憾");
                        return;
                    }
                    sqlStr3 = "update tbl_Customer set balance = balance - " + totalPay +
                        " where customerEmail ='" + CPublic.userInfo[0] + "'";
                    CDataBase.UpdateDB(sqlStr3);
                    for (int i = 0; i < rowNum1; i++)
                    {
                        if (dgrdvBasket[7, i].Value.ToString().Trim() == "未付款")
                        {
                            warehouseID = dgrdvBasket[0, i].Value.ToString().Trim();
                            bookID = dgrdvBasket[1, i].Value.ToString().Trim();
                            Number = Convert.ToInt32(dgrdvBasket[4, i].Value.ToString().Trim());
                            sqlStr4 = "update tbl_Stocks set leftAmount = leftAmount - " + Number +
                                " , soldAmount = soldAmount + " + Number +
                                 " where warehouseID='" + warehouseID + "' and bookID='" + bookID + "'";
                            CDataBase.UpdateDB(sqlStr4);
                            sqlStr5 = "insert into tbl_OrderForm values ('" + bookID + "','" + CPublic.userInfo[0] +
                                "', " + Number + " ,'" + generateDate + "', '未出库' )";
                            CDataBase.UpdateDB(sqlStr5);
                        }
                    }
                    string sqlStr1;
                    sqlStr1 = "update tbl_ShoppingBasket set basketStatus = '已付款' where basketStatus = '未付款' ";
                    CDataBase.UpdateDB(sqlStr1);
                    RefreshBasketData();                                       
                    string financeID = generateDate.Replace('/', '0').Replace(' ', '0').Replace(':', '0');
                    sqlStr1 = "insert into tbl_Finance values('" + financeID + "', " + totalPay + " , '进账' , '" +
                        CPublic.userInfo[0] + "', '" + generateDate + "')";
                    CDataBase.UpdateDB(sqlStr1);                       
                    btnPay.Enabled = false;
                    btnDelete.Enabled = false;
                    RefreshBookData(publicSqlString);
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void nupNumberUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdateNumber.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgrdvBasket.CurrentCell.RowIndex;
                string warehouseID = dgrdvBasket[0, n].Value.ToString().Trim();
                string bookID = dgrdvBasket[1, n].Value.ToString().Trim();
                if (MessageBox.Show("确定要删除吗？", "删除购物篮",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "update tbl_ShoppingBasket set basketStatus = '已删除' where warehouseID='" + warehouseID +
                        "' and bookID='" + bookID + "'";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshBasketData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateNumber_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgrdvBasket.CurrentCell.RowIndex;
                string warehouseID = dgrdvBasket[0, n].Value.ToString().Trim();
                string bookID = dgrdvBasket[1, n].Value.ToString().Trim();
                if (MessageBox.Show("确定将数量更改为" + nupNumberUpdate.Value.ToString().Trim() +"吗 ?", "删除购物篮",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "update tbl_ShoppingBasket set basketNumber = " + (int)nupNumberUpdate.Value +
                        " where warehouseID='" + warehouseID + "' and bookID='" + bookID + "' and basketStatus ='未付款'";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshBasketData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSelect_Click(object sender, EventArgs e)
        {
            txtSelect.Text = "";
        }

    }
}
