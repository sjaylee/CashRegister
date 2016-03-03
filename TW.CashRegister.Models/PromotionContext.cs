using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    public class PromotionContext
    {
        IPromotion promotionBase = null;
        // PromationFree_3_f_2 PromationDiscount_0.95
        public PromotionContext(string id)
        {

            string[] typeAndParms = id.Split('_');
            string promotionType = typeAndParms[0];


            if (!string.IsNullOrWhiteSpace(promotionType))
            {
                switch (promotionType)
                {
                    case "PromationFree":
                        int baseNum;
                        int freeNum;
                        if (typeAndParms.Length == 4  && int.TryParse(typeAndParms[1], out baseNum) 
                            && int.TryParse(typeAndParms[3], out freeNum))
                        {
                            promotionBase = new PromotionFree(baseNum, freeNum);
                        }
                        break;

                    case "PromationDiscount":
                        decimal discount;
                        if (typeAndParms.Length == 2 && decimal.TryParse(typeAndParms[1], out discount))
                        {
                            promotionBase = new PromotionDiscount(discount);
                        }
                        break;


                    default:
                        // 没有参与促销活动 等于折扣为零的打折促销 
                        promotionBase = new PromotionNormal();
                        break;
                }


            }

        }

        public IPromotion GetProductPromotion()
        {
            if (promotionBase != null)
                return promotionBase;

            return new PromotionNormal();
        }


    }


public class Cache
    {
        // 产品ID对应的活动ID
        // 
        private static readonly Dictionary<string, string> ProductOfPromotion = new Dictionary<string, string>();

        void UpdateOrInsert(Dictionary<string, string> newSettings)
        {

            //ProductOfPromotion.
        }
    }
}