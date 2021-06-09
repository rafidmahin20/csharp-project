
namespace FoodMart
{
    partial class ProductCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCart));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProUpdate = new System.Windows.Forms.Button();
            this.lblProductCat = new System.Windows.Forms.Label();
            this.cmbProCat = new System.Windows.Forms.ComboBox();
            this.txtProductQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductQty = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnProClear = new System.Windows.Forms.Button();
            this.btnProDelete = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lblProductCart = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "FOOD MART";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnProUpdate);
            this.panel1.Controls.Add(this.lblProductCat);
            this.panel1.Controls.Add(this.cmbProCat);
            this.panel1.Controls.Add(this.txtProductQty);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.lblProductPrice);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.lblProductQty);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Controls.Add(this.btnProClear);
            this.panel1.Controls.Add(this.btnProDelete);
            this.panel1.Controls.Add(this.btnProductSave);
            this.panel1.Controls.Add(this.pbProduct);
            this.panel1.Controls.Add(this.lblProductCart);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 612);
            this.panel1.TabIndex = 7;
            // 
            // btnProUpdate
            // 
            this.btnProUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProUpdate.FlatAppearance.BorderSize = 0;
            this.btnProUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProUpdate.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnProUpdate.Location = new System.Drawing.Point(344, 225);
            this.btnProUpdate.Name = "btnProUpdate";
            this.btnProUpdate.Size = new System.Drawing.Size(143, 36);
            this.btnProUpdate.TabIndex = 37;
            this.btnProUpdate.Text = "Update";
            this.btnProUpdate.UseVisualStyleBackColor = false;
            this.btnProUpdate.Click += new System.EventHandler(this.btnProUpdate_Click);
            // 
            // lblProductCat
            // 
            this.lblProductCat.AutoSize = true;
            this.lblProductCat.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCat.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductCat.Location = new System.Drawing.Point(849, 130);
            this.lblProductCat.Name = "lblProductCat";
            this.lblProductCat.Size = new System.Drawing.Size(127, 25);
            this.lblProductCat.TabIndex = 36;
            this.lblProductCat.Text = "Categories";
            // 
            // cmbProCat
            // 
            this.cmbProCat.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProCat.FormattingEnabled = true;
            this.cmbProCat.Items.AddRange(new object[] {
            "FISH ",
            "FRUIT",
            "VEGETABLE",
            "MEAT",
            "SOFT DRINKS"});
            this.cmbProCat.Location = new System.Drawing.Point(854, 159);
            this.cmbProCat.Name = "cmbProCat";
            this.cmbProCat.Size = new System.Drawing.Size(166, 31);
            this.cmbProCat.TabIndex = 35;
            this.cmbProCat.Text = "Select Category";
            // 
            // txtProductQty
            // 
            this.txtProductQty.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQty.Location = new System.Drawing.Point(344, 158);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(194, 30);
            this.txtProductQty.TabIndex = 34;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(77, 158);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(194, 30);
            this.txtProductName.TabIndex = 33;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductPrice.Location = new System.Drawing.Point(587, 130);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(67, 25);
            this.lblProductPrice.TabIndex = 28;
            this.lblProductPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(592, 159);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(194, 30);
            this.txtProductPrice.TabIndex = 27;
            // 
            // lblProductQty
            // 
            this.lblProductQty.AutoSize = true;
            this.lblProductQty.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQty.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductQty.Location = new System.Drawing.Point(339, 130);
            this.lblProductQty.Name = "lblProductQty";
            this.lblProductQty.Size = new System.Drawing.Size(108, 25);
            this.lblProductQty.TabIndex = 25;
            this.lblProductQty.Text = "Quantity";
            this.lblProductQty.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProductName.Location = new System.Drawing.Point(72, 130);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(165, 25);
            this.lblProductName.TabIndex = 23;
            this.lblProductName.Text = "Product Name";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(77, 280);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(926, 271);
            this.dgvProduct.TabIndex = 21;
            this.dgvProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvProduct.ThemeStyle.ReadOnly = true;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // btnProClear
            // 
            this.btnProClear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProClear.FlatAppearance.BorderSize = 0;
            this.btnProClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProClear.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnProClear.Location = new System.Drawing.Point(781, 225);
            this.btnProClear.Name = "btnProClear";
            this.btnProClear.Size = new System.Drawing.Size(143, 36);
            this.btnProClear.TabIndex = 20;
            this.btnProClear.Text = "Clear";
            this.btnProClear.UseVisualStyleBackColor = false;
            this.btnProClear.Click += new System.EventHandler(this.btnProClear_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProDelete.FlatAppearance.BorderSize = 0;
            this.btnProDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProDelete.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnProDelete.Location = new System.Drawing.Point(564, 225);
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(143, 36);
            this.btnProDelete.TabIndex = 19;
            this.btnProDelete.Text = "Delete";
            this.btnProDelete.UseVisualStyleBackColor = false;
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnProductSave.FlatAppearance.BorderSize = 0;
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnProductSave.Location = new System.Drawing.Point(128, 225);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(143, 36);
            this.btnProductSave.TabIndex = 17;
            this.btnProductSave.Text = "Save";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pbProduct.Image")));
            this.pbProduct.Location = new System.Drawing.Point(401, 45);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(62, 50);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 6;
            this.pbProduct.TabStop = false;
            // 
            // lblProductCart
            // 
            this.lblProductCart.AutoSize = true;
            this.lblProductCart.BackColor = System.Drawing.Color.DarkGreen;
            this.lblProductCart.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCart.ForeColor = System.Drawing.Color.Yellow;
            this.lblProductCart.Location = new System.Drawing.Point(469, 62);
            this.lblProductCart.Name = "lblProductCart";
            this.lblProductCart.Size = new System.Drawing.Size(216, 33);
            this.lblProductCart.TabIndex = 5;
            this.lblProductCart.Text = "Products Cart ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1046, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.Red;
            this.btnPre.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.ForeColor = System.Drawing.Color.White;
            this.btnPre.Location = new System.Drawing.Point(989, 9);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(54, 31);
            this.btnPre.TabIndex = 23;
            this.btnPre.Text = "<---";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Red;
            this.btnback.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(833, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(155, 32);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Back to Login";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1095, 686);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductItems";
            this.Load += new System.EventHandler(this.ProductCart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private System.Windows.Forms.Button btnProClear;
        private System.Windows.Forms.Button btnProDelete;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblProductCart;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductQty;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductQty;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProUpdate;
        private System.Windows.Forms.Label lblProductCat;
        private System.Windows.Forms.ComboBox cmbProCat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnback;
    }
}