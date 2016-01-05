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
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }
        void ObjUpdateOpen()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtPublisher.Enabled = true;
            txtYear.Enabled = true;
            txtRetail.Enabled = true;
            txtImport.Enabled = true;
            txtDiscount.Enabled = true;
            txtTitle.Focus();
        }
        void ObjAddOpen()
        {
            txtBookID.Enabled = true;
            txtISBN.Enabled = true;
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtPublisher.Enabled = true;
            txtYear.Enabled = true;
            txtRetail.Enabled = true;
            txtImport.Enabled = true;
            txtDiscount.Enabled = true;
            txtBookID.Focus();
        }
        void ObjClose()
        {
            txtBookID.Enabled = false;
            txtISBN.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtPublisher.Enabled = false;
            txtYear.Enabled = false;
            txtRetail.Enabled = false;
            txtImport.Enabled = false;
            txtProfit.Enabled = false;
            txtProfitRate.Enabled = false;
            txtDiscount.Enabled = false;
        }
        void SortOpen()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
        }
        void SortClose()
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }
        void ClearAll()
        {
            txtBookID.Text = "";
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            txtRetail.Text = "";
            txtImport.Text = "";
            txtProfit.Text = "";
            txtProfitRate.Text = "";
            txtDiscount.Text = "";
            txtBookID.Focus();
        }
        bool RefreshData(string sqlStr)
        {
            DataSet ds = new DataSet();            
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvBook.DataSource = ds.Tables[0];
                dgrdvBook.Columns[0].HeaderText = "书籍编号";
                dgrdvBook.Columns[0].Width = 80;
                dgrdvBook.Columns[1].HeaderText = "ISBN";
                dgrdvBook.Columns[1].Width = 80;
                dgrdvBook.Columns[2].HeaderText = "书名";
                dgrdvBook.Columns[2].Width = 115;
                dgrdvBook.Columns[3].HeaderText = "作者";
                dgrdvBook.Columns[3].Width = 60;
                dgrdvBook.Columns[4].HeaderText = "出版社";
                dgrdvBook.Columns[4].Width = 70;
                dgrdvBook.Columns[5].HeaderText = "出版年份";
                dgrdvBook.Columns[5].Width = 80;
                dgrdvBook.Columns[6].HeaderText = "零售价";
                dgrdvBook.Columns[6].Width = 70;
                dgrdvBook.Columns[7].HeaderText = "进货价";
                dgrdvBook.Columns[7].Width = 70;
                dgrdvBook.Columns[8].HeaderText = "利润";
                dgrdvBook.Columns[8].Width = 40;
                dgrdvBook.Columns[9].HeaderText = "利润率";
                dgrdvBook.Columns[9].Width = 70;
                dgrdvBook.Columns[10].HeaderText = "折扣信息";
                dgrdvBook.Columns[10].Width = 80;
                dgrdvBook_RowHeaderMouseClick(null, null);
                return true;
            }
            else
            {
                dgrdvBook.DataSource = null;
                return false;
            }
        }      
        bool No(string no)
        {
            int n = dgrdvBook.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (no == dgrdvBook.Rows[i].Cells[0].Value.ToString().Trim())
                    return false;
            }
            return true;
        }
        string ToPerCent(double a)
        {
            double b = ( (int)(a * 10000) / 100.00);
            return (b.ToString() + "%");
        }
        double TDouble(string a)
        {
            int n = a.IndexOf('%');
            return Convert.ToInt32(a.Substring(0, n)) / 100.00;
        }
        private void FrmBook_Load(object sender, EventArgs e)
        {
            try
            {
                ObjClose();
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                cmbSelect.SelectedIndex = 0;
                bool a = RefreshData("select * from tbl_Book");
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTitle.Enabled)
            {
                if (MessageBox.Show("数据尚未保存,要关闭窗口吗?", "询问", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgrdvBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = dgrdvBook.CurrentCell.RowIndex;
                if (n < dgrdvBook.RowCount - 1)
                {
                    txtBookID.Text = dgrdvBook[0, n].Value.ToString().Trim();
                    txtISBN.Text = dgrdvBook[1, n].Value.ToString().Trim();
                    txtTitle.Text = dgrdvBook[2, n].Value.ToString().Trim();
                    txtAuthor.Text = dgrdvBook[3, n].Value.ToString().Trim();
                    txtPublisher.Text = dgrdvBook[4, n].Value.ToString().Trim();
                    txtYear.Text = dgrdvBook[5, n].Value.ToString().Trim();
                    txtRetail.Text = dgrdvBook[6, n].Value.ToString().Trim();
                    txtImport.Text = dgrdvBook[7, n].Value.ToString().Trim();
                    txtProfit.Text = dgrdvBook[8, n].Value.ToString().Trim();
                    txtProfitRate.Text = ToPerCent( Convert.ToDouble(dgrdvBook[9, n].Value.ToString().Trim()) );
                    txtDiscount.Text = ToPerCent(Convert.ToDouble(dgrdvBook[10, n].Value.ToString().Trim()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text.Trim() == "添加")
                {
                    btnAdd.Text = "确定";
                    ObjAddOpen();
                    bool a = RefreshData("select * from tbl_Book");
                    ClearAll();
                    txtDiscount.Text = "%形式";
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    cmbSelect.Enabled = false;
                    txtSelect.Enabled = false;
                    btnSelect.Enabled = false;
                    btnAll.Enabled = false;
                    btnUp.Enabled = false;
                    btnDown.Enabled = false;
                    dgrdvBook.Enabled = false;
                    return;
                }
                else if (txtBookID.Text.Trim() == "")
                {
                    MessageBox.Show("书籍编号不能为空!", "提示");
                    txtBookID.Focus();
                    return;
                }
                else if (txtISBN.Text.Trim() == "")
                {
                    MessageBox.Show("ISBN不能为空!", "提示");
                    txtISBN.Focus();
                    return;
                }
                else if (txtTitle.Text.Trim() == "")
                {
                    MessageBox.Show("书名不能为空!", "提示");
                    txtTitle.Focus();
                    return;
                }
                else if (txtAuthor.Text == "")
                {
                    MessageBox.Show("作者不能为空!", "提示");
                    txtAuthor.Focus();
                    return;
                }
                else if (txtPublisher.Text.Trim() == "")
                {
                    MessageBox.Show("出版社不能为空!", "提示");
                    txtPublisher.Focus();
                    return;
                }
                else if (txtYear.Text.Trim() == "")
                {
                    MessageBox.Show("出版年份不能为空!", "提示");
                    txtYear.Focus();
                    return;
                }
                else if (txtRetail.Text.Trim() == "")
                {
                    MessageBox.Show("零售价不能为空!", "提示");
                    txtRetail.Focus();
                    return;
                }
                else if (txtImport.Text.Trim() == "")
                {
                    MessageBox.Show("进货价不能为空!", "提示");
                    txtImport.Focus();
                    return;
                }
                else if (txtDiscount.Text.Trim() == "")
                {
                    MessageBox.Show("折扣信息不能为空!", "提示");
                    txtDiscount.Focus();
                    return;
                }
                else if (!No(txtBookID.Text.Trim()))
                {
                    MessageBox.Show("该书已存在!", "提示");
                    ClearAll();
                    return;
                }
                btnAdd.Text = "添加";
                double retail = Convert.ToDouble(txtRetail.Text.Trim()) ;
                double import =  Convert.ToDouble(txtImport.Text.Trim()) ;
                string sqlStr = "insert into tbl_Book values('" + txtBookID.Text.Trim() + "','"
                    + txtISBN.Text.Trim() + "','" + txtTitle.Text.Trim() + "','" + txtAuthor.Text.Trim() + "','"
                    + txtPublisher.Text.Trim() + "','" + txtYear.Text.Trim() + "','" + txtRetail.Text.Trim() + "','"
                    + txtImport.Text.Trim() + "', " + (retail - import) + " , " + ((retail - import) / import)
                    + " , '" + TDouble(txtDiscount.Text.Trim()) + "')";
                CDataBase.UpdateDB(sqlStr);
                bool b = RefreshData("select * from tbl_Book");
                if (MessageBox.Show("添加成功!继续添加吗?", "添加书籍", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ClearAll();
                    ObjAddOpen();
                    btnAdd.Text = "确定";
                }
                else
                {
                    ObjClose();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    cmbSelect.Enabled = true;
                    txtSelect.Enabled = true;
                    btnSelect.Enabled = true;
                    btnAll.Enabled = true;
                    dgrdvBook.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
                ObjClose();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClose.Enabled = true;
                cmbSelect.Enabled = true;
                txtSelect.Enabled = true;
                btnSelect.Enabled = true;
                btnAll.Enabled = true;
                dgrdvBook.Enabled = true;
                dgrdvBook_RowHeaderMouseClick(null, null);
            }
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
                    sqlStr = "select * from tbl_Book where BookID " +op +" '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 1)
                    sqlStr = "select * from tbl_Book where ISBN " +op +" '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = "select * from tbl_Book where title " + op + " '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 3)
                    sqlStr = "select * from tbl_Book where bookAuthor " + op + " '" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 4)
                    sqlStr = "select * from tbl_Book where bookPublisher " + op + " '" + txtSelect.Text.Trim() + "'";
                else
                {
                    if (cmbSelect.SelectedIndex == 5)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where year " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where year >=" + Convert.ToInt32(s1) +
                            " and year <=" + Convert.ToInt32(s2);
                        }
                    }
                    else if (cmbSelect.SelectedIndex == 6)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where retailPrice " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where retailPrice >=" + Convert.ToDouble(s1) +
                            " and retailPrice <=" + Convert.ToDouble(s2);
                        }
                    }
                    else if (cmbSelect.SelectedIndex == 7)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where importPrice " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where importPrice >=" + Convert.ToDouble(s1) +
                            " and importPrice <=" + Convert.ToDouble(s2);
                        }
                    }
                    else if (cmbSelect.SelectedIndex == 8)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where profit " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where profit >=" + Convert.ToDouble(s1) +
                            " and profit <=" + Convert.ToDouble(s2);
                        }
                    }
                    else if (cmbSelect.SelectedIndex == 9)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where profitRate " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where profitRate >=" + Convert.ToDouble(s1) +
                            " and profitRate <=" + Convert.ToDouble(s2);
                        }
                    }
                    else if (cmbSelect.SelectedIndex == 10)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if (d < 0)
                        {
                            sqlStr = "select * from tbl_Book where discountRate " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Book where discountRate >=" + Convert.ToDouble(s1) +
                            " and discountRate <=" + Convert.ToDouble(s2);
                        }
                    }
                }
                bool a = RefreshData(sqlStr);
                if(a == false)
                {
                    MessageBox.Show("没有符合条件的书籍记录!", "提示");
                    txtSelect.Text = "";
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex >=5 && cmbSelect.SelectedIndex <= 10)
            {
                txtSelect.Text = "支持范围查询, 如输入\"0,10\"可得到 >=0, <= 10的结果";
                SortOpen();
            }
            else
            {
                txtSelect.Text = "支持包含'%'的通配符查询,如'%明'可查询到'小明'";
                SortClose();
            }
        }

        private void txtSelect_Click(object sender, EventArgs e)
        {
            txtSelect.Text = "";
        }

        private void txtSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = RefreshData("select * from tbl_Book");
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnUpdate.Text.Trim() == "修改")
                {
                    btnUpdate.Text = "确定";
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    cmbSelect.Enabled = false;
                    txtSelect.Enabled = false;
                    btnSelect.Enabled = false;
                    btnAll.Enabled = false;
                    btnUp.Enabled = false;
                    btnDown.Enabled = false;
                    dgrdvBook.Enabled = false;
                    ObjUpdateOpen();
                }
                else
                {
                    btnUpdate.Text = "修改";
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    cmbSelect.Enabled = true;
                    txtSelect.Enabled = true;
                    btnSelect.Enabled = true;
                    btnAll.Enabled = true;
                    btnUp.Enabled = true;
                    btnDown.Enabled = true;
                    dgrdvBook.Enabled = true;
                    ObjClose();
                    double retail = Convert.ToDouble(txtRetail.Text.Trim());
                    double import = Convert.ToDouble(txtImport.Text.Trim());
                    string sqlStr;
                    sqlStr = "update tbl_Book set bookID='" + txtBookID.Text.Trim() + "',ISBN='" +
                                    txtISBN.Text.Trim() + "',title='" + txtTitle.Text.Trim() + "',bookAuthor='" +
                                    txtAuthor.Text.Trim() + "',bookPublisher='" + txtPublisher.Text.Trim() + "',year='" +
                                    txtYear.Text.Trim() +"',retailPrice =" + retail + " ,importPrice =" +
                                    import + " ,profit = " + (retail - import) + " ,profitRate = " +
                                    ((retail - import)/import)+ " ,discountRate = " +TDouble(txtDiscount.Text.Trim()) + 
                                    " where bookID='" + txtBookID.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    bool b = RefreshData("select * from tbl_Book");
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookID.Text.Trim() == "")
                {
                    MessageBox.Show("没有可删除的记录!", "提示");
                    return;
                }
                string sqlStr1 = "select * from tbl_ShoppingBasket where bookID='" + txtBookID.Text.Trim() + "'";
                string sqlStr2 = "select * from tbl_OrderForm where bookID='" + txtBookID.Text.Trim() + "'";
                string sqlStr3 = "select * from tbl_ImportList where bookID='" + txtBookID.Text.Trim() + "'";
                string sqlStr4 = "select * from tbl_Stocks where bookID='" + txtBookID.Text.Trim() + "'";
                if (CDataBase.GetDataFromDB(sqlStr1) != null)
                {
                    MessageBox.Show("顾客购物篮中存在这本书,不能删除该书!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CDataBase.GetDataFromDB(sqlStr2) != null)
                {
                    MessageBox.Show("顾客订单中存在这本书,不能删除该书!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CDataBase.GetDataFromDB(sqlStr3) != null)
                {
                    MessageBox.Show("进货清单中存在这本书,不能删除该书!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CDataBase.GetDataFromDB(sqlStr4) != null)
                {
                    string sqlStr5 = "delete from tbl_Stocks where bookID='" + txtBookID.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr5);
                }
                else if (MessageBox.Show("确定要删除书籍“" + txtTitle.Text.Trim() + "”吗?", "删除书籍",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "delete from tbl_Book where bookID='" + txtBookID.Text.Trim() + "'";
                    CDataBase.UpdateDB(sqlStr);
                    int n = dgrdvBook.CurrentCell.RowIndex;
                    dgrdvBook.Rows.RemoveAt(n);
                    if (dgrdvBook.Rows.Count == 1)
                    {
                        ClearAll();
                        dgrdvBook.DataSource = null;
                    }
                    else
                    {
                        dgrdvBook_RowHeaderMouseClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                if (cmbSelect.SelectedIndex == 5)
                    sqlStr = "select * from tbl_Book order by year";
                else if (cmbSelect.SelectedIndex == 6)
                    sqlStr = "select * from tbl_Book order by retailPrice";
                else if (cmbSelect.SelectedIndex == 7)
                    sqlStr = "select * from tbl_Book order by importPrice";
                else if (cmbSelect.SelectedIndex == 8)
                    sqlStr = "select * from tbl_Book order by profit";
                else if (cmbSelect.SelectedIndex == 9)
                    sqlStr = "select * from tbl_Book order by profitRate";
                else if (cmbSelect.SelectedIndex == 10)
                    sqlStr = "select * from tbl_Book order by discountRate";                
                bool a = RefreshData(sqlStr);
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
                if (cmbSelect.SelectedIndex == 5)
                    sqlStr = "select * from tbl_Book order by year desc";
                else if (cmbSelect.SelectedIndex == 6)
                    sqlStr = "select * from tbl_Book order by retailPrice desc";
                else if (cmbSelect.SelectedIndex == 7)
                    sqlStr = "select * from tbl_Book order by importPrice desc";
                else if (cmbSelect.SelectedIndex == 8)
                    sqlStr = "select * from tbl_Book order by profit desc";
                else if (cmbSelect.SelectedIndex == 9)
                    sqlStr = "select * from tbl_Book order by profitRate desc";
                else if (cmbSelect.SelectedIndex == 10)
                    sqlStr = "select * from tbl_Book order by discountRate desc";
                bool a = RefreshData(sqlStr);
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "";
        }

    }
}
