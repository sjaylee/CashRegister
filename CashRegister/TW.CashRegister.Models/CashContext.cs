using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TW.CashRegister.Models
{
    public class CashContext
    {
        private IList<IPromotion> promotions;

        public CashContext(IList<IPromotion> promotions)
        {
            this.promotions = promotions;
        }
    }
}
