using BookStore.DataDEC2021.Interfaces;
using BookStore.DataDEC2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataDEC2021.Repositories
{
    public class BookRepository : IBookRepository
    {

    public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "The Invisible Man", Author = "Wells, H.G.", PublicationYear = 1897, IsAvailable = true, CallNumber = "20359"},
            new Book { Id = 2, Title = "1984", Author = "Orwell, George", PublicationYear = 1944, IsAvailable = true, CallNumber = "20722"},
            new Book { Id = 3, Title = "Strange Companion", Author = "Sticher, John", PublicationYear = 1988, IsAvailable = false, CallNumber = "20454"},
            new Book { Id = 4, Title = "Weird Science", Author = "Grifter, Jack", PublicationYear = 1982, IsAvailable = true, CallNumber = "17111"},
            new Book { Id = 5, Title = "The Great Gatsby", Author = "Lowe, Herman", PublicationYear = 1910, IsAvailable = true, CallNumber = "20229"},
            new Book { Id = 6, Title = "Old House", Author = "Lee, Christopher", PublicationYear = 1966, IsAvailable = false, CallNumber = "40533"}
    };
    
        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}
