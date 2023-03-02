using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class EFBookStoreRepo : IBookStoreRepo
    {
        private BookstoreContext context { get; set; }
        
        public EFBookStoreRepo (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
