using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AcerPurchase: IPurchase
    {
        public AcerPurchase() { }
        public string getWarrantyDuration()
        {
            return "1 год";
        }
        public string getShippingCost()
        {
            return "1100";
        }
    }
}
