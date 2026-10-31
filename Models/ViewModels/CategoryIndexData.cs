using Minut_George_Alexandru_Lab_2.Models;

namespace Minut_George_Alexandru_Lab_2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
