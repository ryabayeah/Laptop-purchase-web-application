using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ApplePurchase : IPurchase
    {
        public ApplePurchase() {  }
        public string getWarrantyDuration()
        {
            return "2 года";
        }
        public string getShippingCost()
        {
            return "1000";
        }
    }
}
