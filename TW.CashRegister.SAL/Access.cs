using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.CashRegister.Common;
using TW.CashRegister.Models;

namespace TW.CashRegister.SAL
{
    public static class Access
    {
        public static readonly DirectoryInfo BaseDicrectory = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory);
 
        public static readonly string ProductsDataFilePath = Path.Combine(BaseDicrectory.Parent.Parent.FullName, "Data//Product.json");

        public static readonly string PromationDataFilePath = Path.Combine(BaseDicrectory.Parent.Parent.FullName, "Data//Promation//");

        public static readonly string PromationSettingFilePath = Path.Combine(BaseDicrectory.Parent.Parent.FullName, "Data//PromotionSetting.json");

        public static List<Product> GetProducts()
        {
            if (!File.Exists(ProductsDataFilePath))
            {
                throw new Exception(ProductsDataFilePath + " is not exist!");
            }

            var context = File.ReadAllText(ProductsDataFilePath);
            return JsonHelper.DeserializeJsonToList<Product>(context);
        }

        public static List<IPromotion> GetPromation()
        {
            var result = new List<IPromotion>();
            if (!Directory.Exists (PromationDataFilePath))
            {
                throw new Exception(PromationDataFilePath + " is not exist!");
            }

            var directory = new DirectoryInfo(PromationDataFilePath);
            var files = directory.GetFiles();

            IPromotion promotion=null;
            foreach (var file in files)
            {
                var content = File.ReadAllText(file.FullName);

                // TODO: 利用反射根据文件名生成对象
                // IOC 容器
                switch (file.Name)
                {
                    case "PromotionFree.json":
                        promotion = JsonHelper.DeserializeJsonToObject<PromotionFree>(content);
                        break;

                    case "PromotionDiscount.json":
                        promotion = JsonHelper.DeserializeJsonToObject<PromotionDiscount>(content);
                        break;

                    case "PromotionNormal.json":
                        promotion = JsonHelper.DeserializeJsonToObject<PromotionNormal>(content);
                        break;

                    default:
                        break;

                }


                result.Add(promotion);
            }
           
            //var temp = JsonHelper.JsonToList<IPromotion>(context);        

            return result;
        
        }

        public static string GetDefaultPromotionSetting(out List<PromotionSetting> settings)
        {
            if (!File.Exists(PromationSettingFilePath))
            {
                throw new Exception(PromationSettingFilePath + " is not exist!");
            }

            var content = File.ReadAllText(PromationSettingFilePath);

            settings = JsonHelper.DeserializeJsonToList<PromotionSetting>(content);

            return content;
        }

        public  static void SavePromotionSetting(string jsonContent)
        {
            if (!File.Exists(PromationSettingFilePath))
            {
                throw new Exception(PromationSettingFilePath + " is not exist!");
            }

            File.WriteAllText(PromationSettingFilePath, jsonContent, Encoding.UTF8);
        }
    }
}
