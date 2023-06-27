using Core.Domain.Domain;

namespace AvansSurplusMealService.ViewModels
{
    public class MealPacketListViewModel
    {
        public List<MealPacket> OriginalList { get; set; }
        public List<string> FilterOptions { get; set; }
    }
}
