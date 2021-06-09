
namespace FoodMart
{
    partial class Payment
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblProlist = new System.Windows.Forms.Label();
			this.dgvProlist = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lblPaymentChart = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtProName = new System.Windows.Forms.TextBox();
			this.lblProName = new System.Windows.Forms.Label();
			this.dgvPaymentChart = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnAddToCart = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblFoodMart = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnback = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProlist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPaymentChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnReset);
			this.panel1.Controls.Add(this.lblTotal);
			this.panel1.Controls.Add(this.lblProlist);
			this.panel1.Controls.Add(this.dgvProlist);
			this.panel1.Controls.Add(this.lblPaymentChart);
			this.panel1.Controls.Add(this.txtCustomerName);
			this.panel1.Controls.Add(this.lblCustomerName);
			this.panel1.Controls.Add(this.lblPrice);
			this.panel1.Controls.Add(this.txtPrice);
			this.panel1.Controls.Add(this.txtQty);
			this.panel1.Controls.Add(this.lblQty);
			this.panel1.Controls.Add(this.txtProName);
			this.panel1.Controls.Add(this.lblProName);
			this.panel1.Controls.Add(this.dgvPaymentChart);
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Controls.Add(this.btnAddToCart);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(17, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1030, 615);
			this.panel1.TabIndex = 1;
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.DarkGreen;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.Yellow;
			this.btnReset.Location = new System.Drawing.Point(307, 254);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(93, 36);
			this.btnReset.TabIndex = 34;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblTotal.Location = new System.Drawing.Point(731, 453);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(69, 25);
			this.lblTotal.TabIndex = 33;
			this.lblTotal.Text = "Total";
			// 
			// lblProlist
			// 
			this.lblProlist.AutoSize = true;
			this.lblProlist.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProlist.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblProlist.Location = new System.Drawing.Point(164, 314);
			this.lblProlist.Name = "lblProlist";
			this.lblProlist.Size = new System.Drawing.Size(156, 25);
			this.lblProlist.TabIndex = 32;
			this.lblProlist.Text = "Products List";
			// 
			// dgvProlist
			// 
			this.dgvProlist.AllowUserToAddRows = false;
			this.dgvProlist.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvProlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProlist.BackgroundColor = System.Drawing.Color.Gray;
			this.dgvProlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvProlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProlist.ColumnHeadersHeight = 4;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProlist.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProlist.EnableHeadersVisualStyles = false;
			this.dgvProlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvProlist.Location = new System.Drawing.Point(15, 344);
			this.dgvProlist.Name = "dgvProlist";
			this.dgvProlist.ReadOnly = true;
			this.dgvProlist.RowHeadersVisible = false;
			this.dgvProlist.RowHeadersWidth = 62;
			this.dgvProlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProlist.Size = new System.Drawing.Size(453, 237);
			this.dgvProlist.TabIndex = 31;
			this.dgvProlist.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.dgvProlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvProlist.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvProlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvProlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvProlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvProlist.ThemeStyle.BackColor = System.Drawing.Color.Gray;
			this.dgvProlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvProlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvProlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvProlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvProlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvProlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvProlist.ThemeStyle.HeaderStyle.Height = 4;
			this.dgvProlist.ThemeStyle.ReadOnly = true;
			this.dgvProlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvProlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvProlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvProlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvProlist.ThemeStyle.RowsStyle.Height = 22;
			this.dgvProlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvProlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvProlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProlist_CellContentClick);
			this.dgvProlist.DoubleClick += new System.EventHandler(this.dgvProlist_DoubleClick);
			// 
			// lblPaymentChart
			// 
			this.lblPaymentChart.AutoSize = true;
			this.lblPaymentChart.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPaymentChart.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblPaymentChart.Location = new System.Drawing.Point(689, 88);
			this.lblPaymentChart.Name = "lblPaymentChart";
			this.lblPaymentChart.Size = new System.Drawing.Size(183, 25);
			this.lblPaymentChart.TabIndex = 30;
			this.lblPaymentChart.Text = "Payment Chart ";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerName.Location = new System.Drawing.Point(274, 208);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(194, 30);
			this.txtCustomerName.TabIndex = 29;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblCustomerName.Location = new System.Drawing.Point(269, 180);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(186, 25);
			this.lblCustomerName.TabIndex = 28;
			this.lblCustomerName.Text = "Customer Name";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblPrice.Location = new System.Drawing.Point(23, 180);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(67, 25);
			this.lblPrice.TabIndex = 27;
			this.lblPrice.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(28, 208);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(194, 30);
			this.txtPrice.TabIndex = 26;
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(274, 129);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(194, 30);
			this.txtQty.TabIndex = 25;
			// 
			// lblQty
			// 
			this.lblQty.AutoSize = true;
			this.lblQty.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQty.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblQty.Location = new System.Drawing.Point(269, 101);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(108, 25);
			this.lblQty.TabIndex = 24;
			this.lblQty.Text = "Quantity";
			// 
			// txtProName
			// 
			this.txtProName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProName.Location = new System.Drawing.Point(25, 129);
			this.txtProName.Name = "txtProName";
			this.txtProName.Size = new System.Drawing.Size(194, 30);
			this.txtProName.TabIndex = 23;
			// 
			// lblProName
			// 
			this.lblProName.AutoSize = true;
			this.lblProName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProName.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblProName.Location = new System.Drawing.Point(20, 101);
			this.lblProName.Name = "lblProName";
			this.lblProName.Size = new System.Drawing.Size(176, 25);
			this.lblProName.TabIndex = 22;
			this.lblProName.Text = "Products Name";
			this.lblProName.Click += new System.EventHandler(this.label3_Click);
			// 
			// dgvPaymentChart
			// 
			this.dgvPaymentChart.AllowUserToAddRows = false;
			this.dgvPaymentChart.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgvPaymentChart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPaymentChart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPaymentChart.BackgroundColor = System.Drawing.Color.Gray;
			this.dgvPaymentChart.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPaymentChart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPaymentChart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPaymentChart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvPaymentChart.ColumnHeadersHeight = 25;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPaymentChart.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvPaymentChart.EnableHeadersVisualStyles = false;
			this.dgvPaymentChart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPaymentChart.Location = new System.Drawing.Point(567, 129);
			this.dgvPaymentChart.Name = "dgvPaymentChart";
			this.dgvPaymentChart.ReadOnly = true;
			this.dgvPaymentChart.RowHeadersVisible = false;
			this.dgvPaymentChart.RowHeadersWidth = 62;
			this.dgvPaymentChart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPaymentChart.Size = new System.Drawing.Size(430, 250);
			this.dgvPaymentChart.TabIndex = 21;
			this.dgvPaymentChart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.dgvPaymentChart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPaymentChart.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPaymentChart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPaymentChart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPaymentChart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPaymentChart.ThemeStyle.BackColor = System.Drawing.Color.Gray;
			this.dgvPaymentChart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPaymentChart.ThemeStyle.HeaderStyle.Height = 25;
			this.dgvPaymentChart.ThemeStyle.ReadOnly = true;
			this.dgvPaymentChart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPaymentChart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPaymentChart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvPaymentChart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPaymentChart.ThemeStyle.RowsStyle.Height = 22;
			this.dgvPaymentChart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPaymentChart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPaymentChart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentChart_CellContentClick);
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.DarkGreen;
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.ForeColor = System.Drawing.Color.Yellow;
			this.btnPrint.Location = new System.Drawing.Point(725, 509);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(93, 36);
			this.btnPrint.TabIndex = 18;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnAddToCart
			// 
			this.btnAddToCart.BackColor = System.Drawing.Color.DarkGreen;
			this.btnAddToCart.FlatAppearance.BorderSize = 0;
			this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddToCart.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddToCart.ForeColor = System.Drawing.Color.Yellow;
			this.btnAddToCart.Location = new System.Drawing.Point(38, 254);
			this.btnAddToCart.Name = "btnAddToCart";
			this.btnAddToCart.Size = new System.Drawing.Size(170, 36);
			this.btnAddToCart.TabIndex = 17;
			this.btnAddToCart.Text = "Add to Chart";
			this.btnAddToCart.UseVisualStyleBackColor = false;
			this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(368, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(62, 52);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DarkGreen;
			this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(448, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 33);
			this.label2.TabIndex = 5;
			this.label2.Text = "Payment";
			// 
			// lblFoodMart
			// 
			this.lblFoodMart.AutoSize = true;
			this.lblFoodMart.BackColor = System.Drawing.Color.Gold;
			this.lblFoodMart.Font = new System.Drawing.Font("Goudy Stout", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFoodMart.ForeColor = System.Drawing.Color.DarkGreen;
			this.lblFoodMart.Location = new System.Drawing.Point(305, 3);
			this.lblFoodMart.Name = "lblFoodMart";
			this.lblFoodMart.Size = new System.Drawing.Size(414, 48);
			this.lblFoodMart.TabIndex = 6;
			this.lblFoodMart.Text = "FOOD MART";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Red;
			this.btnClose.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(1010, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(37, 31);
			this.btnClose.TabIndex = 18;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnback
			// 
			this.btnback.BackColor = System.Drawing.Color.Red;
			this.btnback.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnback.ForeColor = System.Drawing.Color.White;
			this.btnback.Location = new System.Drawing.Point(849, 12);
			this.btnback.Name = "btnback";
			this.btnback.Size = new System.Drawing.Size(155, 32);
			this.btnback.TabIndex = 23;
			this.btnback.Text = "Back to Login";
			this.btnback.UseVisualStyleBackColor = false;
			this.btnback.Click += new System.EventHandler(this.btnback_Click);
			// 
			// Payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.ClientSize = new System.Drawing.Size(1072, 681);
			this.Controls.Add(this.btnback);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblFoodMart);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Payment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.Payment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProlist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPaymentChart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPaymentChart;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lblProName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPaymentChart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFoodMart;
        private System.Windows.Forms.Label lblProlist;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProlist;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnback;
    }
}