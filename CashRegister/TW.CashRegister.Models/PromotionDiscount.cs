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
    public class PromotionDiscount:IPromotion
    {
 

        public decimal Discount { get; set; }

        public string ID
        {
            get
            {
                return "PROMTION001";
            }
            

            
        }

        public string Name
        {
            get
            {
                return string.Format("{0}折扣", Discount * 100);
            }

            
        }

        public int Priority
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string ProductItemFormat
        {
            get
            {
                return Const.ProductItemDiscount;
            }
        }

        public bool ShowPromationDesc
        {
            get
            {
                return false;
            }
        }

        public string PromationDescFromat
        {
            get
            {
                return string.Empty;
            }
        }

        public bool Unique
        {
            get
            {
                return false;
            }
           
        }

        public Product Product
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string GetProductItemText(Product product)
        {
            var sum = GetProdcutSum(product);
            var save = GetProdcutSave(product);

            return string.Format(ProductItemFormat, product.Name, product.Quantity, product.Unit,
                product.Price, sum, save);
        }

        public string GetPromationDescItemText(Product product)
        {
            return string.Empty;
        }

        public decimal GetProdcutSum(Product product)
        {
            
            var sum = product.Quantity * product.Price * Discount;

            return sum;
        }

        public decimal GetProdcutSave(Product product)
        {
    
            var saveCash = product.Quantity * product.Price *(1- Discount);

            return saveCash;
        }
    }
}
