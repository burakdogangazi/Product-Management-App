
namespace Northwind.WebFormsUI
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Northwind.WebFormsUI.Properties.Resources.stockmarketimage;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1327, 760);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1058, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgwProduct
            // 
            this.dgwProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgwProduct.ColumnHeadersHeight = 29;
            this.dgwProduct.Location = new System.Drawing.Point(23, 74);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 90;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1240, 256);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Fuchsia;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(40, 27);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(121, 24);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(262, 30);
            this.tbxSearch.TabIndex = 4;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitsInStock);
            this.gbxAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxProductName);
            this.gbxAdd.Controls.Add(this.panel6);
            this.gbxAdd.Controls.Add(this.panel4);
            this.gbxAdd.Controls.Add(this.panel3);
            this.gbxAdd.Controls.Add(this.panel2);
            this.gbxAdd.Controls.Add(this.panel1);
            this.gbxAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxAdd.Controls.Add(this.lblUnitsInStock);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.lblProductName);
            this.gbxAdd.Location = new System.Drawing.Point(23, 390);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(617, 330);
            this.gbxAdd.TabIndex = 5;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a new product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(410, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(141, 161);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(263, 22);
            this.tbxUnitsInStock.TabIndex = 12;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(141, 216);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(263, 22);
            this.tbxQuantityPerUnit.TabIndex = 11;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(141, 104);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(263, 22);
            this.tbxUnitPrice.TabIndex = 10;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(141, 57);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(263, 22);
            this.tbxProductName.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(22, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(574, 1);
            this.panel6.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(22, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(22, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 1);
            this.panel1.TabIndex = 4;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(19, 224);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(116, 17);
            this.lblQuantityPerUnit.TabIndex = 3;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(19, 169);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(98, 17);
            this.lblUnitsInStock.TabIndex = 2;
            this.lblUnitsInStock.Text = "Units In Stock:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(19, 112);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(73, 17);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 62);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.panel5);
            this.gbxUpdate.Controls.Add(this.panel7);
            this.gbxUpdate.Controls.Add(this.panel8);
            this.gbxUpdate.Controls.Add(this.panel9);
            this.gbxUpdate.Controls.Add(this.panel10);
            this.gbxUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(646, 390);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(617, 330);
            this.gbxUpdate.TabIndex = 6;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(410, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 39);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(141, 161);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(263, 22);
            this.tbxUnitsInStockUpdate.TabIndex = 12;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(141, 216);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(263, 22);
            this.tbxQuantityPerUnitUpdate.TabIndex = 11;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(141, 104);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(263, 22);
            this.tbxUnitPriceUpdate.TabIndex = 10;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(141, 57);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(263, 22);
            this.tbxProductNameUpdate.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(22, 244);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 1);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(22, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(574, 1);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(22, 189);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(574, 1);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(22, 132);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(574, 1);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(6, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(591, 1);
            this.panel10.TabIndex = 4;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(19, 224);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(116, 17);
            this.lblQuantityPerUnitUpdate.TabIndex = 3;
            this.lblQuantityPerUnitUpdate.Text = "Quantity Per Unit";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(19, 169);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(98, 17);
            this.lblUnitsInStockUpdate.TabIndex = 2;
            this.lblUnitsInStockUpdate.Text = "Units In Stock:";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(19, 112);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(73, 17);
            this.lblUnitPriceUpdate.TabIndex = 1;
            this.lblUnitPriceUpdate.Text = "Unit Price:";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(19, 62);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(102, 17);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Product Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1137, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 732);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}