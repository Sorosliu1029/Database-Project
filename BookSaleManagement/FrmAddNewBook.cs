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
    public partial class FrmAddNewBook : Form
    {
        public FrmAddNewBook()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtBookID.Text = "";
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            txtImport.Text = "";
            txtImportNumber.Text = "";
            cmbWarehouse.Text = "";
            txtRetail.Text = "";
            txtDiscount.Text = "";
            cmbWarehouse.SelectedIndex = -1;
        }
        bool No(string no)
        {
            string sqlStr = "select * from tbl_Book";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                int n = ds.Tables[0].Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    if (no == ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txtBookID.Text.Trim() == "")
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
                else if(txtImport.Text.Trim() =="")
                {
                    MessageBox.Show("进货价不能为空!", "提示");                    
                    txtImport.Focus();
                    return;
                }
                else if(Convert.ToDouble(txtImport.Text.Trim())<0)
                {
                    MessageBox.Show("进货价不能小于零", "提示");
                    txtImport.Focus();
                    return;
                }
                else if(txtImportNumber.Text.Trim() =="")
                {
                    MessageBox.Show("进货数量不能为空!", "提示");                    
                    txtImportNumber.Focus();
                    return;
                }
                else if (Convert.ToInt32(txtImportNumber.Text.Trim())< 0)
                {
                    MessageBox.Show("进货数量不能小于零!", "提示");
                    txtImportNumber.Focus();
                    return;
                }
                else if (cmbWarehouse.Text.Trim() == "")
                {
                    MessageBox.Show("进货仓库不能为空!", "提示");
                    cmbWarehouse.Focus();
                    return;
                }
                else if (txtRetail.Text.Trim() == "")
                {
                    MessageBox.Show("零售价不能为空!", "提示");                    
                    txtRetail.Focus();
                    return;
                }
                else if(Convert.ToDouble(txtRetail.Text.Trim())< 0)
                {
                    MessageBox.Show("零售价不能小于零!", "提示");
                    txtRetail.Focus();
                    return;
                }
                else if(txtDiscount.Text.Trim() =="")
                {
                    MessageBox.Show("折扣信息不能为空!","提示");                    
                    txtDiscount.Focus();
                    return;
                }
                else if (Convert.ToDouble(txtDiscount.Text.Trim())< 0 || Convert.ToDouble(txtDiscount.Text.Trim()) >1)
                {
                    MessageBox.Show("折扣信息不符合要求","提示");
                    txtDiscount.Focus();
                    return;
                }
                else if (!No(txtBookID.Text.Trim()))
                {
                    MessageBox.Show("该书已存在!", "提示");
                    ClearAll();
                    return;
                }
                double retail = Convert.ToDouble(txtRetail.Text.Trim());
                double import = Convert.ToDouble(txtImport.Text.Trim());
                int importNumber = Convert.ToInt32(txtImportNumber.Text.Trim());
                double discount = Convert.ToDouble(txtDiscount.Text.Trim());
                string sqlStr1 = "insert into tbl_Book values('" + txtBookID.Text.Trim() + "','"
                    + txtISBN.Text.Trim() + "','" + txtTitle.Text.Trim() + "','" + txtAuthor.Text.Trim() + "','"
                    + txtPublisher.Text.Trim() + "','" + txtYear.Text.Trim() + "','" + txtRetail.Text.Trim() + "','"
                    + txtImport.Text.Trim() + "', "  + (retail - import) +" , " + (retail - import)/import + " , " + discount+ " )";                
                DateTime  dt = System.DateTime.Now;
                string generateDateTime = dt.ToString().Trim();
                string sqlStr2 = "insert into tbl_ImportList values('" + cmbWarehouse.SelectedItem.ToString().Trim() + "','" +
                    txtBookID.Text.Trim() + "', '" + generateDateTime + "' , " + import + " , " +
                    importNumber + " , '未付款')";
                string sqlStr3 = "insert into tbl_Stocks values('" + cmbWarehouse.SelectedItem.ToString().Trim() + "','" +
                    txtBookID.Text.Trim() + "', 0 , 0 , 10)";
                if(CDataBase.UpdateDB(sqlStr1) &&CDataBase.UpdateDB(sqlStr2) && CDataBase.UpdateDB(sqlStr3))
                {
                    MessageBox.Show("添加新书成功!", "恭喜");
                }
                ClearAll();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void FrmAddNewBook_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from tbl_Warehouse";
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                int n = ds.Tables[0].Rows.Count;
                cmbWarehouse.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    cmbWarehouse.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                }
                cmbWarehouse.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("没有可用的仓库", "警告");
                this.Close();
            }
        }

    }
}
