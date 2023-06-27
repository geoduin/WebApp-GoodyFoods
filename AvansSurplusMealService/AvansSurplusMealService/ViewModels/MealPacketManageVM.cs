using Core.Domain.Domain;

namespace AvansSurplusMealService.ViewModels
{
    public class MealPacketManageVM
    {
        public List<MealPacket> CurrentList   { get; set; }
        public List<Cantine> CantineList { get; set; }

        public string? City { get; set; }
        public string? Location { get; set; }

        public bool? ServesWarm { get; set; }
        public Cantine? CurrentCanteen { get; internal set; }
    }
}
