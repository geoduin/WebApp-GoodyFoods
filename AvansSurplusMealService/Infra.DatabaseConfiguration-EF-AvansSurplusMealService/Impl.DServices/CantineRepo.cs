using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Impl.DServices
{
    public class CantineRepo : ICantineRepo
    {
        private readonly SurplusDatabaseContext Data;

        public CantineRepo(SurplusDatabaseContext data)
        {
            this.Data = data;
        }

        public void CreateCantine(Cantine cantine)
        {
            throw new NotImplementedException();
        }

        public void DeleteCantine(Cantine cantine)
        {
            throw new NotImplementedException();
        }

        public void DeleteCantineById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cantine> GetAllCantines()
        {
            return Data.Cantines.ToList();
        }

        public Cantine GetCantineByCity(string city)
        {
            throw new NotImplementedException();
        }

        public Cantine GetCantineById(int Id)
        {
            return Data.Cantines.Where(c => c.Id == Id).First();
        }

        public void UpdateCantine(Cantine cantine)
        {
            throw new NotImplementedException();
        }
    }
}
