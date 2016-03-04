using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 订单内容（字典：key 是商品，value是商品数量）
        /// </summary>
        public Dictionary<Product, int> Products { get; set; }   


        /// <summary>
        /// 获得收银小票内容
        /// </summary>
        /// <returns></returns>
        public string GetInvoiceContent()
        {
            var result = string.Empty;

            if (Products == null || Products.Count == 0)
                return string.Empty;


            var contentText = new StringBuilder();

            // 拼接发票抬头 、第一行
            contentText.AppendLine(Const.HeadFormat);
             

            // 拼接商品列表区
            decimal sum = 0;
            decimal save = 0;
            foreach (var pair in Products)
            {
                var product = pair.Key;
                var quantity = pair.Value;
                contentText.AppendLine(product.Promation.GetProductItemText(product, quantity));
                sum += product.Promation.GetProdcutSum(product, quantity);
                save += product.Promation.GetProdcutSave(product, quantity);
            }



            // 拼接活动商品列表区
            // concat below:
            //----------------------
            //            买二赠一商品：
            //名称：可口可乐，数量：1瓶
            //名称：羽毛球，数量：2个

            var groupByPromation = Products.Keys.ToLookup(p => p.Promation.ID);
            foreach (var gourp in groupByPromation)
            {
                
                var promation = gourp.FirstOrDefault().Promation;

                if (promation.ShowPromationDesc)
                {
                    contentText.AppendLine(Const.SplitLine);
                    contentText.AppendLine(promation.GetPromationDescHeaderText());

                    foreach (var pair in Products)
                    {
                        var product = pair.Key;
                        var quantity = pair.Value;

                        if ((product.Promation.ShowPromationDesc)
                            && product.Promation.GetProdcutSave(product, quantity) != decimal.Zero)
                        {
                            contentText.AppendLine(promation.GetPromationDescItemText(product, quantity));
                        }

                    }
                }

            }

            contentText.AppendLine(Const.SplitLine);



            // 拼接最终统计区
            if (save == decimal.Zero)
            {
                contentText.AppendFormat(Const.TotalSumFormat, sum.ToString("#0.00"));
                contentText.AppendLine();
            }
            else
            {
                contentText.AppendFormat(Const.TotalSumFormat, sum.ToString("#0.00"));
                contentText.AppendLine();

                contentText.AppendFormat(Const.TotalSaveFormat, save.ToString("#0.00"));
                contentText.AppendLine();
            }


            contentText.Append(Const.LastLine);


            return contentText.ToString();
        }
        
    }
}
