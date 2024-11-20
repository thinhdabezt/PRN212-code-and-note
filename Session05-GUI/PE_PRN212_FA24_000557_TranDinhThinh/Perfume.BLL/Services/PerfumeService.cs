using Perfume.DAL;
using Perfume.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfume.BLL.Services
{
    public class PerfumeService
    {
        private PerfumeRepository _repository = new PerfumeRepository();

        public List<PerfumeInformation> GetAll()
        {
            return _repository.GetAll();
        }

        public void Create(PerfumeInformation perfumeInformation)
        {
            _repository.Create(perfumeInformation);
        }

        public void Update(PerfumeInformation perfumeInformation)
        {
            _repository.Update(perfumeInformation);
        }

        public void Delete (PerfumeInformation perfumeInformation)
        {
            _repository.Delete(perfumeInformation);
        }
    }
}
