namespace Minut_George_Alexandru_Lab_2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
