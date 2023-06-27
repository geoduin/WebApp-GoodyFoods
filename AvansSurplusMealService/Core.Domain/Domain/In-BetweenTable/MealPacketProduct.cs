namespace Core.Domain.Domain
{
    public class MealPacketProduct
    {

        public int MealPacketId { get; set; }
        public MealPacket MealPacket { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
