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
    public partial class FrmFinance : Form
    {
        string publicSqlString1 = "select * from tbl_Finance";
        public FrmFinance()
        {
            InitializeComponent();
        }
        bool RefreshFinanceData(string sqlStr)
        {
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvFinance.DataSource = ds.Tables[0];
                dgrdvFinance.Columns[0].HeaderText = "账单编号";
                dgrdvFinance.Columns[0].Width = 137;
                dgrdvFinance.Columns[1].HeaderText = "金额";
                dgrdvFinance.Columns[1].Width = 70;
                dgrdvFinance.Columns[2].HeaderText = "类型";
                dgrdvFinance.Columns[2].Width = 60;
                dgrdvFinance.Columns[3].HeaderText = "创建者";
                dgrdvFinance.Columns[3].Width = 112;
                dgrdvFinance.Columns[4].HeaderText = "创建时间";
                dgrdvFinance.Columns[4].Width = 120;
                return true;
            }
            else
            {
                dgrdvFinance.DataSource = null;
                return false;
            }
        }
        private void FrmFinance_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshFinanceData(publicSqlString1);
                btnSelect.Enabled = false;
                btnAll.Enabled = false;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = true;
            btnAll.Enabled = true;
        }

        private void dtpStart_CloseUp(object sender, EventArgs e)
        {
            dtpEnd.Enabled = true;
        }

        private void dtpEnd_CloseUp(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                string sqlStr = "select * from tbl_Finance where createdTime >= '" + start +
                    "' and createdTime <= '" + end;
                if(cmbType.SelectedIndex==0 || cmbType.SelectedIndex == 1)
                {
                    sqlStr += "' and financeType = '" + cmbType.Text + "'";
                }
                else if(cmbType.SelectedIndex==2)
                {
                    sqlStr += "' and financeType ='进账' and financeType='出账' ";
                }                
                bool a = RefreshFinanceData(sqlStr);
                if(!a)
                {
                    MessageBox.Show("没有符合条件的财务记录!", "提示");
                }
                cmbType.SelectedIndex = -1;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                btnSelect.Enabled = false;
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
                string sqlStr = publicSqlString1;
                if (cmbType.SelectedIndex == 0 || cmbType.SelectedIndex == 1)
                {
                    sqlStr += " where financeType = '" + cmbType.Text + "'";
                }
                bool a =RefreshFinanceData(sqlStr);
                if(!a)
                {
                    MessageBox.Show("没有符合条件的财务记录!", "提示");
                }
                cmbType.SelectedIndex = -1;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                btnSelect.Enabled = false;
                btnAll.Enabled = false;
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
    }
}
