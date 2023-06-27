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
    public class PersonelRepo : IPersonelRepo
    {
        private readonly SurplusDatabaseContext data;

        public PersonelRepo(SurplusDatabaseContext Data)
        {
            data = Data;
        }
        public async void CreateUser(Personel user)
        {
            data.Add(user);
            await data.SaveChangesAsync();
        }

        public void DeleteUser(Personel user)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAllLocalUsers()
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Personel GetUserByEmail(string Email)
        {
            return data.Personels
                .Include(c => c.cantine)
                .Single(e => e.Email == Email);
        }

        public Personel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Personel GetUserByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public Personel GetUserFromDbById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(Personel user)
        {
            throw new NotImplementedException();
        }
    }
}
