using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public interface IBookStoreRepo
    {
        IQueryable<Book> Books { get; } // can only read from this data
    }
}
