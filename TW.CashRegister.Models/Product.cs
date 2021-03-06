﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Product
    {
        public override bool Equals(object obj)
        {

            Product other = obj as Product;
            if (other != null)
                return other.Name.Equals(Name);

            return false;

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
       

        /// <summary>
        /// 单位：瓶 、个、 斤
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 条形码（伪）
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 商品对应的促销活动
        /// </summary>
        public IPromotion Promation { get; set; } = new PromotionNormal();
       
    }
}
