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
    public partial class FrmInfoCustomer : Form
    {
        bool set = true;
        string customerName;
        string balance;
        public FrmInfoCustomer()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtName1.Text = customerName;
            txtBalance.Text = balance;
            txtName1.Focus();
        }
        void ObjClose()
        {
            txtUserName.Enabled = false;
            txtBalance.Enabled = false;
            btnSetPswPctQuestion.Enabled = false;
            btnDeletePswPctQuestion.Enabled = false;
            txtName.Enabled = false;
            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
        }
        private void FrmInfoCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlStr1 = "select customerEmail, customerName, customerPhone, customerAddress, balance from tbl_Customer " +
                    "where customerEmail='" + CPublic.userInfo[0] + "'";
                SqlCommand cmd1 = new SqlCommand(sqlStr1, CDataBase.conn);
                CDataBase.conn.Open();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                if (sdr1.Read())
                {
                    txtUserName.Text = sdr1["customerEmail"].ToString().Trim();
                    txtName1.Text = sdr1["customerName"].ToString().Trim();
                    txtPhone.Text = sdr1["customerPhone"].ToString().Trim();
                    txtAddress.Text = sdr1["customerAddress"].ToString().Trim();
                    txtBalance.Text = sdr1["balance"].ToString().Trim();                    
                    customerName = txtName1.Text;
                    balance = txtBalance.Text;

                }
                if (CPublic.userInfo[3].Trim() == "是")
                {
                    btnSetPswPctQuestion.Enabled = true;
                    txtUserName.Enabled = false;
                    txtBalance.Enabled = false;
                    btnDeletePswPctQuestion.Enabled = false;
                }
                else
                {
                    ObjClose();
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

        private void btnChagePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (CPublic.GetMd5Str(txtOldPassword.Text.Trim()) != CPublic.userInfo[1])
                {
                    MessageBox.Show("旧密码错误,请重新输入", "提示");
                    txtOldPassword.Text = "";
                    txtNewPassword1.Text = "";
                    txtNewPassword2.Text = "";
                    txtOldPassword.Focus();
                }
                else if (txtNewPassword1.Text.Trim() == "" && txtNewPassword2.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空", "提示");
                    txtNewPassword1.Focus();
                }
                else if (txtNewPassword1.Text.Trim() == txtNewPassword2.Text.Trim())
                {
                    string psw = CPublic.GetMd5Str(txtNewPassword1.Text.Trim());
                    string sqlStr = "update tbl_User set userPassword='" + psw.Trim() + "' where userName='" +
                    CPublic.userInfo[0] + "'";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        CPublic.userInfo[1] = psw.Trim();
                        MessageBox.Show("修改成功,请记住您的新密码", "修改密码");
                        txtOldPassword.Text = "";
                        txtNewPassword1.Text = "";
                        txtNewPassword2.Text = "";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChagePassword_Click(sender, e);
            }
        }

        private void btnSetPswPctQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled == false)
                {
                    txtName.Enabled = true;
                    txtAnswer1.Enabled = true;
                    txtAnswer2.Enabled = true;
                    txtAnswer3.Enabled = true;
                    txtName.Focus();
                    btnSetPswPctQuestion.Text = "确定";
                }
                else
                {
                    if (txtName.Text.Trim() == "")
                    {
                        MessageBox.Show("姓名不能为空", "提示");
                        txtName.Focus();
                        return;
                    }
                    else if (txtAnswer1.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入第一个问题的答案", "提示");
                        txtAnswer1.Focus();
                        return;
                    }
                    else if (txtAnswer2.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入第二个问题的答案", "提示");
                        txtAnswer2.Focus();
                        return;
                    }
                    else if (txtAnswer3.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入第三个问题的答案", "提示");
                        txtAnswer3.Focus();
                        return;
                    }
                    string sqlStr;
                    if (set)
                    {
                        sqlStr = "insert into tbl_Information values('" + CPublic.userInfo[0] + "','" +
                        txtName.Text.Trim() + "','" + txtAnswer1.Text.Trim() + "','" + txtAnswer2.Text.Trim()
                        + "','" + txtAnswer3.Text.Trim() + "')";
                        if (CDataBase.UpdateDB(sqlStr))
                        {
                            MessageBox.Show("设置密保问题成功", "恭喜");
                            set = false;
                            sqlStr = "update tbl_User set firstLogin='否' where userName='" + CPublic.userInfo[0] + "'";
                            CDataBase.UpdateDB(sqlStr);
                        }
                    }
                    else
                    {
                        sqlStr = "update tbl_Information set name='" + txtName.Text.Trim() + "',Answer1='"
                        + txtAnswer1.Text.Trim() + "',Answer2='" + txtAnswer2.Text.Trim() + "',Answer3='"
                        + txtAnswer3.Text.Trim() + "' where userName='" + CPublic.userInfo[0] + "'";
                        if (CDataBase.UpdateDB(sqlStr))
                        {
                            MessageBox.Show("修改密保问题成功", "恭喜");
                        }
                    }
                    btnSetPswPctQuestion.Text = "设置密保问题";
                    txtName.Text = "";
                    txtAnswer1.Text = "";
                    txtAnswer2.Text = "";
                    txtAnswer3.Text = "";
                    txtName.Enabled = false;
                    txtBalance.Enabled = false;
                    txtAnswer1.Enabled = false;
                    txtAnswer2.Enabled = false;
                    txtAnswer3.Enabled = false;
                    btnSetPswPctQuestion.Enabled = false;
                    btnDeletePswPctQuestion.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletePswPctQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("删除密保问题答案后,一旦忘记用户密码,将无法找回,确定要删除吗?",
                "删除密保问题答案", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "delete from tbl_Information where userName='" + CPublic.userInfo[0] + "'";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        txtName.Text = "";
                        txtAnswer1.Text = "";
                        txtAnswer2.Text = "";
                        txtAnswer3.Text = "";
                        sqlStr = "update tbl_User set firstLogin='是' where userName='" +
                                        CPublic.userInfo[0] + "'";
                        CDataBase.UpdateDB(sqlStr);
                        MessageBox.Show("删除密保问题成功", "恭喜");
                        set = true;
                        txtName.Focus();
                    }
                }
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

                if (txtName1.Text.Trim() == "")
                {
                    MessageBox.Show("姓名不能为空", "提示");
                    txtName1.Focus();
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
                    string sqlStr = "update tbl_Customer set customerName='" + txtName1.Text.Trim() + "',customerPhone='"
                    + txtPhone.Text.Trim() + "',customerAddress='" + txtAddress.Text.Trim() + "',balance='"
                    + txtBalance.Text.Trim() + "' where customerEmail='" + CPublic.userInfo[0] + "'";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        MessageBox.Show("修改个人信息成功!", "恭喜");
                        customerName = txtName1.Text;
                        balance = txtBalance.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr2 = "select userName, name, answer1, answer2, answer3 from tbl_Information " +
                "where userName='" + CPublic.userInfo[0] + "'";
                SqlCommand cmd2 = new SqlCommand(sqlStr2, CDataBase.conn);
                CDataBase.conn.Open();
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                if (sdr2.Read())
                {
                    txtName.Text = sdr2["name"].ToString().Trim();
                    txtAnswer1.Text = sdr2["answer1"].ToString().Trim();
                    txtAnswer2.Text = sdr2["answer2"].ToString().Trim();
                    txtAnswer3.Text = sdr2["answer3"].ToString().Trim();
                    set = false;
                }
                else
                {
                    MessageBox.Show("您还没有设置个人信息", "提示");
                    txtName.Focus();
                    btnSetPswPctQuestion.Enabled = true;
                    return;
                }
                btnSetPswPctQuestion.Enabled = true;
                btnDeletePswPctQuestion.Enabled = true;
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
    }
}
