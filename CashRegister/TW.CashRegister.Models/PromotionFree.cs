using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// m free n 促销
    /// </summary>
    public  class PromotionFree:IPromotion
    {
        /// <summary>
        /// 卖m赠送n中的m
        /// </summary>
        public int BaseNum { get; set; }

        /// <summary>
        ///  卖m赠送n中的n
        /// </summary>
        public int FreeNum { get; set; }

        public string ID
        {
            get
            {
                return string.Format("{0}_Free_{1}", BaseNum, FreeNum);
            }

            
        }

        public string Name
        {
            get
            {
                return string.Format("买{0}赠{1}", BaseNum, FreeNum);
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

        public bool Unique
        {
            get
            {
                return true;
            }

            
        }

        

        public string ProductItemFormat
        {
            get
            {
                return Const.ProductItemNormal;
            }

            
        }

        public bool ShowPromationDesc
        {
            get
            {
               return true;
            }
        }

        public string PromationDescFromat
        {
            get
            {
                return Const.PromationDescFromat;
            }
        }

        public string GetProductItemText(Product product)
        {
            var saveCount = (int)Math.Floor(1.0 * product.Quantity * FreeNum / (FreeNum+ BaseNum));
            var saveCash = saveCount * product.Price;
            var sum = product.Quantity * product.Price- saveCash;
            return string.Format(ProductItemFormat, product.Name, product.Quantity, product.Unit,
                product.Price, sum);
        }

        public string GetPromationDescItemText(Product product)
        {
            var saveCount = (int)Math.Floor(1.0 * product.Quantity * FreeNum / (FreeNum + BaseNum));
            return string.Format(PromationDescFromat, product.Name, saveCount, product.Unit);
        }

        public decimal GetProdcutSum(Product product)
        {
            var saveCount = (int)Math.Floor(1.0 * product.Quantity * FreeNum / (FreeNum + BaseNum));
            var saveCash = saveCount * product.Price;
            var sum = product.Quantity * product.Price - saveCash;

            return sum;
        }

        public decimal GetProdcutSave(Product product)
        {
            var saveCount = (int)Math.Floor(1.0 * product.Quantity * FreeNum / (FreeNum + BaseNum));
            var saveCash = saveCount * product.Price;

            return saveCash;
        }
    }
}
