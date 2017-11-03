using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNote
{
    public interface ICreator
    {
        List<Category> GetAllCategories();
        List<Book> GetAllBooks();
        int InsertCategory(Category obj);
        int InsertBook(Book obj);
        bool UpdateBook(Book obj);
        bool UpdateCategory(Category obj);
    }
}
