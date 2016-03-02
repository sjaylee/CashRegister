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
        string ID{ get;  }

        /// <summary>
        /// 活动名称
        /// </summary>
        string Name { get;  }

        /// <summary>
        /// 活动优先级
        /// </summary>
        int Priority { get; set; }

        /// <summary>
        /// 多活动并存时，该活动是否会成为唯一活动
        /// </summary>
        bool Unique { get;  } 

        bool ShowPromationDesc { get; }

        string ProductItemFormat { get; }

        string PromationDescFromat { get; }

        string GetProductItemText(Product product);

        string GetPromationDescItemText(Product product);

        decimal GetProdcutSum(Product product);

        decimal GetProdcutSave(Product product);
    }
}
