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
    public partial class FrmCustomerMain : Form
    {
        FrmHelp ob_FrmHelp;
        FrmInfoCustomer ob_FrmInfoCustomer;
        FrmBookCity ob_FrmBookCity;
        FrmOrder ob_FrmOrder;
        public FrmCustomerMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr;
                sqlStr = "update tbl_OrderForm set orderStatus = '已出库' where orderStatus = '未出库' ";
                CDataBase.UpdateDB(sqlStr);
                if ((ob_FrmInfoCustomer != null && !ob_FrmInfoCustomer.IsDisposed) ||
                    (ob_FrmBookCity != null && !ob_FrmBookCity.IsDisposed) ||
                    (ob_FrmOrder != null && !ob_FrmOrder.IsDisposed) ||
                    (ob_FrmHelp != null && !ob_FrmHelp.IsDisposed))
                {
                    if (MessageBox.Show("已打开了部分子系统,确实要退出系统吗?", "询问",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }            
        }

        private void FrmCustomerMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "欢迎光临三联书店网上书城!";
            lblUserInfo.Text = "您的用户名：" + CPublic.userInfo[0];
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (ob_FrmHelp == null || ob_FrmHelp.IsDisposed)
            {
                ob_FrmHelp = new FrmHelp();
                ob_FrmHelp.Show();
            }
            else
            {
                ob_FrmHelp.Activate();
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (ob_FrmInfoCustomer == null || ob_FrmInfoCustomer.IsDisposed)
            {
                ob_FrmInfoCustomer = new FrmInfoCustomer();
                ob_FrmInfoCustomer.Show();
            }
            else
            {
                ob_FrmInfoCustomer.Activate();
            }
        }

        private void btnBookSale_Click(object sender, EventArgs e)
        {
            if (ob_FrmBookCity == null || ob_FrmBookCity.IsDisposed)
            {
                ob_FrmBookCity = new FrmBookCity();
                ob_FrmBookCity.Show();
            }
            else
            {
                ob_FrmBookCity.Activate();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (ob_FrmOrder == null || ob_FrmOrder.IsDisposed)
            {
                ob_FrmOrder = new FrmOrder();
                ob_FrmOrder.Show();
            }
            else
            {
                ob_FrmOrder.Activate();
            }
        }

        private void FrmCustomerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
