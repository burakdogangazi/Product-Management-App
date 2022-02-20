using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        IProductService _productService;
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwProduct.DataSource = _productService.SearchProducts(tbxSearch.Text);
            }

            else
            {
                LoadProducts();
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var unitPriceCheck1 = Convert.ToDecimal(tbxUnitPrice.Text);

            if (unitPriceCheck1 < 0)
            {
                MessageBox.Show("Unit price can not be lower than zero");
            }

            else
            {
                try
                {
                    _productService.Add(new Product
                    {
                        ProductName = tbxProductName.Text,
                        QuantityPerUnit = tbxQuantityPerUnit.Text,
                        UnitsInStock = Convert.ToInt16(tbxUnitsInStock.Text),
                        UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
                    });
                    MessageBox.Show("Product is added.");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var unitPriceCheck2 = Convert.ToDecimal(tbxUnitPriceUpdate.Text);

            if(unitPriceCheck2 < 0)
            {
                MessageBox.Show("Unit price can not be lower than zero");
            }
            else
            {
                try
                {
                    _productService.Update(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        ProductName = tbxProductNameUpdate.Text,
                        UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),
                        QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                        UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)

                    });
                    MessageBox.Show("Product is updated.");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            
            
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[2].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[3].Value.ToString();
            tbxUnitsInStockUpdate.Text = row.Cells[4].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Product is deleted.");
                LoadProducts();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }

            
           
        }
    }
}
