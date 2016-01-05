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
    public partial class FrmUser : Form
    {
        FrmCompleteAdminInfo ob_FrmCompleteAdminInfo;
        FrmCompleteCustomerInfo ob_FrmCompleteCustomerInfo;
        string dgrdvAdminSelectSql = "adminUserName, adminName, jobID, adminSex, adminAge, startDate, salaryPerMonth";
        void ClearAll()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            cmbPurview.SelectedIndex = -1;
        }
        void ObjOpen()
        {
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            cmbPurview.Enabled = true;
            txtUserName.Focus();
        }
        void ObjClose()
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            cmbPurview.Enabled = false;
        }
        void SetDgrdvAdmin(DataSet ds)
        {
            dgrdvUser.DataSource = ds.Tables[0];
            dgrdvUser.Columns[0].HeaderText = "用户名";
            dgrdvUser.Columns[0].Width = 106;
            dgrdvUser.Columns[1].HeaderText = "姓名";
            dgrdvUser.Columns[1].Width = 100;
            dgrdvUser.Columns[2].HeaderText = "工号";
            dgrdvUser.Columns[2].Width = 80;
            dgrdvUser.Columns[3].HeaderText = "性别";
            dgrdvUser.Columns[3].Width = 80;
            dgrdvUser.Columns[4].HeaderText = "年龄";
            dgrdvUser.Columns[4].Width = 80;
            dgrdvUser.Columns[5].HeaderText = "入职日期";
            dgrdvUser.Columns[5].Width = 106;
            dgrdvUser.Columns[6].HeaderText = "月薪";
            dgrdvUser.Columns[6].Width = 100;
        }
        void SetDgrdvCustomer(DataSet ds)
        {
            dgrdvUser.DataSource = ds.Tables[0];
            dgrdvUser.Columns[0].HeaderText = "用户名";
            dgrdvUser.Columns[0].Width = 102;
            dgrdvUser.Columns[1].HeaderText = "姓名";
            dgrdvUser.Columns[1].Width = 100;
            dgrdvUser.Columns[2].HeaderText = "电话";
            dgrdvUser.Columns[2].Width = 100;
            dgrdvUser.Columns[3].HeaderText = "地址";
            dgrdvUser.Columns[3].Width = 250;
            dgrdvUser.Columns[4].HeaderText = "账户余额";
            dgrdvUser.Columns[4].Width = 100;
        }
        public void RefreshData()
        {
            string sqlStr = "";
            DataSet ds = new DataSet();
            if (cmbUserType.Text.Trim() == "普通管理员")
            {
                sqlStr = "select " + dgrdvAdminSelectSql + 
                    " from tbl_Admin where adminType= '普通管理员'";
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    SetDgrdvAdmin(ds);
                }
                else
                {
                    dgrdvUser.DataSource = null;
                }
            }
            else
            {
                sqlStr = "select * from tbl_Customer";
                ds = CDataBase.GetDataFromDB(sqlStr);
                if (ds != null)
                {
                    SetDgrdvCustomer(ds);
                }
                else
                {
                    dgrdvUser.DataSource = null;
                }
            }
        }
        bool UserNameExist(string userName)
        {
            string sqlStr = "select userName from tbl_User where userName='" + txtUserName.Text.Trim() + "'";
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
        void SetcmbSelect(string userType)
        {
            if(userType == "普通管理员")
            {
                string[] selectCondition= {"用户名","姓名","工号","性别","年龄","入职日期","月薪"};
                cmbSelect.Items.Clear();
                cmbSelect.Items.AddRange(selectCondition);
            }
            else
            {
                string[] selectCondition = { "用户名", "姓名", "电话", "地址", "账户余额"};
                cmbSelect.Items.Clear();
                cmbSelect.Items.AddRange(selectCondition);
            }
        }
        void Setcmb(string info)
        {
            if (info == "超级管理员")
            {
                cmbUserType.Items.Clear();
                cmbUserType.Items.Add("普通管理员");
                cmbUserType.Items.Add("顾客");
                cmbPurview.Items.Clear();
                cmbPurview.Items.Add("普通管理员");
                cmbPurview.Items.Add("顾客");
            }
            else
            {
                cmbUserType.Items.Clear();
                cmbUserType.Items.Add("顾客");
                cmbPurview.Items.Clear();
                cmbPurview.Items.Add("顾客");
            }
            SetcmbSelect(cmbUserType.Text.Trim());
            cmbUserType.SelectedIndex = 0;
        }

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            try
            {
                lblUser.Text = "当前用户： " + CPublic.userInfo[0] + "    权限：" + CPublic.userInfo[2];
                Setcmb(CPublic.userInfo[2]);
                RefreshData();
                ObjClose();
                btnSelect.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = false;
                btnRegedit.Text = "注册";
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRegedit.Text == "注册")
                {
                    btnRegedit.Text = "确定";
                    btnCancel.Enabled = true;
                    ObjOpen();
                }
                else if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("用户名不能为空", "提示");
                    txtUserName.Focus();
                }
                else if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空", "提示");
                    txtPassword.Focus();
                }
                else if (!UserNameExist(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("该用户已存在!", "提示");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    ObjOpen();
                    btnRegedit.Text = "注册";
                    txtUserName.Focus();
                }
                else
                {
                    btnRegedit.Text = "注册";
                    string psw = CPublic.GetMd5Str(txtPassword.Text.Trim());
                    string sqlStr = "insert into tbl_User values('" + txtUserName.Text.Trim() + "','" +
                    psw.Trim() + "','" + cmbPurview.Text.Trim() + "','是')";
                    string regType = cmbPurview.Text.Trim();
                    if (CDataBase.UpdateDB(sqlStr))
                        MessageBox.Show(cmbPurview.Text + " " + txtUserName.Text + " 注册成功!\n" +
                    "请进一步完善用户信息", "注册用户");
                    CPublic.userName = txtUserName.Text.Trim();
                    if (regType == "普通管理员")
                    {                        
                        if (ob_FrmCompleteAdminInfo == null || ob_FrmCompleteAdminInfo.IsDisposed)
                        {
                            ob_FrmCompleteAdminInfo = new FrmCompleteAdminInfo();
                            ob_FrmCompleteAdminInfo.Show();
                        }
                        else
                        {
                            ob_FrmCompleteAdminInfo.Activate();
                        }       
                    }
                    else if(regType == "顾客")
                    {                        
                        if (ob_FrmCompleteCustomerInfo == null || ob_FrmCompleteCustomerInfo.IsDisposed)
                        {
                            ob_FrmCompleteCustomerInfo = new FrmCompleteCustomerInfo();
                            ob_FrmCompleteCustomerInfo.Show();
                        }
                        else
                        {
                            ob_FrmCompleteCustomerInfo.Activate();
                        } 
                    }
                    ClearAll();
                    ObjClose();
                    btnCancel.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
                ObjClose();
                btnCancel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            ObjClose();
            btnRegedit.Text = "注册";
            btnCancel.Enabled = false;
            cmbPurview.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                if (dgrdvUser.DataSource == null)
                {
                    MessageBox.Show("没有可以删除的用户", "提示");
                }
                else
                {
                    int n = this.dgrdvUser.CurrentCell.RowIndex;
                    userName = this.dgrdvUser.Rows[n].Cells[0].Value.ToString().Trim();
                    if (MessageBox.Show("确定要删除用户“" + userName + "”吗?", "删除用户",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string sqlStr = "delete from tbl_User where userName='" + userName + "'";
                        CDataBase.UpdateDB(sqlStr);
                        dgrdvUser.Rows.RemoveAt(n);
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
        private void dgrdvUser_MouseClick(object sender, MouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                bool fuzzyQuery;
                DataSet ds = new DataSet();
                if (cmbUserType.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择用户类型!", "提示");
                    return;
                }
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
                if (cmbUserType.Text.Trim() == "普通管理员")
                {
                    if (cmbSelect.SelectedIndex == 0)
                        sqlStr = "select " +dgrdvAdminSelectSql+" from tbl_Admin where adminUserName " 
                            +op +" '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                    else if (cmbSelect.SelectedIndex == 1)
                        sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where adminName " 
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                    else if (cmbSelect.SelectedIndex == 2)
                        sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where jobID " 
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                    else if (cmbSelect.SelectedIndex == 3)
                        sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where adminSex " 
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                    else if (cmbSelect.SelectedIndex == 4)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if(d <0)
                        {
                            sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where adminAge "
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where adminAge >=" + Convert.ToInt32(s1) +
                            " and adminAge <=" + Convert.ToInt32(s2) + " and adminType <> '超级管理员'";
                        }                        
                    }                        
                    else if (cmbSelect.SelectedIndex == 5)
                        sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where startDate " 
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                    else if (cmbSelect.SelectedIndex == 6)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if(d<0)
                        {
                            sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where salaryPerMonth "
                            + op + " '" + txtSelect.Text.Trim() + "' and adminType <> '超级管理员'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select " + dgrdvAdminSelectSql + " from tbl_Admin where salaryPerMonth >=" + Convert.ToInt32(s1) +
                            " and salaryPerMonth <=" + Convert.ToInt32(s2) + " and adminType <> '超级管理员'";
                        }                        
                    }                    
                    ds = CDataBase.GetDataFromDB(sqlStr);
                    if (ds != null)
                    {
                        SetDgrdvAdmin(ds);
                        btnDelete.Enabled = true;
                      }
                    else
                    {
                        dgrdvUser.DataSource = null;
                        ClearAll();
                        MessageBox.Show("没有符合条件的管理员记录!", "提示");
                        txtSelect.Text = "";
                    }    
                }
                else
                {
                    if (cmbSelect.SelectedIndex == 0)
                        sqlStr = "select * from tbl_Customer where customerEmail " + op + " '" + txtSelect.Text.Trim() + "'";
                    else if (cmbSelect.SelectedIndex == 1)
                        sqlStr = "select * from tbl_Customer where customerName " + op + " '" + txtSelect.Text.Trim() + "'";
                    else if (cmbSelect.SelectedIndex == 2)
                        sqlStr = "select * from tbl_Customer where customerPhone " + op + " '" + txtSelect.Text.Trim() + "'";
                    else if (cmbSelect.SelectedIndex == 3)
                        sqlStr = "select * from tbl_Customer where customerAddress " + op + " '" + txtSelect.Text.Trim() + "'";
                    else if (cmbSelect.SelectedIndex == 4)
                    {
                        int d = txtSelect.Text.IndexOf(',');                        
                        if(d<0)
                        {
                            sqlStr = "select * from tbl_Customer where balance " + op + " '" + txtSelect.Text.Trim() + "'";
                        }
                        else
                        {
                            string s1 = txtSelect.Text.Substring(0, d);
                            string s2 = txtSelect.Text.Substring(d + 1, txtSelect.Text.Length - d - 1);
                            sqlStr = "select * from tbl_Customer where balance >=" + Convert.ToDouble(s1) +
                            " and balance <=" + Convert.ToDouble(s2);
                        }                        
                    }
                    ds = CDataBase.GetDataFromDB(sqlStr);
                    if (ds != null)
                    {
                        SetDgrdvCustomer(ds);
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        dgrdvUser.DataSource = null;
                        ClearAll();
                        MessageBox.Show("没有符合条件的顾客记录!", "提示");
                        txtSelect.Text = "";
                    }
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
            btnSelect.Enabled = true;
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUserType.Text.Trim() == "普通管理员")
            {
                if(cmbSelect.SelectedIndex == 4 || cmbSelect.SelectedIndex == 6)
                {
                    txtSelect.Text = "支持范围查询, 如输入\"0,10\"可得到 >=0, <= 10的结果";
                }
                else if(cmbSelect.SelectedIndex == 5)
                {
                    txtSelect.Text = "支持形如\"yyyy-mm-dd\"的精确查询和形如\"yyyy%\"的模糊查询";
                }
                else
                {
                    txtSelect.Text = "支持包含'%'的通配符查询,如'%明'可查询到'小明'";
                }
            }
            else
            {
                if(cmbSelect.SelectedIndex == 4)
                {
                    txtSelect.Text = "支持范围查询, 如输入\"0,10\"可得到 >=0, <= 10的结果";
                }
                else
                {
                    txtSelect.Text = "支持包含'%'的通配符查询,如'%明'可查询到'小明'";
                }
            }
        }

        private void txtSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetcmbSelect(cmbUserType.Text.Trim());
        }

        private void FrmUser_Activated(object sender, EventArgs e)
        {
            FrmUser_Load(sender, e);
        }

    }
}
