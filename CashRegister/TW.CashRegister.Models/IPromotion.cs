using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 促销活动接口
    /// </summary>
    public interface IPromotion
    {
      
        /// <summary>
        /// 活动ID
        /// </summary>
        string ID { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 活动优先级
        /// </summary>
        int Priority { get; set; }

        /// <summary>
        /// 多活动并存时，该活动是否会成为唯一活动
        /// </summary>
        bool Unique { get; set; }

        bool ShowPromationDesc { get; set; }

        string Type { get; set; }
        //string ProductItemFormat { get; }

        //string PromationDescHeadFormat { get; }

        //string PromationDescItemFormat { get; }


        string GetProductItemText(Product product, int Quantity);

        /// <summary>
        /// 名称：可口可乐，数量：1瓶 类似的文字
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        string GetPromationDescItemText(Product product, int Quantity);

        /// <summary>
        /// 买二赠一商品： 类似的文字
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        string GetPromationDescHeaderText();

        decimal GetProdcutSum(Product product, int Quantity);

        decimal GetProdcutSave(Product product, int Quantity);

       
    }
}
