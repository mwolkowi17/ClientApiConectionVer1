using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Services
{
    public interface IEvertyItemService
    {
         Task<ICollection<Item>> GetAll();
    }
}
