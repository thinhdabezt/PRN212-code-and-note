using BookManagement.DAL.Models;
using BookManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Service
{
    public class BookService
    {
        private BookRepository _repo = new BookRepository();

        public List<Book> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
