using BookManagement.DAL.Models;
using BookManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Service
{
    public class UserService
    {
        private UserRepository _repo = new UserRepository();

        public UserAccount Login(string email, string password)
        {
            return _repo.GetOne(email, password);
        }
    }
}
