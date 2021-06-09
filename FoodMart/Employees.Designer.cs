
namespace FoodMart
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.lblEmpPass = new System.Windows.Forms.Label();
            this.lblEmpAdd = new System.Windows.Forms.Label();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.dgvEmp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEmpClear = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnEmpSave = new System.Windows.Forms.Button();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGoTo);
            this.panel1.Controls.Add(this.btnEmpUpdate);
            this.panel1.Controls.Add(this.txtEmpPass);
            this.panel1.Controls.Add(this.lblEmpPass);
            this.panel1.Controls.Add(this.lblEmpAdd);
            this.panel1.Controls.Add(this.txtEmpAdd);
            this.panel1.Controls.Add(this.txtEmpPhone);
            this.panel1.Controls.Add(this.lblEmpPhone);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.lblEmpName);
            this.panel1.Controls.Add(this.dgvEmp);
            this.panel1.Controls.Add(this.btnEmpClear);
            this.panel1.Controls.Add(this.btnEmpDelete);
            this.panel1.Controls.Add(this.btnEmpSave);
            this.panel1.Controls.Add(this.pbEmployee);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmpUpdate.FlatAppearance.BorderSize = 0;
            this.btnEmpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpUpdate.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmpUpdate.Location = new System.Drawing.Point(304, 217);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(143, 36);
            this.btnEmpUpdate.TabIndex = 32;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // txtEmpPass
            // 
            this.txtEmpPass.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPass.Location = new System.Drawing.Point(745, 161);
            this.txtEmpPass.Name = "txtEmpPass";
            this.txtEmpPass.Size = new System.Drawing.Size(194, 30);
            this.txtEmpPass.TabIndex = 31;
            this.txtEmpPass.TextChanged += new System.EventHandler(this.txtEmpPass_TextChanged);
            // 
            // lblEmpPass
            // 
            this.lblEmpPass.AutoSize = true;
            this.lblEmpPass.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPass.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmpPass.Location = new System.Drawing.Point(740, 133);
            this.lblEmpPass.Name = "lblEmpPass";
            this.lblEmpPass.Size = new System.Drawing.Size(114, 25);
            this.lblEmpPass.TabIndex = 30;
            this.lblEmpPass.Text = "Password";
            // 
            // lblEmpAdd
            // 
            this.lblEmpAdd.AutoSize = true;
            this.lblEmpAdd.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmpAdd.Location = new System.Drawing.Point(512, 133);
            this.lblEmpAdd.Name = "lblEmpAdd";
            this.lblEmpAdd.Size = new System.Drawing.Size(98, 25);
            this.lblEmpAdd.TabIndex = 27;
            this.lblEmpAdd.Text = "Address";
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAdd.Location = new System.Drawing.Point(517, 161);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(194, 30);
            this.txtEmpAdd.TabIndex = 26;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.Location = new System.Drawing.Point(287, 161);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(194, 30);
            this.txtEmpPhone.TabIndex = 25;
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPhone.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmpPhone.Location = new System.Drawing.Point(282, 133);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(79, 25);
            this.lblEmpPhone.TabIndex = 24;
            this.lblEmpPhone.Text = "Phone";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(55, 161);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(194, 30);
            this.txtEmpName.TabIndex = 23;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmpName.Location = new System.Drawing.Point(50, 133);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(75, 25);
            this.lblEmpName.TabIndex = 22;
            this.lblEmpName.Text = "Name";
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvEmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmp.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmp.EnableHeadersVisualStyles = false;
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmp.Location = new System.Drawing.Point(55, 270);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowHeadersVisible = false;
            this.dgvEmp.RowHeadersWidth = 62;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(884, 267);
            this.dgvEmp.TabIndex = 21;
            this.dgvEmp.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmp.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dgvEmp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmp.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvEmp.ThemeStyle.ReadOnly = true;
            this.dgvEmp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvEmp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmp.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEmp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmp.DoubleClick += new System.EventHandler(this.dgvEmp_DoubleClick);
            // 
            // btnEmpClear
            // 
            this.btnEmpClear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmpClear.FlatAppearance.BorderSize = 0;
            this.btnEmpClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpClear.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmpClear.Location = new System.Drawing.Point(687, 217);
            this.btnEmpClear.Name = "btnEmpClear";
            this.btnEmpClear.Size = new System.Drawing.Size(143, 36);
            this.btnEmpClear.TabIndex = 20;
            this.btnEmpClear.Text = "Clear";
            this.btnEmpClear.UseVisualStyleBackColor = false;
            this.btnEmpClear.Click += new System.EventHandler(this.btnEmpClear_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmpDelete.FlatAppearance.BorderSize = 0;
            this.btnEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDelete.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmpDelete.Location = new System.Drawing.Point(496, 217);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(143, 36);
            this.btnEmpDelete.TabIndex = 19;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = false;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnEmpSave
            // 
            this.btnEmpSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmpSave.FlatAppearance.BorderSize = 0;
            this.btnEmpSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpSave.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmpSave.Location = new System.Drawing.Point(122, 217);
            this.btnEmpSave.Name = "btnEmpSave";
            this.btnEmpSave.Size = new System.Drawing.Size(143, 36);
            this.btnEmpSave.TabIndex = 17;
            this.btnEmpSave.Text = "Save";
            this.btnEmpSave.UseVisualStyleBackColor = false;
            this.btnEmpSave.Click += new System.EventHandler(this.btnEmpSave_Click);
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployee.Image")));
            this.pbEmployee.Location = new System.Drawing.Point(398, 28);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(62, 50);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployee.TabIndex = 6;
            this.pbEmployee.TabStop = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.Color.DarkGreen;
            this.lblEmployee.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.Yellow;
            this.lblEmployee.Location = new System.Drawing.Point(476, 45);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(163, 33);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "FOOD MART";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(962, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.Blue;
            this.btnGoTo.FlatAppearance.BorderSize = 0;
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.ForeColor = System.Drawing.Color.Yellow;
            this.btnGoTo.Location = new System.Drawing.Point(759, 3);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(228, 36);
            this.btnGoTo.TabIndex = 35;
            this.btnGoTo.Text = "Go To Product Cart";
            this.btnGoTo.UseVisualStyleBackColor = false;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(809, 26);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(156, 32);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back to Login";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1017, 642);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Button btnEmpClear;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnEmpSave;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmp;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.Label lblEmpPass;
        private System.Windows.Forms.Label lblEmpAdd;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnback;
    }
}