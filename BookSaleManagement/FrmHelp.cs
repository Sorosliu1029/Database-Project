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
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void llblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:13307130167@fudan.edu.cn");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (btnHelp.Text == "查看系统帮助信息")
            {
                btnHelp.Text = "隐藏系统帮助信息";
                this.Height = 340;
            }
            else
            {
                btnHelp.Text = "查看系统帮助信息";
                this.Height = 140;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
