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

        public string PromationDescHeadFormat
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string PromationDescItemFormat
        {
            get
            {
                return string.Empty;
            }
        }

        public string GetProductItemText(Product product, int Quantity)
        {
            var sum = GetProdcutSum(product, Quantity);
            var save = GetProdcutSave(product, Quantity);

            return string.Format(ProductItemFormat, product.Name, Quantity, product.Unit,
                product.Price, sum, save);
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
