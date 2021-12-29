using BookStore.DataDEC2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataDEC2021.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
