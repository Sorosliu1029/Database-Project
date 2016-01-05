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
    public partial class FrmDataBase : Form
    {
        string backupPath = "";
        string restorePath = "";
        public FrmDataBase()
        {
            InitializeComponent();
        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {

        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            sdlgBackup.FilterIndex = 0;
            sdlgBackup.FileName = "";
            sdlgBackup.Filter = "Bak Files (*.bak)|*.bak|All Files (*.*)|*.*";
            if (sdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sdlgBackup.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (backupPath == "")
                {
                    MessageBox.Show("请先选择数据库备份路径", "提示");
                    return;
                }
                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                string sqlStr;
                sqlStr = "backup database DBBookSaleManagement to disk='" + backupPath + " '";
                SqlCommand sqlCom = new SqlCommand(sqlStr, CDataBase.conn);
                CDataBase.conn.Open();
                sqlCom.ExecuteNonQuery();
                CDataBase.conn.Close();
                if (MessageBox.Show("数据库备份成功", "提示",
                MessageBoxButtons.OK) == DialogResult.OK)
                {
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

        private void btnRestorePath_Click(object sender, EventArgs e)
        {
            odlgRestore.FilterIndex = 0;
            odlgRestore.FileName = "";
            odlgRestore.Filter = "Bak Files (*.bak)|*.bak|All Files (*.*)|*.*";
            if (odlgRestore.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = odlgRestore.FileName.ToString();
                txtRestore.ReadOnly = true;
            }
            restorePath = txtRestore.Text.Trim();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (restorePath == "")
                {
                    MessageBox.Show("请先选择数据库恢复路径", "提示");
                    return;
                }
                // 以下代码用于关闭正在使用DBBookSaleManagement数据库的进程
                string conStr = "Data Source=.;Database=master;Integrated Security=True";
                CDataBase.conn.ConnectionString = conStr;
                CDataBase.conn.Open();
                string sqlStr = "select spid from master..sysprocesses where dbid=db_id( 'DBBookSaleManagemen') ";
                SqlDataAdapter sda = new SqlDataAdapter(sqlStr, CDataBase.conn);
                DataTable spidTable = new DataTable();
                sda.Fill(spidTable);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = CDataBase.conn;
                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    // 强行关闭用户进程
                    cmd1.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();
                    cmd1.ExecuteNonQuery();
                }
                CDataBase.conn.Close();
                CDataBase.conn.Dispose();
                string restoreStr = "use master restore database DBBookSaleManagement from disk='" + restorePath + " '" + "with replace";
                CDataBase.conn.ConnectionString = CDataBase.connStr;
                CDataBase.conn.Open();
                SqlCommand cmd2 = new SqlCommand(restoreStr, CDataBase.conn);
                cmd2.ExecuteNonQuery();
                CDataBase.conn.Close();
                if (MessageBox.Show("数据库恢复成功", "提示", MessageBoxButtons.OK) ==
                DialogResult.OK)
                {
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
