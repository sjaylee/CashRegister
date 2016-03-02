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
        
        public IList<Product> Products { get; set; }

   

        public PrintTemp GetPrintTemp()
        {
            PrintTemp result = new PrintTemp();           

            

            return result;
        }
        
    }
}
