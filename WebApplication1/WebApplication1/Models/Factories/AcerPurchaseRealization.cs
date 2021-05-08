using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models.Factories
{
    public class AcerPurchaseRealization : PurchaseRealizationFactory
    {
        public AcerPurchaseRealization() { }
        public override IPurchase Checkout()
        {
            return new AcerPurchase();
        }
    }
}
