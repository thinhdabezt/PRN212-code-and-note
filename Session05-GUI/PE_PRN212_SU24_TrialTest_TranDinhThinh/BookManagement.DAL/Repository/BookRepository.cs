using BookManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repository
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.Books.Include("BookCategory").ToList();
        }

        public void Delete(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Remove(book);
        }
    }
}
