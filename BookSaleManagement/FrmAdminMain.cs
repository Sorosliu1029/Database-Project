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
    public partial class FrmAdminMain : Form
    {
        FrmUser ob_FrmUser;
        FrmInfoAdmin ob_FrmInfoAdmin;
        FrmDataBase ob_FrmDataBase;
        FrmHelp ob_FrmHelp;
        FrmBook ob_FrmBook;
        FrmStock ob_FrmStock;
        FrmFinance ob_FrmFinance;
        public FrmAdminMain()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (ob_FrmUser == null || ob_FrmUser.IsDisposed)
            {
                ob_FrmUser = new FrmUser();
                ob_FrmUser.Show();
            }
            else
            {
                ob_FrmUser.Activate();
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (ob_FrmInfoAdmin == null || ob_FrmInfoAdmin.IsDisposed)
            {
                ob_FrmInfoAdmin = new FrmInfoAdmin();
                ob_FrmInfoAdmin.Show();
            }
            else
            {
                ob_FrmInfoAdmin.Activate();
            }
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            if (ob_FrmDataBase == null || ob_FrmDataBase.IsDisposed)
            {
                ob_FrmDataBase = new FrmDataBase();
                ob_FrmDataBase.Show();
            }
            else
            {
                ob_FrmDataBase.Activate();
            }
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (ob_FrmBook == null || ob_FrmBook.IsDisposed)
            {
                ob_FrmBook = new FrmBook();
                ob_FrmBook.Show();
            }
            else
            {
                ob_FrmBook.Activate();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (ob_FrmStock == null || ob_FrmStock.IsDisposed)
            {
                ob_FrmStock = new FrmStock();
                ob_FrmStock.Show();
            }
            else
            {
                ob_FrmStock.Activate();
            }
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            if (ob_FrmFinance == null || ob_FrmFinance.IsDisposed)
            {
                ob_FrmFinance = new FrmFinance();
                ob_FrmFinance.Show();
            }
            else
            {
                ob_FrmFinance.Activate();
            }
        }

        private void FrmAdminMain_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = "您的用户名：" + CPublic.userInfo[0] + " —— 您的权限：" + CPublic.userInfo[2].Trim();
            if (CPublic.userInfo[2].Trim() == "普通管理员")
            {
                btnDataBase.Enabled = false;
            }
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            if (ob_FrmUser != null && !ob_FrmUser.IsDisposed)
            {
                MessageBox.Show("请先关闭书城用户管理子系统再试!", "重试");
                ob_FrmUser.Activate();
            }
            else if (ob_FrmInfoAdmin != null && !ob_FrmInfoAdmin.IsDisposed)
            {
                MessageBox.Show("请先关闭个人信息管理子系统再试!", "重试");
                ob_FrmInfoAdmin.Activate();
            }
            else if (ob_FrmDataBase != null && !ob_FrmDataBase.IsDisposed)
            {
                MessageBox.Show("请先关闭备份与恢复数据库子系统再试!", "重试");
                ob_FrmDataBase.Activate();
            }
            else if (ob_FrmHelp != null && !ob_FrmHelp.IsDisposed)
            {
                MessageBox.Show("请先关闭系统使用帮助子系统再试!", "重试");
                ob_FrmHelp.Activate();
            }
            else if (ob_FrmBook != null && !ob_FrmBook.IsDisposed)
            {
                MessageBox.Show("请先关闭书籍信息管理子系统再试!", "重试");
                ob_FrmBook.Activate();
            }
            else if (ob_FrmStock != null && !ob_FrmStock.IsDisposed)
            {
                MessageBox.Show("请先关闭库存信息管理子系统再试!", "重试");
                ob_FrmStock.Activate();
            }
            else if (ob_FrmFinance != null && !ob_FrmFinance.IsDisposed)
            {
                MessageBox.Show("请先关闭财务信息子系统再试!", "重试");
                ob_FrmFinance.Activate();
            }
            else
            {
                FrmLogin ob_FrmLogin = new FrmLogin();
                ob_FrmLogin.Show();
                CDataBase.conn.Close();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string sqlStr;
            sqlStr = "update tbl_OrderForm set orderStatus = '已送达' where orderStatus = '已出库' ";
            CDataBase.UpdateDB(sqlStr);
            if ((ob_FrmBook != null && !ob_FrmBook.IsDisposed) ||
                    (ob_FrmFinance != null && !ob_FrmFinance.IsDisposed) ||
                    (ob_FrmStock != null && !ob_FrmStock.IsDisposed) ||
                    (ob_FrmInfoAdmin != null && !ob_FrmInfoAdmin.IsDisposed) ||
                    (ob_FrmUser != null && !ob_FrmUser.IsDisposed) ||
                    (ob_FrmDataBase != null && !ob_FrmDataBase.IsDisposed) ||
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

        private void FrmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
