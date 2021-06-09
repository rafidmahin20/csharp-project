using System;
using System.Data;
using System.Windows.Forms;

namespace FoodMart
{
    public partial class ProductCart : Form
    {
        private string UpdateId = null;

        public ProductCart()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void PopulateGridView()
        {
            string sql = "select * from ProductTable";
            this.dgvProduct.DataSource = DataAccess.GetDataTable(sql);
        }

        private bool IsValidInputs()
        {
            if (txtProductName.Text != "" && txtProductPrice.Text != "" && txtProductQty.Text != "")
            {
                return true;
            }
            return false;
        }

        private void ProductCart_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int AppID()
        {
            var sql = "select top 1 * from ProductTable order by ProID desc;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                int appId = data.Rows[0].Field<int>(0);
                return ++appId;
            }
            return 1;
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                try
                {
                    int Id = AppID();
                    string sql = $"INSERT INTO ProductTable VALUES('{Id}', '{txtProductName.Text}', '{txtProductPrice.Text}', '{txtProductQty.Text}', '{cmbProCat.Text}')";
                    var row = DataAccess.ExecuteDmlQuery(sql);

                    if (row == 1)
                    {
                        MessageBox.Show("Saved SuccessFully");
                        this.PopulateGridView();
                        this.ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductQty.Text = "";
            cmbProCat.SelectedItem = "";
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.UpdateId = this.dgvProduct.CurrentRow.Cells["ProID"].Value.ToString();
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells["ProName"].Value.ToString();
            this.txtProductPrice.Text = this.dgvProduct.CurrentRow.Cells["ProPrice"].Value.ToString();
            this.txtProductQty.Text = this.dgvProduct.CurrentRow.Cells["ProQty"].Value.ToString();
            this.cmbProCat.SelectedItem = this.dgvProduct.CurrentRow.Cells["ProCat"].Value.ToString();
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                try
                {
                    int Id = AppID();
                    string sql = $"update ProductTable set ProName='{txtProductName.Text}', ProPrice='{txtProductPrice.Text}', ProQty='{txtProductQty.Text}', ProCat='{cmbProCat.Text}' where ProID='{UpdateId}'";

                    int row = DataAccess.ExecuteDmlQuery(sql);
                    if (row == 1)
                    {
                        MessageBox.Show("Successfully updated");
                        this.PopulateGridView();
                        this.ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Unknown Error occured");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected");
                return;
            }

            string appId = this.dgvProduct.CurrentRow.Cells["ProID"].Value.ToString();
            string title = this.dgvProduct.CurrentRow.Cells["ProName"].Value.ToString();

            if (MessageBox.Show($"Delete Product {title}?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            string sql = $"delete from ProductTable where ProID='{appId}'";
            var row = DataAccess.ExecuteDmlQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("Deleted successfully");
                this.PopulateGridView();
            }
        }

        private void btnProClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            Employees e1 = new Employees();
            e1.Show();
            this.Hide();
        }
    }
}