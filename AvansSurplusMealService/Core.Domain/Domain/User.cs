using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string role { get; set; }
        public int NoShows { get; set; } = 0;

        //public List<Reservation> EigenReserveringen { get; set; }
        //Alternative to Reservation in between table
        public List<MealPacket> MealReservations { get; set; }
    }

    public class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkerId { get; set; }
        public string Email { get; set; }

        public string role { get; set; }

        public int cantineId { get; set; }
        public Cantine cantine { get; set; }
        

        //public List<Reservation> EigenReserveringen { get; set; }
    }
}
