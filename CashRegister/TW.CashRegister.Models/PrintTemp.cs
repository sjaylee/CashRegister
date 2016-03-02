using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{

    public class Const
    {
        public static readonly string HeadFormat = @"***<没钱赚商店>购物清单***";
        public static readonly string ProductItemNormal= "名称：{0}，数量：{1}{2}，单价：{3}(元)，小计：{4}(元)";
        public static readonly string ProductItemDiscount = "名称：{0}，数量：{1}{2}，单价：{3}(元)，小计：{4}(元)，节省{5}(元)";

        public static readonly string PromationDescFromat = @"----------------------
买{0}赠{1}商品：
名称：{2}，数量：{3}{4}
名称：{5}，数量：{6}{7}";

        public static readonly string SummationNormal = @"----------------------
总计：{0}(元)
**********************";
        public static readonly string SummationPromotion = @"----------------------
总计：{0}(元)
节省：{1}(元)
**********************";
    }




    public class PrintTemp
    {
        /// <summary>
        /// 打印小票抬头
        /// TODO：移动到配置文件中
        /// </summary>
        public string Head { get; set; }

        public List<string> ProductItems { get; set; }

        public string DescForFree { get; set; }

        public string Summation { get; set; }
    }

}
