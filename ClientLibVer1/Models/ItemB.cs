using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Models
{
   
    public class ItemB
    {
        public int ItemId { get; set; }
        public ItemType ItemType { get; set; }
        public ItemStatus ItemStatus { set; get; }
        public int OwnerId { get; set; }
    }
}
