namespace Sleep_Safety_Reading.Models
{
    public class Library
    {
        public int libraryId { get; set; }
        public string name { get; set; }
        public int booksNumber { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public ICollection<Book> books { get; set; }

        public Library()
        {
            books = new List<Book>();
        }
        public int addBook(Book book)
        {
            if (book != null)
            {
                books.Add(book);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int deleteBook(Book book)
        {
            if (book != null)
            {
                books.Remove(book);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
