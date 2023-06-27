using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.Intf
{
    public interface IDomainFactory
    {
        Student CreateBaseStudent(string name, string email, DateTime DateOfBirth, string role);

        Personel CreatePersonel(string name, string email, DateTime DateOfBirth, string role, Cantine cantine);
        Personel CreatePersonel(string name, string email, DateTime DateOfBirth, string role, int CantineId);

        MealPacket CreateMealPacket(string name, double prive, string TypeMeal, DateTime Deadline, Cantine cantine);
        MealPacket CreateMealPacket(string name, double prive, string TypeMeal, DateTime Deadline, int CantineId);
    }
}
