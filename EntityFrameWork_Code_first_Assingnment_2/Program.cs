using EntityFrameWork_Code_first_Assingnment_2.Entities;
using EntityFrameWork_Code_first_Assingnment_2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Code_first_Assingnment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookRepository bookRepository = new BookRepository();
            OrderRepository Repository = new OrderRepository();
            do
            {
                Console.WriteLine("1.AddOrder\n2.AddBook\n3.GetAllBook\n4.GetBookByBookId\n5.DeleteBook" +
                    "\n6.EditBook");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Order order = new Order() { OrderId = 16, OrderDate = new DateTime(2022, 05, 14), BookId = 11 };
                            Repository.AddOrder(order);
                        }
                        break;

                    case 2:
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter BookId");
                            book.BookId = int.Parse(Console.ReadLine());
                            book.BookName = "Game Of Thrones";
                            book.Price = 24000;
                            book.Author = "David Benioff";
                            bookRepository.AddBook(book);
                        }
                        break;
                    case 3:
                        {
                            List<Book> book = bookRepository.GetAllBook();
                            foreach (var books in book)
                                Console.WriteLine($"ID:{books.BookId} Name:{books.BookName} Price:{books.Price} Author:{books.Author}");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            Book book = bookRepository.GetBook(id);
                            Console.WriteLine($"ID:{book.BookId} Name:{book.BookName} Price:{book.Price} Author:{book.Author}");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            bookRepository.DeleteBook(id);
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Enter BookId");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Price");
                            double price = double.Parse(Console.ReadLine());
                            bookRepository.EditBook(id, price);
                        }
                        break;

                }
            } while (true);
        }
    }
}
