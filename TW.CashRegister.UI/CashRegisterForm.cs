using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TW.CashRegister.Common;
using TW.CashRegister.Models;

namespace TW.CashRegister.UI
{
    public partial class CashRegisterForm : Form
    {
        public CashRegisterForm()
        {
            InitializeComponent();

            BindGrid();

        }

        private void BindGrid()
        {
            // Get Data of product and promation to form a table
            // TODO async method

            var dt = Service.Service.GenTableForSetPromation();
            var productNameCol = new DataGridViewTextBoxColumn();
            productNameCol.DataPropertyName = "ProductName";
            productNameCol.HeaderText = "商品名称";

            this.dataGridView1.Columns.Add(productNameCol);

            for (int i = 1; i < dt.Columns.Count; i++)
            {
                var gridCol = new DataGridViewCheckBoxColumn();
                gridCol.DataPropertyName = dt.Columns[i].ColumnName;
                gridCol.HeaderText = dt.Columns[i].ColumnName;

                this.dataGridView1.Columns.Add(gridCol);
            }


            dataGridView1.DataSource = dt;
            dataGridView1.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            Dictionary<Product, int> products = GetInputProducts(this.txtInput.Text);
            order.Products = products;

            this.txtOutput.Text = order.GetPrintTemp();
        }

        public Dictionary<Product, int> GetInputProducts(string text)
        {
            Dictionary<Product, int> result = new Dictionary<Product, int>();
            //var cleanCode = text.TrimStart('[').TrimEnd(']').Trim();

            var codes = JsonHelper.JsonToList<string>(text);
            var allProducts = Service.Service.GetAllProduct().ToDictionary(p=>p.BarCode,p=>p);

            Product product;
            foreach (var code in codes)
            {
                var barCodeAndCount = code.Split('-');
                var barCode = barCodeAndCount[0];
                int count = 1;
                count = barCodeAndCount.Length > 1 && int.TryParse(barCodeAndCount[1], out count) ? count : 1;
                if (allProducts.TryGetValue(code, out product))
                {
                    result.Add(product, count);
                }
            }

            return result; 
        }
    }
}
