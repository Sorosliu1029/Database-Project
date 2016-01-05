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
    public partial class FrmWarehouse : Form
    {
        public FrmWarehouse()
        {
            InitializeComponent();
        }
        void ObjClose()
        {            
            txtWarehouseID.Enabled = false;
            txtCity.Enabled = false;
            txtPhone.Enabled = false;
            txtRent.Enabled = false;
        }
        void ObjOpen()
        {
            txtWarehouseID.Enabled = true;
            txtCity.Enabled = true;
            txtPhone.Enabled = true;
            txtRent.Enabled = true;
        }
        void ClearAll()
        {
            txtWarehouseID.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtRent.Text = "";
        }
        bool RefreshData(string sqlStr)
        {
            DataSet ds = new DataSet();
            ds = CDataBase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dgrdvWarehouse.DataSource = ds.Tables[0];
                dgrdvWarehouse.Columns[0].HeaderText = "仓库编号";
                dgrdvWarehouse.Columns[0].Width = 82;
                dgrdvWarehouse.Columns[1].HeaderText = "所在城市";
                dgrdvWarehouse.Columns[1].Width = 80;
                dgrdvWarehouse.Columns[2].HeaderText = "联系电话";
                dgrdvWarehouse.Columns[2].Width = 100;
                dgrdvWarehouse.Columns[3].HeaderText = "每月租金";
                dgrdvWarehouse.Columns[3].Width = 80;
                return true;
            }
            else
            {
                dgrdvWarehouse.DataSource = null;
                return false;
            }
        }
        bool No(string no)
        {
            int n = dgrdvWarehouse.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                if (no == dgrdvWarehouse.Rows[i].Cells[0].Value.ToString().Trim())
                    return false;
            }
            return true;
        }
        private void FrmWarehouse_Load(object sender, EventArgs e)
        {
            try
            {
                txtSelect.Enabled = false;
                btnSelect.Enabled = false;
                btnDelete.Enabled = false;
                ObjClose();
                RefreshData("select * from tbl_Warehouse");
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelect.Enabled = true;
            btnSelect.Enabled = true;
            txtSelect.Text = "";
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshData("select * from tbl_Warehouse");
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
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
                if (cmbSelect.SelectedIndex == 0)
                    sqlStr = "select * from tbl_Warehouse where warehouseID ='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 1)
                    sqlStr = "select * from tbl_Warehouse where warehouseCity ='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 2)
                    sqlStr = "select * from tbl_Warehouse where warehousePhone ='" + txtSelect.Text.Trim() + "'";
                else if (cmbSelect.SelectedIndex == 3)
                    sqlStr = "select * from tbl_Warehouse where rentCostPerMonth ='" + txtSelect.Text.Trim() + "'";
                bool a = RefreshData(sqlStr);
                if (a == false)
                {
                    MessageBox.Show("没有符合条件的仓库!", "提示");
                    txtSelect.Text = "";
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "添加")
                {
                    btnAdd.Text = "确定";
                    btnDelete.Enabled = false;
                    ObjOpen();
                }
                else if (txtWarehouseID.Text.Trim() == "")
                {
                    MessageBox.Show("仓库编号不能为空!", "提示");
                    txtWarehouseID.Focus();
                    return;
                }
                else if (txtCity.Text.Trim() == "")
                {
                    MessageBox.Show("所在城市不能为空!", "提示");
                    txtCity.Focus();
                    return;
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("联系电话不能为空!", "提示");
                    txtPhone.Focus();
                    return;
                }
                else if (txtRent.Text.Trim() == "")
                {
                    MessageBox.Show("每月租金不能为空!", "提示");
                    txtRent.Focus();
                    return;
                }
                else if (!No(txtWarehouseID.Text.Trim()))
                {
                    MessageBox.Show("该仓库已存在!", "提示");
                    ClearAll();
                    return;
                }
                else
                {
                    btnAdd.Text = "添加";
                    string sqlStr = "insert into tbl_Warehouse values('" + txtWarehouseID.Text.Trim() + "','" +
                        txtCity.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + txtRent.Text.Trim() + "')";
                    CDataBase.UpdateDB(sqlStr);
                    RefreshData("select * from tbl_Warehouse");
                    ClearAll();
                    ObjClose();
                }
            }
            catch (Exception ex)
            {
                CDataBase.conn.Close();
                MessageBox.Show(ex.Message);
                ClearAll();
                ObjClose();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dgrdvWarehouse.CurrentCell.RowIndex;
                string warehouseID = dgrdvWarehouse[0, n].Value.ToString().Trim();
                string sqlStr1 = "select * from tbl_ImportList where warehouseID='" + warehouseID + "'";
                string sqlStr2 = "select * from tbl_Stocks where warehouseID='" + warehouseID + "'";
                if (CDataBase.GetDataFromDB(sqlStr1) != null)
                {
                    MessageBox.Show("进货清单中存在该仓库,不能删除该仓库!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CDataBase.GetDataFromDB(sqlStr2) != null)
                {
                    MessageBox.Show("该仓库中仍有书籍库存,不能删除该仓库!", "删除出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("确定要删除仓库“" + warehouseID + "”吗?", "删除仓库",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string sqlStr = "delete from tbl_Warehouse where warehouseID='" + warehouseID + "'";
                    CDataBase.UpdateDB(sqlStr);
                    int m = dgrdvWarehouse.CurrentCell.RowIndex;
                    dgrdvWarehouse.Rows.RemoveAt(m);
                    if (dgrdvWarehouse.Rows.Count == 1)
                    {
                        ClearAll();
                        dgrdvWarehouse.DataSource = null;
                    }
                    else
                    {
                        dgrdvWarehouse_RowHeaderMouseClick(null, null);
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

        private void txtSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void dgrdvWarehouse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

    }
}
