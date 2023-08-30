namespace Bangazonn.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StatusUpdateDate { get; set; }
    }
}
