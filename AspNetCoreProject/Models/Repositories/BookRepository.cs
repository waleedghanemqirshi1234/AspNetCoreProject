using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {
       
        List<Book> ListBooks;
        public BookRepository()
        {
           ListBooks = new List<Book>()
            {
                 new Book
                 {
                     Id=1,Title="C# Programming",Description="C# Description"
                 },
                   new Book
                 {
                     Id=2,Title="Java Programming",Description="Java Description"
                 },
                     new Book
                 {
                     Id=3,Title="Python Programming",Description="Python Description"
                 },
            };
        }
        public void Add(Book entity)
        {
            ListBooks.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            ListBooks.Remove(book);
        }

        public Book Find(int id)
        {
            var book = ListBooks.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return ListBooks;
        }

        public void Update(Book NewBook,int id)
        {
            var book = Find(id);
            book.Title = NewBook.Title;
            book.Description = NewBook.Description;
            book.Author = NewBook.Author;
        }
    }
}
