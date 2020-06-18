namespace ClientLib.Models
{
    public class ItemDTO
    {
        public int ItemId { get; set; }
        public ItemType ItemType { get; set; }
        public ItemStatus ItemStatus { set; get; }
        public int OwnerId { get; set; }
    }
}
