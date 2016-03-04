using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 常用常量
    /// TODO： 定义成配置文件，方便以后发票格式修改后代码修正
    /// </summary>
    public class Const
    {
        public static readonly string HeadFormat = @"***<没钱赚商店>购物清单***";
        public static readonly string ProductItemNormal= @"名称：{0}，数量：{1}{2}，单价：{3}(元)，小计：{4}(元)";
        public static readonly string ProductItemDiscount = "名称：{0}，数量：{1}{2}，单价：{3}(元)，小计：{4}(元)，节省{5}(元)";

        public static readonly string PromationDescHeadFormat = @"买{0}赠{1}商品：";
        public static readonly string PromationDescItemFormat = @"名称：{0}，数量：{1}{2}";


        public static readonly string TotalSumFormat = @"总计：{0}(元)";
        public static readonly string TotalSaveFormat = @"节省：{0}(元)";

        public static readonly string SplitLine = @"----------------------";
        public static readonly string LastLine = @"**********************";
    }



    /// <summary>
    /// 发票格式
    /// </summary>
    public class PrintTemp
    {
        /// <summary>
        /// 打印小票抬头
        /// TODO：移动到配置文件中
        /// </summary>
        public string Head { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        public List<string> ProductItems { get; set; }

        /// <summary>
        /// 活动订单列表区
        /// </summary>
        public string DescForFree { get; set; }

        /// <summary>
        /// 结算区 总计 和总节省
        /// </summary>
        public string Summation { get; set; }
    }

}
