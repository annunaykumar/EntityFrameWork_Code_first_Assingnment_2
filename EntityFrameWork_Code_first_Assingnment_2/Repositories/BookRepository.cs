﻿using EntityFrameWork_Code_first_Assingnment_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Code_first_Assingnment_2.Repositories
{
    internal class BookRepository
    {
        public MyContextDB db = new MyContextDB();
        public void AddBook(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }
        public List<Book> GetAllBook()
        {
            return db.Books.ToList();
        }
        public List<Book> GetBookByBookId(int bookId)
        {
            return db.Books.Where(b => b.BookId == bookId).ToList();
        }
        public Book GetBook(int bookId)
        {
            return db.Books.Find(bookId);
        }
        public void DeleteBook(int bookId)
        {
            Book book = db.Books.Find(bookId);
            db.Books.Remove(book);
            db.SaveChanges();
        }
        public void EditBook(int bookId, double price) // price is new price
        {
            Book book = db.Books.Find(bookId);
            book.Price = price;
            db.SaveChanges();
        }
    }
}
