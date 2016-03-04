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
    public class PromotionFree : IPromotion
    {
        public PromotionFree(int baseNum, int freeNum)
        {

            this.BaseNum = baseNum;
            this.FreeNum = freeNum;

        }

        /// <summary>
        /// 卖m赠送n中的m
        /// </summary>
        public int BaseNum { get; set; }

        /// <summary>
        ///  卖m赠送n中的n
        /// </summary>
        public int FreeNum { get; set; }

        public string ID
        { get; set; }

        public string Name
        { get; set; }

        public int Priority
        { get; set; }

        public bool Unique
        { get; set; }

        public bool ShowPromationDesc
        { get; set; }

        public string Type
        { get; set; }

        public string GetProductItemText(Product product, int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum+ BaseNum));
            var saveCash = saveCount * product.Price;
            var sum = Quantity * product.Price- saveCash;
            return string.Format(Const.ProductItemNormal, product.Name, Quantity.ToString(), product.Unit,
                product.Price.ToString("#0.00"), sum.ToString("#0.00"));
        }
        public string GetPromationDescHeaderText()
        {
            return string.Format(Const.PromationDescHeadFormat, BaseNum, FreeNum);
        }
        public string GetPromationDescItemText(Product product, int Quantity)
        {
            var saveCount = (int)Math.Floor(1.0 * Quantity * FreeNum / (FreeNum + BaseNum));
            return string.Format(Const.PromationDescItemFormat, product.Name, saveCount.ToString(), product.Unit);
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
