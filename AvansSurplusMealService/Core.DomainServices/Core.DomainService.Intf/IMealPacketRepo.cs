using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface IMealPacketRepo
    {
        MealPacket GetPacketById(int id);
        MealPacket GetPacketByName(string name);
        MealPacket GetPacketByTag(string tag);
        MealPacket GetPacketByTags(List<string> tagList);

        void UpdatePacket(MealPacket mealPacket);
        void DeletePacket(MealPacket mealPacket);
        void DeletePacketById(int id);

        List<MealPacket> GetAllPacketsDB();

        List<MealPacket> GetAllPacketsPerCantine(int CantineId);
    }
}
