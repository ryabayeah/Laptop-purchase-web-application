using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Purchases
{
    public class OtherPurchase : IPurchase
    {
        public OtherPurchase() { }
        public string getWarrantyDuration()
        {
            return "1,5 год";
        }
        public string getShippingCost()
        {
            return "1500";
        }
    }
}
