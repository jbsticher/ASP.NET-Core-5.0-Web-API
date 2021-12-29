using BookStore.DataDEC2021.Interfaces;
using BookStore.DataDEC2021.Models;
using BookStore.DataDEC2021.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //public List<Book> books = new List<Book>()
        //{
        //    new Book { Id = 1, Title = "The Girl on the Train", Author = "Hawkins, Paula", PublicationYear = 2015, IsAvailable = true, CallNumber = "20359"},
        //    new Book { Id = 2, Title = "1984", Author = "Orwell, George", PublicationYear = 1944, IsAvailable = true, CallNumber = "20722"},
        //    new Book { Id = 3, Title = "Strange Companion", Author = "Sticher, John", PublicationYear = 1988, IsAvailable = false, CallNumber = "20454"},
        //    new Book { Id = 4, Title = "Weird Science", Author = "Grifter, Jack", PublicationYear = 1982, IsAvailable = true, CallNumber = "17111"},
        //    new Book { Id = 5, Title = "The Great Gatsby", Author = "Lowe, Herman", PublicationYear = 1910, IsAvailable = true, CallNumber = "20229"},
        //    new Book { Id = 6, Title = "Old House", Author = "Lee, Christopher", PublicationYear = 1966, IsAvailable = false, CallNumber = "40533"}
        //};

        private BookRepository books = new BookRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            //var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
