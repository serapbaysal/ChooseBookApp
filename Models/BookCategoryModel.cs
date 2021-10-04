using System.Collections.Generic;

namespace ChooseBookApp.Models
{
    public class BookCategoryModel
    {
        public Book Book { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}