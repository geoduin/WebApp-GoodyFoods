using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain
{
    public class Cantine
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public bool ServesWarmMeals { get; set; }
        public string? OtherInfo { get; set; }

        public List<MealPacket> MealList { get; set; }
        public List<Personel> PersonelList { get; set; }
    }
}
