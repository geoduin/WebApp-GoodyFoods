using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain.Unused
{
    public class Reservation
    {
        public int Id { get; set; }

        public bool Opgehaald { get; set; } = false;
        public DateTime ReserveDate { get; set; }
        public DateTime OphalingsDatum { get; set; }

        //One to many
        public Student ReservedStudent { get; set; }

        //One to one relation
        public int MealPacketId { get; set; }
        public MealPacket ReservedMeal { get; set; }
    }
}
