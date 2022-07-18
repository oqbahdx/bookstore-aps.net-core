using bookstore.Models;

namespace bookstore.Repositories
{
    public class BookRepository : IBookRrepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>() { 
            
            new Book{ 
            
            Id = 1,Title = "C# programming", Description = "asp.ner core",
            },
                new Book{

            Id = 2,Title = "dart programming", Description = "flutter",
            },
                    new Book{

            Id = 3,Title = "java programming", Description = "Spring  boot",
            },
            };
        }
        public void add(Book entity)
        {
            books.Add(entity);  
        }

        public void delete(int id)
        {
            var book = find(id);
            books.Remove(book);
        }

        public Book find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
           
        }

        public IList<Book> List()
        {
            return books;
        }

        public void update(int id ,Book newBook)
        {

            var book = find(id);
            book.Author = newBook.Author;
            book.Title = newBook.Title;
            book.Description = newBook.Description;



        }
    }
}
