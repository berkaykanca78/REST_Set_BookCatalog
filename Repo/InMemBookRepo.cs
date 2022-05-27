using BookCatalog.Models;

namespace BookCatalog.Repo
{
    public class InMemBookRepo : IBook
    {
        private List<Book> _Books;
        public InMemBookRepo()
        {
            _Books = new()
            {
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Book 0",
                    Price = 10,
                }
            };
        }
        public void CreateBook(Book book)
        {
            _Books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            var bookIndex = _Books.FindIndex(x => x.Id == id);

            if (bookIndex > -1)
                _Books.RemoveAt(bookIndex);
        }

        public Book GetBook(Guid id)
        {
            var book = _Books.Where(i => i.Id == id).SingleOrDefault();
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _Books;
        }

        public void UpdateBook(Guid id, Book book)
        {
            var bookIndex = _Books.FindIndex(x => x.Id == id);
            if(bookIndex > -1)
                _Books[bookIndex] = book;
        }
    }
}
