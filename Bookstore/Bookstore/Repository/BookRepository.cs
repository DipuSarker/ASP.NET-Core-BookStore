using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetGetAllBook()
        {
            return DataSource();
        }

        public BookModel GetBookById( int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Dipu"},
                new BookModel(){Id=2, Title="MVC2", Author="Dipu2"},
                new BookModel(){Id=3, Title="MVC3", Author="Dipu3"},
                new BookModel(){Id=4, Title="MVC4", Author="Dipu4"}
            };
        }
    }
}
