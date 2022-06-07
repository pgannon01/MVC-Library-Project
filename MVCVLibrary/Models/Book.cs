namespace MVCVLibrary.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string CallNumber { get; set; } // Location of the book in the library
        public string Author { get; set; }
    }
}
