using Core.Domain.Domain;
using Core.DomainServices.Core.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainServices.Logic
{
    public class DomainFactory : IDomainFactory
    {
        public Student CreateBaseStudent(string name, string email, DateTime DateOfBirth, string Role)
        {
            return new Student() { Name = name, Email = email, DateOfBirth = DateOfBirth, role = Role};
        }

        public MealPacket CreateMealPacket(string name, double prive, string TypeMeal, DateTime Deadline, Cantine cantine)
        {
            throw new NotImplementedException();
        }

        public MealPacket CreateMealPacket(string name, double prive, string TypeMeal, DateTime Deadline, int CantineId)
        {
            throw new NotImplementedException();
        }

        public Personel CreatePersonel(string name, string email, DateTime DateOfBirth, string role, Cantine cantine)
        {
            throw new NotImplementedException();
        }

        public Personel CreatePersonel(string name, string email, DateTime DateOfBirth, string role, int CantineId)
        {
            throw new NotImplementedException();
        }
    }
}
