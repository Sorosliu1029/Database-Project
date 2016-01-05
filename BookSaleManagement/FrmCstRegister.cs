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
    public partial class FrmCstRegister : Form
    {
        public FrmCstRegister()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtUserName.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtComfirmPassword.Text = "";
            txtUserName.Focus();
        }
        bool UserName(string userName)
        {
            string sqlStr = "select customerEmail from tbl_Customer where customerEmail='" + userName + "'";
            CDataBase.conn.ConnectionString = CDataBase.connStr;
            SqlCommand cmd = new SqlCommand(sqlStr, CDataBase.conn);
            CDataBase.conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                CDataBase.conn.Close();
                return false;
            }
            CDataBase.conn.Close();
            return true;
        }

        private void FrmCstRegister_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Enabled = true;
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("注册邮箱不能为空", "提示");
                    txtUserName.Focus();
                }
                else if (!UserName(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("该用户已存在!", "提示");
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
                else if (txtName.Text.Trim() == "")
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
                else if (txtPassword.Text.Trim() == "" && txtComfirmPassword.Text.Trim() =="" )
                {
                    MessageBox.Show("密码不能为空", "提示");
                    txtPassword.Focus();
                }
                else if (txtPassword.Text.Trim() != txtComfirmPassword.Text.Trim() )
                {
                    MessageBox.Show("两次密码不一致", "提示");
                    txtPassword.Text = "";
                    txtComfirmPassword.Text = "";
                    txtPassword.Focus();
                }
                else
                {
                    string sqlStr1 = "insert into tbl_User values('" + txtUserName.Text.Trim() + "','" +
                        CPublic.GetMd5Str(txtPassword.Text.Trim()) + "','" + "顾客" + "','" + "是" + "')";
                    string sqlStr2 = "insert into tbl_Customer values('" + txtUserName.Text.Trim() + "','" +
                    txtName.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + "10000.00" + "')";
                    if (CDataBase.UpdateDB(sqlStr1) && CDataBase.UpdateDB(sqlStr2))
                        MessageBox.Show("顾客：" + txtUserName.Text + " 注册成功!", "恭喜");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
