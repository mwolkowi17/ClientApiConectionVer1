using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientLib.Services
{
    public interface IEveryItemService
    {
         Task<ICollection<Item>> GetAll();
    }
}
