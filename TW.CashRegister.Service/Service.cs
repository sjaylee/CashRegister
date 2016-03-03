using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW.CashRegister.Models;
using TW.CashRegister.SAL;

namespace TW.CashRegister.Service
{
    public class Service
    {

        

        public  DataTable GenTableForSetPromation()
        {
            var products = Access.GetProducts();

            var promations = Access.GetPromation();

            DataTable dt = new DataTable();
            dt.Columns.Add("ProductName");
            foreach (var prom in promations)
            {
                dt.Columns.Add(prom.ID);
            }

            var dr = dt.NewRow();
            foreach (var product in products)
            {
                dr = dt.NewRow();
                dr["ProductName"] = product.Name;
                foreach (var promation in promations)
                { dr[promation.ID] = false; }

                dt.Rows.Add(dr);
            }

            return dt;

        }

        internal  List<Product> GetAllProduct()
        {
            return Access.GetProducts();
        }

        internal List<IPromotion> GetAllPromotion()
        {
            return Access.GetPromation();
        }

        public void SavePromotionSettings(string jsonContent)
        {
            Access.SavePromotionSetting(jsonContent);
        }

        public string RetrivePromotionSettings(out List<PromotionSetting> settings)
        {
            return Access.GetDefaultPromotionSetting(out settings);
            
        }

    }


}
