using Core.Domain.Domain;

namespace AvansSurplusMealService.ViewModels
{
    public class OwnReservationVM
    {
        public int UserId { get; set; }
        public List<MealPacket> OwnList { get; set; }
    }
}
