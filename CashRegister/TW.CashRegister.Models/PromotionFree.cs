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

        

        //public string ProductItemFormat
        //{
        //    get
        //    {
        //        return Const.ProductItemNormal;
        //    }

            
        //}

        public bool ShowPromationDesc
        {
            get
            {
               return true;
            }
        }

        //public string PromationDescHeadFormat
        //{
        //    get
        //    {
        //        return Const.PromationDescHeadFormat;
        //    }
        //}

        //public string PromationDescItemFormat
        //{
        //    get
        //    {
        //        return Const.PromationDescItemFormat;
        //    }
        //}

        public string GetProductItemText(Product product, int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum+ BaseNum));
            var saveCash = saveCount * product.Price;
            var sum = Quantity * product.Price- saveCash;
            return string.Format(Const.ProductItemNormal, product.Name, Quantity, product.Unit,
                product.Price, sum);
        }
        public string GetPromationDescHeaderText()
        {
            return string.Format(Const.PromationDescHeadFormat, BaseNum, FreeNum);
        }
        public string GetPromationDescItemText(Product product, int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum + BaseNum));
            return string.Format(Const.PromationDescItemFormat, product.Name, saveCount, product.Unit);
        }

        public decimal GetProdcutSum(Product product,int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum + BaseNum));
            var saveCash = saveCount * product.Price;
            var sum = Quantity * product.Price - saveCash;

            return sum;
        }

        public decimal GetProdcutSave(Product product, int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum + BaseNum));
            var saveCash = saveCount * product.Price;

            return saveCash;
        }

      
    }
}
