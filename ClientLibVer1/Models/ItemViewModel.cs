using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Models
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
