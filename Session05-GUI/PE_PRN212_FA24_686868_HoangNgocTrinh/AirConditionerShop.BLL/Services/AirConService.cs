﻿using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConService
    {
        private AirConRepository _repo = new();//new luôn vì nó mức xa database rồi

        //các hàm crud aircon nhưng gọi qua repo
        public List<AirConditioner> GetAllAirCons()
        {
            return _repo.GetAll();
        }

        public void DeleteAirCon(AirConditioner obj)
        {
            _repo.Delete(obj);
        }
        public void UpdateAirCon(AirConditioner obj)
        {
            _repo.Update(obj);
        }

        public void CreateAirCon(AirConditioner obj)
        {
            _repo.Create(obj);
        }

        public List<AirConditioner> Search(string feature, int? quantity)
        {
            return _repo.Search(feature, quantity);
        }
    }
}
