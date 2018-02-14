using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Controllers
{

    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var books = GetBooks();
            return View(books);
        }
        public IActionResult New()
        {
            return View();
        }
        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book(){
                Title = "Continuous Delivery",
                Author = new Author(){Name = "Jez Humble"}});
             books.Add(new Book()
             {
                Title = "Lean Enterprise",
                Author = new Author() { Name = "Barry O'Reilly" }
            });
             books.Add(new Book()
             {
                Title = "The Goal",
                Author = new Author() { Name = "Eliyahu Goldratt" }
            }); 

            return books;                     
        }
    }
}