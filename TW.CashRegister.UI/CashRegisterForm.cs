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
using TW.CashRegister.Service;

namespace TW.CashRegister.UI
{
    public partial class CashRegisterForm : Form
    {
        private static readonly Service.Cache  _cache = new Service.Cache();
        private static readonly Service.Service _service = new Service.Service();

        public CashRegisterForm()
        {
            InitializeComponent();

            //BindGrid();

            BindSettingControls();
        }

        private void BindSettingControls()
        {
            ddlPromotions.DataSource = Service.Cache.PromotionsById.Select(pair => new ComboboxItem { Text = pair.Value.Name, Value = pair.Key }).ToList();

            this.lbProducts.DataSource=  Service.Cache.ProductsById.Select(pair => new ComboboxItem { Text = pair.Value.Name, Value = pair.Key }).ToList();

            List<PromotionSetting> settings;
            this.txtContent.Text = _service.RetrivePromotionSettings(out settings);
            if (settings != null && settings.Count > 0)
                _cache.UpdateProducts(settings);
        }

        //private void BindGrid()
        //{
        //    // Get Data of product and promation to form a table
        //    // TODO async method

        //    dataGridView1.Enabled = true;
        //    dataGridView1.ReadOnly = false;
        //    var dt = Service.Service.GenTableForSetPromation();
        //    var productNameCol = new DataGridViewTextBoxColumn();
        //    productNameCol.DataPropertyName = "ProductName";
        //    productNameCol.HeaderText = "商品名称";
        //    productNameCol.ReadOnly = false;
        //    this.dataGridView1.Columns.Add(productNameCol);

        //    for (int i = 1; i < dt.Columns.Count; i++)
        //    {
        //        var gridCol = new DataGridViewCheckBoxColumn();
        //        gridCol.DataPropertyName = dt.Columns[i].ColumnName;
        //        gridCol.HeaderText = dt.Columns[i].ColumnName;
        //        gridCol.ReadOnly = false;

        //        this.dataGridView1.Columns.Add(gridCol);
        //    }


        //    dataGridView1.DataSource = dt;
        //    dataGridView1.Update();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Order order = new Order();



            var products = GetInputProducts(this.txtInput.Text);
        

            order.Products = products;

            this.txtOutput.Text = order.GetPrintTemp();
        }

       
        /// <summary>
        /// 根据条形码列表获得订单内容（商品以及对应的数量）
        /// TODO: move to service layer.
        /// </summary>
        /// <param name="text">商品条形码列表</param>
        /// <returns></returns>
        public Dictionary<Product, int> GetInputProducts(string text)
        {
            var result = new Dictionary<Product, int>();
            //var cleanCode = text.TrimStart('[').TrimEnd(']').Trim();

            var codes = JsonHelper.DeserializeJsonToList<string>(text);
            var allProducts = Service.Cache.ProductsById;

            Product product;

            if (codes != null && codes.Count > 0)
            {
                var groubByCode = codes.ToLookup(c => c);


                foreach (var group in groubByCode)
                {
                    var code = group.Key;
                    var barCodeAndCount = code.Split('-');
                    var barCode = barCodeAndCount[0];

                    int count = 1;
                    count = barCodeAndCount.Length > 1 && int.TryParse(barCodeAndCount[1], out count) ? count : 1;

                    int mun = group.Count();
                    if (mun > count)
                    {
                        count = mun;
                    }
                    if (allProducts.TryGetValue(barCode, out product))
                    {                       

                        result[product] = count;

                    }
                }
            }
            return result; 
        }

        private void txtPromationSetting_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeeting_Click(object sender, EventArgs e)
        {
            var promotionId = (this.ddlPromotions.SelectedItem as ComboboxItem).Value.ToString();
            var productIds = lbProducts.SelectedItems.Cast<ComboboxItem>().Select(c => c.Value.ToString()).ToList();

            if (!string.IsNullOrWhiteSpace(promotionId) && productIds != null && productIds.Count > 0)
            {
                _cache.UpdateProductsByOnePromotion(promotionId, productIds);
                this.txtContent.Text = _cache.UpdateJson();
            }
        }
    }
}
