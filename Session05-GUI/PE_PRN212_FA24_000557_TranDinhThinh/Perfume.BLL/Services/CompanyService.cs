using Perfume.DAL;
using Perfume.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.BLL.Services
{
    public class CompanyService
    {
        private CompanyRepository _repo = new CompanyRepository();

        public List<ProductionCompany> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
