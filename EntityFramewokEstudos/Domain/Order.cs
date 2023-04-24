using EntityFramewokEstudos.ValueObjects;

namespace EntityFramewokEstudos.Domain
{
    internal class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public FreightType FreightType { get; set; }
        public StatusOrder StatusOrder { get; set; }
        public string Observation { get; set; }
        public ICollection<OrderItem> Items { get; set; }
    }
}
