namespace LostNFound_App.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Action { get; set; }
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
