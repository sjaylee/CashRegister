using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.CashRegister.Common;
using TW.CashRegister.Models;

namespace TW.CashRegister.Service
{
    public class Cache
    {
        private static readonly Service _service = new Service();

         static readonly List<Product> Products = _service.GetAllProduct();

         static readonly List<IPromotion> Promotions = _service.GetAllPromotion();
        //private void UpdateProductBySetting(object dataSource)
        //{
        //    var dt = dataSource as DataTable;

        //    for

        //}

        public static readonly Dictionary<string,Product> ProductsById = 
            Products.ToDictionary(pd=>pd.BarCode,pd=>pd);

        public static readonly Dictionary<string, IPromotion> PromotionsById = 
            Promotions.ToDictionary(pm => pm.ID, pm => pm);
       

        public void UpdateProductsByOnePromotion(string promotionId, List<string> barCodes)
        {
            IPromotion promotion;

            if (PromotionsById.TryGetValue(promotionId, out promotion))
            {
                foreach (var barCode in barCodes)
                {
                    Product product;

                    if (ProductsById.TryGetValue(barCode, out product))
                    {
                        product.Promation = promotion;
                    }
                }

            }

        }

        public void UpdateProducts(List<PromotionSetting> settings)
        {
            foreach (var setting in settings)
            {
                string promotionId = setting.PromotionID;

                List<string> barCodes = setting.ProductIDs;

                UpdateProductsByOnePromotion(promotionId, barCodes);
                //IPromotion promotion;

                //if (PromotionsById.TryGetValue(promotionId, out promotion))
                //{
                //    foreach (var barCode in barCodes)
                //    {
                //        Product product;

                //        if (ProductsById.TryGetValue(barCode, out product))
                //        {
                //            product.Promation = promotion;
                //        }
                //    }

                //}
            }

        }

        public string UpdateJson()
        {
            var groupedByPromotion = ProductsById.Values.ToLookup(pd => pd.Promation.ID);

            var promotionSettings = new List<PromotionSetting>();

            foreach (var group in groupedByPromotion)
            {
                PromotionSetting setting = new PromotionSetting();
                setting.PromotionID = group.Key;
                setting.ProductIDs = group.Select(pd => pd.BarCode).ToList();

                promotionSettings.Add(setting);
            }


            var content = JsonHelper.SerializeObject(promotionSettings);

            _service.SavePromotionSettings(content);

            return content;

        }

       

    }
}
