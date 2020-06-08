using ClientLibVer1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Models
{
    public class ClientLibViewModel
    {
        
        public ItemViewModel[] Items { get; set; }
        public ICollection<ItemB> Itemcolection { get; set; }
        public ICollection<UserB> Usercolection { get; set; }
        public ICollection<RecordB> Recordcolection { get; set; }
    }
}
