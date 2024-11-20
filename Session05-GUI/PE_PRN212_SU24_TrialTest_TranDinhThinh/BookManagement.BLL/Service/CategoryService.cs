using BookManagement.DAL.Models;
using BookManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Service
{
    public class CategoryService
    {
        private CategoryRepository _repo = new CategoryRepository();

        public List<BookCategory> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
