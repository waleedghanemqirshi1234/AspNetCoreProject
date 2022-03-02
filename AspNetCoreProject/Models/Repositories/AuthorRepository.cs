using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        List<Author> ListAuthors;
        public AuthorRepository()
        {
            ListAuthors = new List<Author>()
            {
                new Author
                {
                    Id=1 ,FullName="Waleed Ghanem"
                },
                 new Author
                {
                    Id=2 ,FullName="Mohammed Ali"
                },
                  new Author
                {
                    Id=3 ,FullName="Salah Khaled"
                }
            };     
        }
        public void Add(Author entity) 
        {
            ListAuthors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            ListAuthors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = ListAuthors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return ListAuthors;
        }

        public void Update(Author NewAuthor,int id)
        {
            var author = Find(id);
            author.FullName = NewAuthor.FullName;

        }

    }
}
