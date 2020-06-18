using System.Collections.Generic;

namespace ClientLib.Models
{
    public class ClientLibViewModel
    {    
        public ItemViewModel[] Items { get; set; }
        public ICollection<ItemDTO> ItemCollection { get; set; }
        public ICollection<UserDTO> UserCollection { get; set; }
        public ICollection<RecordDTO> RecordCollection { get; set; }
    }
}
