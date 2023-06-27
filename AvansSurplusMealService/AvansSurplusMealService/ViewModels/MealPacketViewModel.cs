using Core.Domain.Domain;

namespace AvansSurplusMealService.ViewModels
{
    public class MealPacketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MealPacketProduct> ProductList { get; set; }
        public Cantine Cantine { get; set; }
        public double Price { get; set; }
        public string TypeMeal;
        public DateTime DateToReceive { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
