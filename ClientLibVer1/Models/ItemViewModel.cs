namespace ClientLib.Models
{
    public enum ItemStatus
    {
        Zarezerwowany,
        Wypożyczony,
        Dostępny
    }

    public enum ItemType
    {
        Book,
        AudioCD,
        DVD
    }
    
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public ItemType ItemType { get; set; }
        public ItemStatus ItemStatus { set; get; }
        public int OwnerId { get; set; }
    }
}
