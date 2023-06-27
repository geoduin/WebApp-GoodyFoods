using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.Intf
{
    public interface IMealPacketService
    {
        MealPacket AssignNewCantine(Cantine NewCantine, MealPacket mealPacket);

        MealPacket CreateMealPacket(string Name, List<MealPacketProduct> ProductList, Cantine Cantine, double Price, string typeMeal, DateTime DeadlineDate);

    }
}
