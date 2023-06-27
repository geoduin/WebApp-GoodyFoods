using Core.Domain.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool WarmMeal { get; set; }
        public bool Alcoholic { get; set; }
        //String
        public string? Base64Image { get; set; }

        public List<MealPacketProduct> ProductList { get; set; }
    }
}
