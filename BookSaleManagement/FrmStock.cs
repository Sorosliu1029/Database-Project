using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSaleManagement
{
    public partial class FrmStock : Form
    {
        FrmWarehouse ob_FrmWarehouse;
        FrmAddNewBook ob_FrmAddNewBook;
        string publicSqlString1 = "select tbl_Stocks.warehouseID, tbl_Warehouse.warehouseCity, tbl_Book.bookID," +
                " tbl_Book.title, tbl_Book.retailPrice, tbl_Book.discountRate, tbl_Stocks.leftAmount" +
                " from tbl_Stocks , tbl_Book, tbl_Warehouse where tbl_Stocks.bookID = tbl_Book.bookID " +
                "and tbl_Stocks.warehouseID = tbl_Warehouse.warehouseID ";
        public FrmStock()
        {
            InitializeComponent();
        }
        void ObjClose()
        {
            txtRetail.Enabled = false;
            txtDiscount.Enabled = false;
            txtPreStock.Enabled = false;
            txtSelect1.Enabled = false;
            txtSelect2.Enabled = false;
            txtImportPrice.Enabled = false;
            txtImportAmount.Enabled = false;
        }
        bool RefreshStockData(string  sqlStr)
        {
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvStock.DataSource = ds.Tables[0];
                dgrdvStock.Columns[0].HeaderText = "仓库编号";
                dgrdvStock.Columns[0].Width = 100;
                dgrdvStock.Columns[1].HeaderText = "仓库所在地";
                dgrdvStock.Columns[1].Width = 100;
                dgrdvStock.Columns[2].HeaderText = "书籍编号";
                dgrdvStock.Columns[2].Width = 100;
                dgrdvStock.Columns[3].HeaderText = "书名";
                dgrdvStock.Columns[3].Width = 165;
                dgrdvStock.Columns[4].HeaderText = "零售价";
                dgrdvStock.Columns[4].Width = 80;
                dgrdvStock.Columns[5].HeaderText = "折扣信息";
                dgrdvStock.Columns[5].Width = 80;
                dgrdvStock.Columns[6].HeaderText = "当前库存";
                dgrdvStock.Columns[6].Width = 80;
                return true;
            }
            else
            {
                dgrdvStock.DataSource = null;
                return false;
            }
        }
        void RefreshImportData()
        {
            string sqlStr1;
            DataSet ds1 = new DataSet();
            sqlStr1 = "select tbl_ImportList.warehouseID, tbl_Warehouse.warehouseCity, tbl_Book.bookID," +
                " tbl_Book.title, tbl_ImportList.importPrice, tbl_ImportList.importNumber, tbl_ImportList.status, tbl_ImportList.generateDateTime " +
                " from tbl_ImportList , tbl_Book, tbl_Warehouse where tbl_ImportList.bookID = tbl_Book.bookID " +
                "and tbl_ImportList.warehouseID = tbl_Warehouse.warehouseID ";
            ds1 = CDataBase.GetDataFromDB(sqlStr1);
            if (ds1 != null)
            {
                dgrdvImportList.DataSource = ds1.Tables[0];
                dgrdvImportList.Columns[0].HeaderText = "仓库编号";
                dgrdvImportList.Columns[0].Width = 80;
                dgrdvImportList.Columns[1].HeaderText = "仓库所在地";
                dgrdvImportList.Columns[1].Width = 95;
                dgrdvImportList.Columns[2].HeaderText = "书籍编号";
                dgrdvImportList.Columns[2].Width = 80;
                dgrdvImportList.Columns[3].HeaderText = "书名";
                dgrdvImportList.Columns[3].Width = 78;
                dgrdvImportList.Columns[4].HeaderText = "进货价";
                dgrdvImportList.Columns[4].Width = 75;
                dgrdvImportList.Columns[5].HeaderText = "进货数量";
                dgrdvImportList.Columns[5].Width = 80;
                dgrdvImportList.Columns[6].HeaderText = "当前状态";
                dgrdvImportList.Columns[6].Width = 80;
                dgrdvImportList.Columns[7].HeaderText = "生成日期";
                dgrdvImportList.Columns[7].Width = 135;
            }
            else
            {
                dgrdvImportList.DataSource = null;
            }
        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshStockData(publicSqlString1);
                RefreshImportData();
                ObjClose();
                btnImport.Enabled = false;
                btnRise.Enabled = false;
                btnDown.Enabled = false;
                btnSelect.Enabled = false;
                btnReturn.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrdvStock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dgrdvStock.CurrentCell.RowIndex;
                if (n < dgrdvStock.RowCount - 1)
                {
                    txtRetail.Text = dgrdvStock[4, n].Value.ToString().Trim();
                    txtDiscount.Text = dgrdvStock[5, n].Value.ToString().Trim();
                    txtPreStock.Text = dgrdvStock[6, n].Value.ToString().Trim();
                    btnImport.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
            txtSelect1.Enabled = true;
            txtSelect1.Text = "";
            txtSelect2.Text = "";
            if(cmbSelect.SelectedIndex >=1 && cmbSelect.SelectedIndex <=3)
            {
                txtSelect2.Enabled = true;
                btnRise.Enabled = true;
                btnDown.Enabled = true;
            }
            else if(cmbSelect.SelectedIndex == 0)
            {
                txtSelect2.Enabled = false;
                btnRise.Enabled = false;
                btnDown.Enabled = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                if (cmbSelect.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择查询条件!", "提示");
                    return;
                }
                if (txtSelect1.Text.Trim() == "")
                {
                    MessageBox.Show("请输入需要查询的“" + cmbSelect.SelectedItem.ToString().Trim() + "”!", "提示");
                    return;
                }
                if (cmbSelect.SelectedIndex == 0)
                    sqlStr =publicSqlString1 +" and tbl_Stocks.bookID ='"+ txtSelect1.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 1)
                {
                    if(txtSelect2.Text.Trim()=="")
                    {
                        sqlStr = publicSqlString1 + " and tbl_Book.retailPrice = " +Convert.ToDouble(txtSelect1.Text.Trim());
                    }
                    else
                    {
                        sqlStr = publicSqlString1 + " and tbl_Book.retailPrice >= " + Convert.ToDouble(txtSelect1.Text.Trim()) +
                            " and  tbl_Book.retailPrice <= " + Convert.ToDouble(txtSelect2.Text.Trim());
                    }
                }
                else if (cmbSelect.SelectedIndex == 2)
                {
                    if (txtSelect2.Text.Trim() == "")
                    {
                        sqlStr = publicSqlString1 + " and tbl_Book.discountRate = " + Convert.ToDouble(txtSelect1.Text.Trim());
                    }
                    else
                    {
                        sqlStr = publicSqlString1 + " and tbl_Book.discountRate >= " + Convert.ToDouble(txtSelect1.Text.Trim()) +
                            " and  tbl_Book.discountRate <= " + Convert.ToDouble(txtSelect2.Text.Trim());
                    }
                }
                else if (cmbSelect.SelectedIndex == 3)
                {
                    if (txtSelect2.Text.Trim() == "")
                    {
                        sqlStr = publicSqlString1 + " and tbl_Stocks.leftAmount = " + Convert.ToInt32(txtSelect1.Text.Trim());
                    }
                    else
                    {
                        sqlStr = publicSqlString1 + " and tbl_Stocks.leftAmount >= " + Convert.ToInt32(txtSelect1.Text.Trim()) +
                            " and  tbl_Stocks.leftAmount <= " + Convert.ToInt32(txtSelect2.Text.Trim());
                    }
                }
                bool a = RefreshStockData(sqlStr);
                if (a == false)
                {
                    MessageBox.Show("没有符合条件的库存记录!", "提示");
                    txtSelect1.Text = "";
                    txtSelect2.Text = "";
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
                bool a = RefreshStockData(publicSqlString1);
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRise_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                if (cmbSelect.SelectedIndex == 1)
                    sqlStr = publicSqlString1+" order by tbl_Book.retailPrice";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = publicSqlString1 + " order by tbl_Book.discountRate";
                else if (cmbSelect.SelectedIndex == 3)
                    sqlStr = publicSqlString1 + " order by tbl_Stocks.leftAmount";              
                bool a = RefreshStockData(sqlStr);
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                if (cmbSelect.SelectedIndex == 1)
                    sqlStr = publicSqlString1 + " order by tbl_Book.retailPrice desc";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = publicSqlString1 + " order by tbl_Book.discountRate desc";
                else if (cmbSelect.SelectedIndex == 3)
                    sqlStr = publicSqlString1 + " order by tbl_Stocks.leftAmount desc";
                bool a = RefreshStockData(sqlStr);
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnImport.Text=="进货")
                {
                    btnImport.Text = "确定";
                    txtImportPrice.Enabled = true;
                    txtImportAmount.Enabled = true;
                    return;
                }
                else
                {
                    btnImport.Text = "进货";                    
                    txtImportPrice.Enabled = false;
                    txtImportAmount.Enabled = false;
                    if (dgrdvStock.DataSource == null)
                    {
                        MessageBox.Show("没有选择想要进货的书籍!", "提示");
                        return;
                    }
                    if(txtImportPrice.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入进货价!", "提示");
                        return;
                    }
                    else if(Convert.ToDouble(txtImportPrice.Text.Trim()) <0)
                    {
                        MessageBox.Show("进货价须大于零","提示");
                        return;
                    }
                    else if(Convert.ToInt32(txtImportAmount.Text.Trim()) <0)
                    {
                        MessageBox.Show("进货数量须大于零", "提示");
                        return;
                    }
                    else if(txtImportAmount.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入进货数量!", "提示");
                        return;
                    }
                    int n = dgrdvStock.CurrentCell.RowIndex;
                    string warehouseID, bookID;
                    warehouseID = dgrdvStock[0, n].Value.ToString().Trim();
                    bookID = dgrdvStock[2, n].Value.ToString().Trim();
                    string sqlStr;
                    sqlStr = "select * from tbl_ImportList where warehouseID='" + warehouseID +
                    "' and bookID='" + bookID + "'";
                    if (CDataBase.GetDataFromDB(sqlStr) != null)
                    {
                        if (MessageBox.Show("进货清单中已经存在该书的进货信息，仍然选择进货？",
                         "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            ;
                        }
                        else
                        {
                            return;
                        }
                    }
                    DateTime generateDateTime = new DateTime();
                    generateDateTime = System.DateTime.Now;
                    sqlStr = "insert into tbl_ImportList values('" + warehouseID + "','" + bookID + "','" +
                    generateDateTime.ToString().Trim() +"', " + Convert.ToDouble(txtImportPrice.Text.Trim()) +" , " + 
                    Convert.ToInt32(txtImportAmount.Text.Trim()) +" , " +"'未付款')";
                    CDataBase.UpdateDB(sqlStr);
                    sqlStr = "delete from tbl_ImportList where status = '已付款' or status ='已退货'";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshImportData();
                    MessageBox.Show("添加进货清单成功!", "提示");
                    btnPay.Enabled = true;          
                    txtImportPrice.Text = "";
                    txtImportAmount.Text = "";
                }                
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            if (ob_FrmWarehouse == null || ob_FrmWarehouse.IsDisposed)
            {
                ob_FrmWarehouse = new FrmWarehouse();
                ob_FrmWarehouse.Show();
            }
            else
            {
                ob_FrmWarehouse.Activate();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                double totalPay = 0.0;
                double importPrice;
                int importAmount;
                int rowNum = dgrdvImportList.RowCount - 1;
                for(int i =0; i < rowNum ; i++)
                {
                    importPrice=Convert.ToDouble(dgrdvImportList[4,i].Value.ToString().Trim());
                    importAmount=Convert.ToInt32(dgrdvImportList[5,i].Value.ToString().Trim());
                    if(dgrdvImportList[6,i].Value.ToString().Trim() == "未付款")
                    {
                        totalPay +=(importPrice * importAmount);
                    }
                }
                if(totalPay == 0.0)
                {
                    MessageBox.Show("当前没有订货清单需要付款!", "提示");
                    return;
                }
                if (MessageBox.Show("订货清单付款总额为：" +totalPay.ToString() +"元\n       确定要付款吗?", "订货清单付款",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr1, sqlStr2;
                    sqlStr1 = "update tbl_ImportList set status = '已付款' where status = '未付款' ";
                    CDataBase.UpdateDB(sqlStr1);
                    RefreshImportData();
                    int rowNum1 = dgrdvImportList.RowCount - 1;
                    string sqlStr3,sqlStr4, warehouseID, bookID;
                    double importPrice1;
                    int importNumber;
                    for (int i = 0; i < rowNum1; i++)
                    {
                        if (dgrdvImportList[6, i].Value.ToString().Trim() == "已付款")
                        {
                            warehouseID = dgrdvImportList[0, i].Value.ToString().Trim();
                            bookID = dgrdvImportList[2, i].Value.ToString().Trim();
                            importPrice1=Convert.ToDouble(dgrdvImportList[4,i].Value.ToString().Trim());
                            importNumber=Convert.ToInt32(dgrdvImportList[5,i].Value.ToString().Trim());
                            sqlStr3 = "update tbl_Book set importPrice = " + importPrice1 + ", profit = retailPrice - " + importPrice1 +
                                " , profitRate = (retailPrice-" + importPrice1 + ")/" + importPrice1 + " where bookID='" +
                                bookID + "'";
                            sqlStr4 = "update tbl_Stocks set leftAmount = leftAmount + " + importNumber +
                                " where warehouseID='" + warehouseID + "' and bookID='" + bookID + "'";
                            if(!CDataBase.UpdateDB(sqlStr3) || !CDataBase.UpdateDB(sqlStr4))
                            {
                                MessageBox.Show("添加库存失败!", "警告");
                                return;
                            }
                        }
                    }
                    DateTime dtFinance = System.DateTime.Now;
                    string generateDate = dtFinance.ToString().Trim();
                    string financeID = generateDate.Replace('/', '0').Replace(' ', '0').Replace(':', '0');
                    sqlStr2 = "insert into tbl_Finance values('" + financeID + "', " + totalPay + " , '出账' , '" +
                        CPublic.userInfo[0] + "', '" + generateDate + "')";
                    CDataBase.UpdateDB(sqlStr2);
                    btnPay.Enabled = false;
                    RefreshStockData(publicSqlString1);
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }            
        }

        private void dgrdvImportList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dgrdvImportList.CurrentCell.RowIndex;
            string status = dgrdvImportList[6, n].Value.ToString().Trim();
            if(status == "未付款")
            {
                btnReturn.Enabled = true;
            }     
            else
            {
                btnReturn.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "delete from tbl_ImportList where status = '已付款' or status ='已退货'";
                if(CDataBase.UpdateDB(sqlStr))
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgrdvImportList.CurrentCell.RowIndex;
                string warehouseID = dgrdvImportList[0, n].Value.ToString().Trim();
                string bookID = dgrdvImportList[2, n].Value.ToString().Trim();
                string generateDate = dgrdvImportList[7, n].Value.ToString().Trim();
                if (MessageBox.Show("确定要退货吗？", "退货",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "update tbl_ImportList set status = '已退货' where warehouseID='" + warehouseID+
                        "' and bookID='" + bookID + "' and generateDateTime='" + generateDate +"'";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshImportData();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (ob_FrmAddNewBook == null || ob_FrmAddNewBook.IsDisposed)
            {
                ob_FrmAddNewBook = new FrmAddNewBook();
                ob_FrmAddNewBook.Show();
            }
            else
            {
                ob_FrmAddNewBook.Activate();
            }
        }

        private void FrmStock_Activated(object sender, EventArgs e)
        {
            FrmStock_Load(sender, e);
        }
        
    }
}
