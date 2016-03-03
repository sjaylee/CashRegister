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
        public static DataTable GenTableForSetPromation()
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

        public static List<Product> GetAllProduct()
        {
            return Access.GetProducts();
        }

         
    }

  
}
