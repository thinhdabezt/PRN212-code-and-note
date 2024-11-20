using BookManagement.DLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DLL.Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.Books.Include("BookCategory").ToList();
        }

        public void Create(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
