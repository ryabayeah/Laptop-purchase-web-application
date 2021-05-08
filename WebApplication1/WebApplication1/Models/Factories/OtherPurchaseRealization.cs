using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Purchases;

namespace WebApplication1.Models.Factories
{
    public class OtherPurchaseRealization : PurchaseRealizationFactory
    {
        public OtherPurchaseRealization() { }
        public override IPurchase Checkout()
        {
            return new OtherPurchase();
        }
    }
}
