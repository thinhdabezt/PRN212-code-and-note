using BookManagement.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DLL.Repositories
{
    public class CategoryRepository
    {
        private BookManagementDbContext _context;

        public List<BookCategory> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.BookCategories.ToList();
        }
    }
}
