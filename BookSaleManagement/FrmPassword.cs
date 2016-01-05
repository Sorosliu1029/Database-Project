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
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword1.Enabled = false;
            txtNewPassword2.Enabled = false;
            btnChangePassword.Enabled = false;
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空", "提示");
                    txtUserName.Focus();
                    return;
                }
                string sqlStr1 = "select userName from tbl_User where userName='" +
                txtUserName.Text.Trim() + "'";
                CDataBase.conn.ConnectionString = CDataBase.connStr;
                SqlCommand cmd1 = new SqlCommand(sqlStr1, CDataBase.conn);
                CDataBase.conn.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                if (!sdr1.Read())
                {
                    CDataBase.conn.Close();
                    MessageBox.Show("您输入的用户名不存在，请返回登录界面并注册", "提示");
                    txtUserName.Text = "";
                    txtUserName.Focus();
                    return;
                }
                else
                {
                    CDataBase.conn.Close();
                }
                string sqlStr2 = "select answer1, answer2, answer3 from tbl_Information where userName='" +
                txtUserName.Text.Trim() + "'";
                SqlCommand cmd2 = new SqlCommand(sqlStr2, CDataBase.conn);
                CDataBase.conn.Open();
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                if (sdr2.Read())
                {
                    string answer1, answer2, answer3;
                    answer1 = sdr2["answer1"].ToString().Trim();
                    answer2 = sdr2["answer2"].ToString().Trim();
                    answer3 = sdr2["answer3"].ToString().Trim();
                    CDataBase.conn.Close();
                    if (answer1 != txtAnswer1.Text.Trim())
                    {
                        MessageBox.Show("第一个问题回答错误", "请重新回答");
                        txtAnswer1.Text = "";
                        txtAnswer1.Focus();
                    }
                    else if (answer2 != txtAnswer2.Text.Trim())
                    {
                        MessageBox.Show("第二个问题回答错误", "请重新回答");
                        txtAnswer2.Text = "";
                        txtAnswer2.Focus();
                    }
                    else if (answer3 != txtAnswer3.Text.Trim())
                    {
                        MessageBox.Show("第三个问题回答错误", "请重新回答");
                        txtAnswer3.Text = "";
                        txtAnswer3.Focus();
                    }
                    else
                    {
                        txtUserName.Enabled = false;
                        txtAnswer1.Enabled = false;
                        txtAnswer2.Enabled = false;
                        txtAnswer3.Enabled = false;
                        btnGetPassword.Enabled = false;
                        txtNewPassword1.Enabled = true;
                        txtNewPassword2.Enabled = true;
                        btnChangePassword.Enabled = true;
                        MessageBox.Show("回答正确,请设置新的用户密码", "恭喜");
                        txtNewPassword1.Focus();
                    }
                }
                else
                {
                    CDataBase.conn.Close();
                    MessageBox.Show("您未设置找回密码问题答案", "无法找回密码",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword1.Text.Trim() == "" && txtNewPassword2.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空", "提示");
                    txtNewPassword1.Focus();
                }
                else if (txtNewPassword1.Text.Trim() == txtNewPassword2.Text.Trim())
                {
                    string sqlStr;
                    string psw = CPublic.GetMd5Str(txtNewPassword1.Text.Trim());
                    sqlStr = "update tbl_User set userPassword='" + psw.Trim() + "' where userName='" +
                    txtUserName.Text.Trim() + "'";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        CPublic.userInfo[1] = psw.Trim();
                        MessageBox.Show("修改成功,请记住您的新密码", "修改密码");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致", "提示");
                    txtNewPassword1.Text = "";
                    txtNewPassword2.Text = "";
                    txtNewPassword1.Focus();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNewPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangePassword_Click(sender, e);
            }
        }
    }
}
