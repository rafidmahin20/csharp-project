using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMart
{
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string pass = txtPassword1.Text;
            string querry = "select * from Admin where AdminPass = '" + pass + "'";
            var dt = DataAccess.GetDataTable(querry);
            if (dt.Rows.Count > 0)
            {
                lblError.Visible = false;
                Employees e1 = new Employees();
                e1.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
