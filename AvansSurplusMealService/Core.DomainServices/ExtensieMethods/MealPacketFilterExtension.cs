using Core.Domain.Domain;

namespace Core.DomainServices.ExtensieMethods
{
    public static class MealPacketFilterExtension
    {

        public static IEnumerable<MealPacket> GetAvailableMeal(this List<MealPacket> list)
        {
            foreach (var packet in list)
            {
                //If receive date of packet is equal or lower than today, it will give back a element
                if (packet.DeadlineDate > DateTime.Now && packet.StudentClaim == null)
                {
                    yield return packet;
                }
            }
        }

        public static IEnumerable<MealPacket> GetReservedMeals(this List<MealPacket> list)
        {
            foreach (var packet in list)
            {
                if (packet.StudentClaim != null)
                {
                    yield return packet;
                }
            }
        }
    }
}
