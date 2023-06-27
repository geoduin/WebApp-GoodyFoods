using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Core.DomainServices.Core.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainServices.Logic
{
    public class MealPacketService : IMealPacketService
    {
        private readonly IMealPacketRepo _mealPacketRepo;
        public MealPacketService(IMealPacketRepo mealPacketRepo)
        {
            _mealPacketRepo = mealPacketRepo;
        }

        public MealPacket AssignNewCantine(Cantine NewCantine, MealPacket mealPacket)
        {
            mealPacket.Cantine = NewCantine;
            return mealPacket;
        }

        public MealPacket CreateMealPacket(
            string Name, 
            List<MealPacketProduct> ProductList, 
            Cantine Cantine, 
            double Price, 
            string typeMeal, 
            DateTime DeadlineDate
            )
        {
            MealPacket mealPacket = new MealPacket() { 
                Name = Name, 
                ProductList = ProductList, 
                DeadlineDate = DeadlineDate, 
                Price = Price, 
                Cantine = Cantine };

            return mealPacket;
        }

        public List<string> GetAllTypesMeals()
        {
            return new List<string>();
        }
    }
}
