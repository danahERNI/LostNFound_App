namespace LostNFound_App.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public string StaffName { get; set; }
        public List<Item> Items { get; set; }
        public int ItemId {  get; set; }
    }
}
