using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface IPurchaseRepo
    {
        public IQueryable<ActualPurchases> Purchases { get; }

        public void SavePurchase(ActualPurchases purchases);
    }
}
