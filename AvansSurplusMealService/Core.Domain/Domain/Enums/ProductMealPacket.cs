using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain.Enums
{
    public class ProductMealPacket
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int MealPacketId { get; set; }
        public MealPacket MealPacket { get; set; }
    }
}
