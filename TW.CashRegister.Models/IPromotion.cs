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

        /// <summary>
        /// 是否单独显示促销活动的商品列表
        /// </summary>
        bool ShowPromationDesc { get; set; }

        /// <summary>
        /// 促销活动类型
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 收银单据商品明细
        /// </summary>
        /// <param name="product">参加该活动的商品</param>
        /// <param name="quantity">参加该活动商品的数量</param>
        /// <returns>返回参加该活动的商品小票明细</returns>
        string GetProductItemText(Product product, int quantity);

        /// <summary>
        /// 单独显示促销活动的商品列表的明细项
        /// </summary>
        /// <param name="product">参加该活动的商品</param>
        /// <param name="quantity">参加该活动商品的数量</param>
        /// <returns></returns>
        string GetPromationDescItemText(Product product, int quantity);

        /// <summary>
        /// 单独显示促销活动的商品列表区域的抬头。(需求中的："买二赠一商品：")
        /// </summary>
        /// <returns></returns>
        string GetPromationDescHeaderText();

        /// <summary>
        /// 获得商品（参加该促销后的）总价
        /// </summary>
        /// <param name="product">参加该活动的商品</param>
        /// <param name="quantity">参加该活动商品的数量</param>
        /// <returns></returns>
        decimal GetProdcutSum(Product product, int quantity);

        /// <summary>
        /// 获得商品（参加该促销后的）总价
        /// </summary>
        /// <param name="product">参加该活动的商品</param>
        /// <param name="quantity">参加该活动商品的数量</param>
        /// <returns></returns>
        decimal GetProdcutSave(Product product, int quantity);

       
    }
}
