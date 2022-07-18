using bookstore.Models;

namespace bookstore.Repositories
{
    public class AuthorRepository : IBookRrepository<Author>
    
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>() {

                new Author{Id = 1,FullName = "oqbah dx"},
                new Author{Id = 2,FullName = "flutter"},
                new Author{Id = 3,FullName = "Aps.net"},
            
            };
        }

        public void add(Author entity)
        {
            authors.Add(entity);
        }

        public void delete(int id)
        {
            var author = find(id);
             authors.Remove(author);
        }

        public Author find(int id)
        {
            var author = authors.FirstOrDefault(b => b.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void update(int id, Author newAuthor)
        {
            var author = find(id);
             author.FullName = newAuthor.FullName;
        }
    }
}
