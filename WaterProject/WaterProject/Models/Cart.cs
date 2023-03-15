using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();
        public virtual void AddItem(Book book, int qty)
        {
            CartLineItem Line = Items
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (Line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }
        public double CalculateTotal()
        {
            //must find a way to add up all rows instead
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);
         
            return sum;
        }
    }
    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

        public BookstoreContext Price { get; set; }
    }
}
