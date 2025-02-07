namespace LostNFound_App.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status {  get; set; }
        public int ItemCategoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        //public ItemCategory ItemCategory {  get; set; }
    }
}
