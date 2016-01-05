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
    public partial class FrmCompleteCustomerInfo : Form
    {
        public FrmCompleteCustomerInfo()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }
        void ObjOpen()
        {
            txtUserName.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            txtName.Focus();
        }
        void ObjClose()
        {
            txtUserName.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("姓名不能为空", "提示");
                    txtName.Focus();
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("电话不能为空", "提示");
                    txtPhone.Focus();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("地址不能为空", "提示");
                    txtAddress.Focus();
                }
                else
                {
                    string sqlStr = "insert into tbl_Customer values('" + txtUserName.Text.Trim() + "','" +
                    txtName.Text.Trim() + "','" + txtPhone.Text.Trim() + "','"  + txtAddress.Text.Trim() + "','" +"10000.00" + "')";
                    if (CDataBase.UpdateDB(sqlStr))
                        MessageBox.Show("顾客：" + txtUserName.Text + " 信息完善成功!", "完善用户信息");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void FrmCompleteCustomerInfo_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = CPublic.userName;
                ObjOpen();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}
