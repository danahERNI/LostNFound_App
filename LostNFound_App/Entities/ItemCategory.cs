namespace LostNFound_App.Entities
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Item? Item { get; set; }
    }
}
