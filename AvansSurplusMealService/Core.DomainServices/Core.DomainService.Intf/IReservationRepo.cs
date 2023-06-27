using Core.Domain.Domain.Unused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface IReservationRepo
    {
        List<Reservation> GetAllReservations();
        List<Reservation> GetReservationOfUser(int UserId);
        Reservation GetReservationByUserId(int UserId);
        Reservation GetReservationByIds(int UserId, string MealId);

        void UpdateReservation(Reservation reservation);
        void DeleteReservation(Reservation reservation);

    }
}
