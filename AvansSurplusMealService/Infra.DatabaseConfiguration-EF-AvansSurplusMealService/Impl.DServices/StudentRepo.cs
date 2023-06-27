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
    public class StudentRepo : IStudentRepo
    {
        private readonly SurplusDatabaseContext data;

        public StudentRepo(SurplusDatabaseContext Data)
        {
            data = Data;
        }

        public async void CreateUser(Student user)
        {
            data.Students.Add(user);
            await data.SaveChangesAsync();
        }

        public void DeleteUser(Student user)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllLocalUsers()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByStudentId(string studentId)
        {
            throw new NotImplementedException();
        }

        public Student GetUserByEmail(string Email)
        {
            var User = data.Students
                .Include(mr => mr.MealReservations)
                .Where(u => u.Email == Email)
                .First();

            return User;
        }

        public Student GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetUserByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public Student GetUserFromDbById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(Student user)
        {
            throw new NotImplementedException();
        }
    }
}
