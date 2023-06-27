using Core.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain
{
    public class MealPacket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string TypeMeal { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime PublishDate { get; } = DateTime.Now;
        //Meal status
        public bool Opgehaald { get; set; } = false;
        public DateTime? ReservationDate { get; private set; }
        public DateTime? OphalingsDatum { get; private set; }
        
        //One to many relation with Student
        public int? StudentClaimId { get; set; }
        public Student? StudentClaim { get; set; }

        public int CantineId { get; set; }
        public Cantine Cantine { get; set; }
        
        //Many to many
        public List<MealPacketProduct> ProductList { get; set; }
    }
}
