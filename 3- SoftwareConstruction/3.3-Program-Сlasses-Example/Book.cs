namespace Sleep_Safety_Reading.Models
{
    public class Book
    {
        public int bookId { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int publicated { get; set; }
        public string translationAuthor { get; set; }
        public int pages { get; set; }
        public int libraryId { get; set; }
        public Library library { get; set; }
    }
}
