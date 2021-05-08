using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public abstract class PurchaseRealizationFactory
    {
        abstract public IPurchase Checkout();
    }
}
