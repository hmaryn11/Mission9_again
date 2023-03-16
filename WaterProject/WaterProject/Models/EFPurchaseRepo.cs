using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class EFPurchaseRepo : IPurchaseRepo
    {
        private BookstoreContext context;

        public EFPurchaseRepo (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<ActualPurchases> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x=> x.Book);

        public void SavePurchase(ActualPurchases purchases)
        {
            context.AttachRange(purchases.Lines.Select(x => x.Book));

            if(purchases.PurchaseId == 0)
            {
                context.Purchases.Add(purchases);
            }
            context.SaveChanges();
        }
    }
}
