using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;

using Microsoft.EntityFrameworkCore;


namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Impl.DServices
{
    public class SurplusMealRepo : IMealPacketRepo
    {
        public List<MealPacket> PacketListMemory { get; set; }
        //DatabaseContext
        private readonly SurplusDatabaseContext Database;

        public SurplusMealRepo(SurplusDatabaseContext dbContext)
        {
            Database = dbContext;

            //Fills local list
            PacketListMemory = new List<MealPacket>();
        }

        public void DeletePacket(MealPacket mealPacket)
        {
            throw new NotImplementedException();
        }

        public void DeletePacketById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MealPacket> GetAllPacketsDB()
        {
            List<MealPacket> packets = Database
                .MealPackets
                .Include(mp => mp.StudentClaim)
                .Include(mp => mp.Cantine)
                .Include(mp => mp.ProductList)
                .ToList();
            return packets;
        }

        public MealPacket GetPacketById(int id)
        {
            MealPacket Meal = Database.MealPackets.AsSingleQuery()
                .Include(m => m.Cantine)
                .Include(p => p.ProductList)
                .Where(i => i.Id == id)
                .First();
            return Meal;
        }

        public MealPacket GetPacketByName(string name)
        {
            throw new NotImplementedException();
        }

        public MealPacket GetPacketByTag(string tag)
        {
            throw new NotImplementedException();
        }

        public MealPacket GetPacketByTags(List<string> tagList)
        {
            throw new NotImplementedException();
        }

        public void UpdatePacket(MealPacket mealPacket)
        {
            throw new NotImplementedException();
        }

        public List<MealPacket> GetAllPacketsPerCantine(int CantineId)
        {
            return Database.MealPackets
                .Include(c => c.Cantine)
                .Where(m => m.CantineId == CantineId)
                .ToList();
        }
    }
}
