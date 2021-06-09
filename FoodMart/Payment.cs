using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace FoodMart
{
    public partial class Payment : Form
    {
        List<MyCart> CartLists = new List<MyCart>();
        double Total = 0;
        public Payment()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void PopulateGridView()
        {
            string sql = "select * from ProductTable";
            this.dgvProlist.DataSource = DataAccess.GetDataTable(sql);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidInputs()
        {
            if (this.txtCustomerName.Text != "" && this.txtPrice.Text != "" && this.txtProName.Text != "" && this.txtQty.Text != "")
            {
                return true;
            }
            return false;
        }

        private void ClearInputs()
        {
            this.txtProName.Text = "";
            this.txtPrice.Text = "";
            this.txtQty.Text = "";
            this.txtCustomerName.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearInputs();
        }
        private void AddToCart()
        {
            MyCart cartToAdd = new MyCart();
            cartToAdd.Product = txtProName.Text;
            cartToAdd.Price = txtPrice.Text;
            cartToAdd.Quantity = txtQty.Text;
            cartToAdd.Customer = txtCustomerName.Text;

            Total += Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPrice.Text);
            lblTotal.Text = $"Total: {Total}";

            this.CartLists.Add(cartToAdd);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValidInputs())
            {
                this.AddToCart();
                var list = new BindingList<MyCart>(CartLists);
                this.dgvPaymentChart.DataSource = list;
            }
        }

        private void dgvProlist_DoubleClick(object sender, EventArgs e)
        {
            this.txtProName.Text = this.dgvProlist.CurrentRow.Cells["ProName"].Value.ToString();
            this.txtPrice.Text = this.dgvProlist.CurrentRow.Cells["ProPrice"].Value.ToString();
            this.txtQty.Text = this.dgvProlist.CurrentRow.Cells["ProQty"].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            foreach (MyCart m in CartLists)
            {
                double price = Convert.ToDouble(m.Price) * Convert.ToDouble(m.Quantity);
                MessageBox.Show($"Product: {m.Product}, Quantity: {m.Quantity}, Price: {m.Price} = Total: {price}");
            }
            MessageBox.Show($"Grand Total: {this.Total}");
        }

        private void dgvPaymentChart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

		private void dgvProlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}