using BookManagement.DLL.Models;
using BookManagement.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class BookService
    {
        private BookRepository _repo = new BookRepository();

        public List<Book> GetAll()
        {
            return _repo.GetAll();
        }

        public void Create(Book book)
        {
            _repo.Create(book);
        }

        public void Update(Book book)
        {
            _repo.Update(book);
        }

        public void Delete(Book book)
        {
            _repo.Delete(book);
        }
    }
}
