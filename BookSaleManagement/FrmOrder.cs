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
    public partial class FrmOrder : Form
    {
        string publicSqlString = "select tbl_Book.title, tbl_OrderForm.orderNumber," +
             " tbl_OrderForm.paidTime, tbl_OrderForm.orderStatus from tbl_OrderForm, tbl_Book  " +
           " where tbl_OrderForm.bookID = tbl_Book.bookID and customerEmail ='" + CPublic.userInfo[0] + "'";
        public FrmOrder()
        {
            InitializeComponent();
        }
        bool RefreshData(string sqlStr)
        {
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvOrder.DataSource = ds.Tables[0];
                dgrdvOrder.Columns[0].HeaderText = "书名";
                dgrdvOrder.Columns[0].Width = 100;
                dgrdvOrder.Columns[1].HeaderText = "数量";
                dgrdvOrder.Columns[1].Width = 60;
                dgrdvOrder.Columns[2].HeaderText = "付款时间";
                dgrdvOrder.Columns[2].Width = 115;
                dgrdvOrder.Columns[3].HeaderText = "订单状态";
                dgrdvOrder.Columns[3].Width = 100;
                return true;
            }
            else
            {
                dgrdvOrder.DataSource = null;
                return false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            try
            {
                dtpEnd.Enabled = false;
                btnAcdTime.Enabled = false;
                btnAcdStatus.Enabled = false;
                cmbStatus.SelectedIndex = -1;
                bool a = RefreshData(publicSqlString);
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpStart_CloseUp(object sender, EventArgs e)
        {
            dtpEnd.Enabled = true;
        }

        private void dtpEnd_CloseUp(object sender, EventArgs e)
        {
            btnAcdTime.Enabled = true;
        }

        private void btnAcdTime_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                string sqlStr = publicSqlString + " and paidTime >= '" + start +
                    "' and paidTime <= '" + end + "'";
                bool a = RefreshData(sqlStr);
                if (!a)
                {
                    MessageBox.Show("没有符合条件的订单记录!", "提示");
                }
                dtpEnd.Enabled = false;
                btnAcdTime.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAcdStatus.Enabled = true;
        }

        private void btnAcdStatus_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                string sqlStr = publicSqlString + " and orderStatus = '" + cmbStatus.Text.Trim() + "'";
                bool a = RefreshData(sqlStr);
                if (!a)
                {
                    MessageBox.Show("没有符合条件的订单记录!", "提示");
                }
                btnAcdStatus.Enabled = false;
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
