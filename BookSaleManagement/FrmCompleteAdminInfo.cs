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
    public partial class FrmCompleteAdminInfo : Form
    {
        string startDateString;
        public FrmCompleteAdminInfo()
        {
            InitializeComponent();
        }
        void ClearAll()
        {
            txtName.Text = "";
            txtJobID.Text = "";
            cmbSex.Text = "男";
            txtAge.Text = "";
            txtSalaryPerMonth.Text = "";
            txtName.Focus();
        }
        void ObjOpen()
        {
            txtUserName.Enabled = true;
            txtName.Enabled = true;
            txtJobID.Enabled = true;
            cmbSex.Enabled = true;
            txtAge.Enabled = true;
            txtSalaryPerMonth.Enabled = true;
            dtpStartDate.Enabled = true;
            txtName.Focus();
        }
        void ObjClose()
        {
            txtUserName.Enabled = false;
            txtName.Enabled = false;
            txtJobID.Enabled = false;
            cmbSex.Enabled = false;
            txtAge.Enabled = false;
            txtSalaryPerMonth.Enabled = false;
            dtpStartDate.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                startDateString = dtpStartDate.Value.ToString("yyyy-MM-dd");
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("姓名不能为空", "提示");
                    txtName.Focus();
                }
                else if (txtJobID.Text.Trim() == "")
                {
                    MessageBox.Show("工号不能为空", "提示");
                    txtJobID.Focus();
                }
                else if (txtAge.Text.Trim() == "")
                {
                    MessageBox.Show("年龄不能为空", "提示");
                    txtAge.Focus();
                }                
                else if (int.Parse(txtAge.Text.Trim()) <= 0)
                {
                   MessageBox.Show("年龄必须大于零","提示");
                }
                else if (txtSalaryPerMonth.Text.Trim() == "")
                {
                    MessageBox.Show("月薪不能为空", "提示");
                    txtSalaryPerMonth.Focus();
                }
                else
                {
                    string sqlStr = "insert into tbl_Admin values('" + txtUserName.Text.Trim() + "','" +
                    txtName.Text.Trim() + "','" +  txtJobID.Text.Trim()+ "','" + cmbSex.Text.Trim() + "','" +  
                    txtAge.Text.Trim() + "','" + "普通管理员" +"','" + startDateString +"','" +
                    txtSalaryPerMonth.Text.Trim() + "')";
                    if (CDataBase.UpdateDB(sqlStr))
                    {
                        MessageBox.Show("普通管理员：" + txtUserName.Text + " 信息完善成功!", "完善用户信息");                        
                    }
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

        private void FrmCompleteAdminInfo_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = CPublic.userName;
                cmbSex.SelectedIndex = 0;
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
