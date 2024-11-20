using Perfume.DAL;
using Perfume.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.BLL.Services
{
    public class AccountService
    {
        private AccountRepository _repo = new AccountRepository();

        public Psaccount? Login(string username, string password)
        {
            return _repo.Check(username, password);
        }
    }
}
