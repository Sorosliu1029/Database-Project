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
using System.IO;

namespace BookSaleManagement
{
    public partial class FrmLogin : Form
    {
        string path = Application.StartupPath + "\\" + "DbSet.ini";
        FrmPassword ob_FrmPassword;
        FrmCstRegister ob_FrmCstRegister;
        void InsertAdminInfo()
        {
            CDataBase.conn.ConnectionString = CDataBase.connStr;
            string psw = CPublic.GetMd5Str(txtSAPassword.Text.Trim());
            string sqlStr1 = "insert into tbl_User values('" + txtSuperAdmin.Text.Trim() + "','" + psw.Trim() + "','超级管理员','是')";
            string sqlStr2 = "insert into tbl_Admin values('" + txtSuperAdmin.Text.Trim() + "','" +
                txtSuperName.Text.Trim() + "','" + "000" + "','" + cmbSuperSex.Text.Trim() + "','" +
                txtSuperAge.Text.Trim() + "','" + "超级管理员" + "','" + "2014-01-01" + "','" + "10000" +"')";
            if (CDataBase.UpdateDB(sqlStr1) && CDataBase.UpdateDB(sqlStr2))
                MessageBox.Show("超级管理员: " + txtSuperAdmin.Text + " 注册成功!"); 
        }
        void CheckAdminInput()
        {
            if (txtSuperAdmin.Text.Trim() == "")
            {
                MessageBox.Show("请输入超级管理员用户名!", "提示");
                txtSuperAdmin.Focus();
            }
            else if (txtSAPassword.Text.Trim() == "" && txtSAPwdComfirm.Text.Trim() == "")
            {
                MessageBox.Show("用户密码不能为空!", "提示");
                txtSAPassword.Focus();
            }
            else if (txtSAPassword.Text.Trim() != txtSAPwdComfirm.Text.Trim())
            {
                MessageBox.Show("两次密码不一致，请重新输入!", "提示");
                txtSAPassword.Focus();
            }
            else if (txtSuperName.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空!", "提示");
                txtSuperName.Focus();
            }
            else if (cmbSuperSex.Text.Trim() == "")
            {
                MessageBox.Show("性别不能为空!", "提示");
                cmbSuperSex.Focus();
            }
            else if (txtSuperAge.Text.Trim() == "")
            {
                MessageBox.Show("年龄不能为空!", "提示");
            }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }            
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空!", "错误");
                    txtUserName.Focus();
                    return;
                }
                else if (txtUserPassword.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空!", "错误");
                    txtUserPassword.Focus();
                    return;
                }
                this.Text = "正在验证...";
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                string psw = CPublic.GetMd5Str(txtUserPassword.Text.Trim());
                string sqlStr = "select userPassword, userPurview, firstLogin from tbl_User where userName='"
                            + txtUserName.Text.Trim() + "'";
                CDataBase.conn.ConnectionString = CDataBase.connStr;
                CDataBase.conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, CDataBase.conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (!sdr.Read())
                {
                    MessageBox.Show("用户名错误,请重新输入!", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    txtUserName.Text = "";
                    txtUserPassword.Text = "";
                    txtUserName.Focus();
                }
                else if (sdr["userPassword"].ToString().Trim() == psw.Trim())
                {                        
                    CPublic.userInfo[0] = txtUserName.Text.Trim();
                    CPublic.userInfo[1] = psw.Trim();
                    CPublic.userInfo[2] = sdr["userPurview"].ToString().Trim();
                    CPublic.userInfo[3] = sdr["firstLogin"].ToString().Trim();
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    if (CPublic.userInfo[2] == "顾客")
                    {
                        FrmCustomerMain ob_FrmCustomerMain = new FrmCustomerMain();
                        ob_FrmCustomerMain.Show();
                    }
                    else
                    {
                        FrmAdminMain ob_FrmAdminMain = new FrmAdminMain();
                        ob_FrmAdminMain.Show(); 
                    }                     
                    this.Hide();
                    CDataBase.conn.Close();
                    if (CPublic.userInfo[3] == "是")
                    {
                        if(CPublic.userInfo[2]=="普通管理员")
                        {
                            MessageBox.Show("未设置个人信息,请先设置,否则一旦忘记密码,将无法找回!",
                                                         "严重警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            FrmInfoAdmin ob_FrmInformation = new FrmInfoAdmin();
                            ob_FrmInformation.Show();
                        }
                        else if(CPublic.userInfo[2]=="顾客")
                        {
                            MessageBox.Show("未设置个人信息,请先设置,否则一旦忘记密码,将无法找回!",
                                                            "严重警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            FrmInfoCustomer ob_FrmInformation = new FrmInfoCustomer();
                            ob_FrmInformation.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("密码错误,请重新输入!", "错误");
                    this.Cursor = System.Windows.Forms.Cursors.Arrow;
                    this.Text = "登录";
                    txtUserPassword.Text = "";
                    txtUserPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录异常");
                this.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.Text = "登录";
                txtUserName.Text = "";
                txtUserPassword.Text = "";
                txtUserName.Focus();
            }
            finally
            {
                CDataBase.conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    btnSet.Enabled = false;
                    StreamReader sr = new StreamReader(path, Encoding.GetEncoding("GB2312"));
                    CDataBase.connStr = sr.ReadLine();
                    sr.Close();                   
                }
                else
                {
                    MessageBox.Show("初次使用本软件,请先配置数据库", "提示");
                    this.Height = 540;
                    txtUserName.Enabled = false;
                    txtUserPassword.Enabled = false;
                    btnLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.Height == 230)
            {
                this.Height = 540;
                txtUserName.Enabled = false;
                txtUserPassword.Enabled = false;
                btnLogin.Enabled = false;
                btnCstRegister.Enabled = false;
                lblForgetPassword.Enabled = false;
                txtServerWin.Focus();
            }
            else
            {
                this.Height = 230;
                txtUserName.Enabled = true;
                txtUserPassword.Enabled = true;
                btnLogin.Enabled = true;
                btnCstRegister.Enabled = true;
                lblForgetPassword.Enabled = true;
                txtUserName.Focus();
            }
        }

        private void btnOkWin_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAdminInput();
                if (txtServerWin.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库服务器名称!", "提示");
                    txtServerWin.Focus();
                }
                else if (txtDataBaseWin.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库名称!", "提示");
                    txtDataBaseWin.Focus();
                }
                else
                {
                    this.Height = 230;
                    StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("GB2312"));
                    string connStr = "server=" + txtServerWin.Text.Trim() + ";database=" +
                    txtDataBaseWin.Text.Trim() + ";Integrated Security=True";
                    sw.WriteLine(connStr);
                    sw.Close();
                    txtUserName.Enabled = true;
                    txtUserPassword.Enabled = true;
                    btnLogin.Enabled = true;
                    txtUserName.Focus();
                    CDataBase.connStr = connStr;
                    InsertAdminInfo();                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelWin_Click(object sender, EventArgs e)
        {
            this.Height = 230;
            txtUserName.Enabled = true;
            txtUserPassword.Enabled = true;
            btnLogin.Enabled = true;
            txtUserName.Focus();
        }

        private void btnOkSql_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAdminInput();
                if (txtServerSql.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库服务器名称!", "提示");
                    txtServerSql.Focus();
                }
                else if (txtDataBaseSql.Text.Trim() == "")
                {
                    MessageBox.Show("请输入数据库名称!", "提示");
                    txtDataBaseSql.Focus();
                }
                else
                {
                    this.Height = 230;
                    StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("GB2312"));
                    string connStr = "server=" + txtServerSql.Text.Trim() + ";database=" +
                    txtDataBaseSql.Text.Trim() + ";uid=" + txtUserSql.Text.Trim() +
                    ";pwd=" + txtPasswordSql.Text.Trim();
                    sw.WriteLine(connStr);
                    sw.Close();
                    txtUserName.Enabled = true;
                    txtUserPassword.Enabled = true;
                    btnLogin.Enabled = true;
                    txtUserName.Focus();
                    CDataBase.connStr = connStr;
                    InsertAdminInfo();           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelSql_Click(object sender, EventArgs e)
        {
            btnCancelWin_Click(sender, e);
        }

        private void tbcSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcSet.SelectedIndex == 0)
            {
                txtServerWin.Focus();
            }
            else
            {
                txtServerSql.Focus();
            }
        }

        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ob_FrmPassword == null || ob_FrmPassword.IsDisposed)
            {
                ob_FrmPassword = new FrmPassword();
                ob_FrmPassword.Show();
            }
            else
            {
                ob_FrmPassword.Activate();
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="用户名/注册邮箱")
            {
                txtUserName.Text = "";
            }            
        }

        private void btnCstRegister_Click(object sender, EventArgs e)
        {
            if (ob_FrmCstRegister == null || ob_FrmCstRegister.IsDisposed)
            {
                ob_FrmCstRegister = new FrmCstRegister();
                ob_FrmCstRegister.Show();
            }
            else
            {
                ob_FrmCstRegister.Activate();
            }
        }

    }
}
