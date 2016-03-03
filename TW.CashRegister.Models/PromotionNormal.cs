using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 正常销售
    /// </summary>
    public class PromotionNormal:IPromotion
    {
         
        public string Type { get; set; }

        string id = "Normal";
        public string ID
        { get { return id; } set { id = value; } }

        string name = "正常(无促销)";
        public string Name
        { get { return name; } set { name = value; } }

        public int Priority
        { get; set; }


        bool showPromationDesc = false;
        public bool ShowPromationDesc
        { get { return showPromationDesc; } set { showPromationDesc = value; } }

        public string PromationDescFromat
        { get; set; }

        bool unique = false;
        public bool Unique
        { get { return unique; } set { unique = value; } }



        public string GetProductItemText(Product product, int Quantity)
        {
            var sum = GetProdcutSum(product, Quantity);

            return string.Format(Const.ProductItemNormal, product.Name, Quantity, product.Unit,
                product.Price, sum);
        }

        public string GetPromationDescHeaderText()
        {
            return string.Empty;
        }

        public string GetPromationDescItemText(Product product)
        {
            return string.Empty;
        }

        public decimal GetProdcutSum(Product product, int Quantity)
        {

            var sum = Quantity * product.Price ;

            return sum;
        }

        public decimal GetProdcutSave(Product product, int Quantity)
        {

            return decimal.Zero;
        }

        public string GetPromationDescItemText(Product product, int Quantity)
        {
            return string.Empty;
        }
    }
}
