using Core.Domain.Domain;

namespace AvansSurplusMealService.ViewModels
{
    public class HomeViewModel
    {
        public string? Email { get; set; }
        public List<MealPacket>? MealPackets { get; set; }
        public List<Cantine>? Cantines { get; set; }
        public Student student { get; set; }
    }
}
