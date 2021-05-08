using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Factories
{
    public class ApplePurchaseRealization : PurchaseRealizationFactory
    {
        public ApplePurchaseRealization() { }
        public override IPurchase Checkout()
        {
            return new ApplePurchase();
        }
    }
}
