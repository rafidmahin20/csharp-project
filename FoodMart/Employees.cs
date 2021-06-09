using System;
using System.Data;
using System.Windows.Forms;

namespace FoodMart
{
    public partial class Employees : Form
    {
        private string updateId = null;

        public Employees()
        {
            InitializeComponent();
        }

        private bool isValidInputs()
        {
            if (this.txtEmpName.Text != "" && this.txtEmpPhone.Text != "" && this.txtEmpAdd.Text != ""
                && this.txtEmpPass.Text != "")
            {
                return true;
            }
            return false;
        }

        private int AppID()
        {
            var sql = "SELECT TOP 1 * FROM EmployeeTable ORDER BY EID DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                int appId = data.Rows[0].Field<int>(0);
                return ++appId;
            }
            return 1;
        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            if (this.isValidInputs())
            {
                try
                {
                    int ID = this.AppID();
                    var sql = $"insert into EmployeeTable values('{ID}','{txtEmpName.Text}','{txtEmpPhone.Text}','{txtEmpAdd.Text}','{txtEmpPass.Text}')";
                    var row = DataAccess.ExecuteDmlQuery(sql);

                    if (row == 1)
                    {
                        MessageBox.Show("Save SuccessFully");
                        this.PopulateGridView();
                        this.ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Missing Information");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void txtEmpPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateGridView()
        {
            string sql = "select * from EmployeeTable";
            this.dgvEmp.DataSource = DataAccess.GetDataTable(sql);
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvEmp_DoubleClick(object sender, EventArgs e)
        {
            this.updateId = this.dgvEmp.CurrentRow.Cells["EID"].Value.ToString();
            this.txtEmpName.Text = this.dgvEmp.CurrentRow.Cells["EmpName"].Value.ToString();
            this.txtEmpPhone.Text = this.dgvEmp.CurrentRow.Cells["EmpPhone"].Value.ToString();
            this.txtEmpAdd.Text = this.dgvEmp.CurrentRow.Cells["EmpAdd"].Value.ToString();
            this.txtEmpPass.Text = this.dgvEmp.CurrentRow.Cells["EmpPass"].Value.ToString();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            if (this.isValidInputs())
            {
                try
                {
                    string sql = $"update EmployeeTable set EmpName='{txtEmpName.Text}', EmpPhone='{txtEmpPhone.Text}', EmpAdd='{txtEmpAdd.Text}', EmpPass='{txtEmpPass.Text}' where EID='{updateId}'";
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            this.txtEmpName.Text = "";
            this.txtEmpPhone.Text = "";
            this.txtEmpAdd.Text = "";
            this.txtEmpPass.Text = "";
            this.updateId = null;
        }

        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvEmp.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected");
                return;
            }

            string appId = this.dgvEmp.CurrentRow.Cells["EID"].Value.ToString();
            string title = this.dgvEmp.CurrentRow.Cells["EmpName"].Value.ToString();

            if (MessageBox.Show($"Delete employee {title}?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            string sql = $"delete from EmployeeTable where EID='{appId}'";
            var row = DataAccess.ExecuteDmlQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("Deleted successfully");
                this.PopulateGridView();
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            ProductCart p1 = new ProductCart();
            p1.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }
    }
}