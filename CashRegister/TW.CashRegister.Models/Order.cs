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
        
        public SortedDictionary<Product,int> Products { get; set; }

   

        public string GetPrintTemp()
        {
            var result = string.Empty;
            var resultTemp = new StringBuilder();

            resultTemp.AppendLine(Const.HeadFormat);


             
            decimal sum = 0;
            decimal save = 0;
            foreach (var pair in Products)
            {
                var product = pair.Key;
                var Quantity = pair.Value;
                resultTemp.AppendLine(product.Promation.GetProductItemText(product, Quantity));
                sum += product.Promation.GetProdcutSum(product, Quantity);
                save += product.Promation.GetProdcutSave(product, Quantity);
            }

            // concat below:
            //----------------------
            //            买二赠一商品：
            //名称：可口可乐，数量：1瓶
            //名称：羽毛球，数量：2个

            var groupByPromationDict = Products.Keys.ToDictionary(p => p.Promation.ID, p => p.Promation);
            var groupByPromation = Products.Keys.ToLookup(p => p.Promation.ID);
            foreach (var gourp in groupByPromation)
            {
                var promation = groupByPromationDict[gourp.Key];

                if (promation.ShowPromationDesc)
                {
                    resultTemp.AppendLine(Const.SplitLine);
                    resultTemp.AppendLine(promation.GetPromationDescHeaderText());
                    foreach (var pair in Products)
                    {
                        var product = pair.Key;
                        var Quantity = pair.Value;
                        if (product.Promation.ShowPromationDesc)
                        {
                            resultTemp.AppendLine(promation.GetPromationDescItemText(product,Quantity));
                        }

                    }
                }

            }
            if (save > 0)
            {
                resultTemp.AppendFormat(Const.TotalSumFormat, sum);
                resultTemp.AppendLine();
            }
            else
            {
                resultTemp.AppendFormat(Const.TotalSumFormat, sum);
                resultTemp.AppendLine();

                resultTemp.AppendFormat(Const.TotalSaveFormat, sum);
                resultTemp.AppendLine();
            }


            resultTemp.AppendLine(Const.LastLine);
            return resultTemp.ToString();
        }
        
    }
}
