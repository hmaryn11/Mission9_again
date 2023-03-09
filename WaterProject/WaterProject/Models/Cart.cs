﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();
        public void AddItem(Book book, int qty)
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
        public double CalculateTotal()
        {
            //must find a way to add up all rows instead
            double sum = Items.Sum(x => x.Quantity * 1);
         
            return sum;
        }
    }
    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}