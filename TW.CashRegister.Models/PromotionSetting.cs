using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 活动商品设置
    /// </summary>
    public class PromotionSetting
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        public string PromotionID { get; set; } // "PromotionDiscount_0.95",

        /// <summary>
        /// 商品ID列表
        /// </summary>
        public List<string> ProductIDs { get; set; }//: [ "ITEM000001", "ITEM000003" ]
    }
}
