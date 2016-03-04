using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 折扣类的促销活动
    /// </summary>
    public class PromotionDiscount : IPromotion
    {

        public PromotionDiscount(decimal discount)
        {
            this.Discount = discount;
        }

        public string Type { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Discount { get; set; }

        public string ID
        { get; set; }

        public string Name
        { get; set; }

        public int Priority
        { get; set; }
   

        public bool ShowPromationDesc
        { get; set; }

        public string PromationDescFromat
        { get; set; }

        public bool Unique
        { get; set; }

       

        public string GetProductItemText(Product product, int Quantity)
        {
            var sum = GetProdcutSum(product, Quantity);
            var save = GetProdcutSave(product, Quantity);

            return string.Format(Const.ProductItemDiscount, product.Name, Quantity.ToString(), product.Unit,
                product.Price.ToString("#0.00"), sum.ToString("#0.00"), save.ToString("#0.00"));
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
            
            var sum = Quantity * product.Price * Discount;

            return sum;
        }

        public decimal GetProdcutSave(Product product, int Quantity)
        {
    
            var saveCash = Quantity * product.Price *(1- Discount);

            return saveCash;
        }

        public string GetPromationDescItemText(Product product, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
