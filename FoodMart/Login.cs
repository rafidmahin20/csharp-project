using System;
using System.Windows.Forms;

namespace FoodMart
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private bool isValidInputs()
        {
            if (this.txtUserName.Text != "" && this.txtPassword.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.isValidInputs())
            {
                string sql = $"select * from EmployeeTable where EmpName='{txtUserName.Text}' and EmpPass='{txtPassword.Text}'";
                var dt = DataAccess.GetDataTable(sql);
                if (dt.Rows.Count == 1)
                {
                    new Payment().Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Username password doesn't match");
                }
            }
        }

        private void AdminLog_Click(object sender, EventArgs e)
        {
            AdminLog a1 = new AdminLog();
            a1.Show();
            this.Hide();
        }
    }
}