using AutoMapper;
using ClientLib.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientLib.Services
{
    public class ItemService
    {
        public static string url = "https://localhost:44384";
        public static HttpClient httpClient = new HttpClient();

        public IMapper _mapper;

        public ItemService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ICollection<ItemDTO>> GetAll()
        {
            LibraryServiceHttpClient libraryClient = new LibraryServiceHttpClient(url, httpClient);
            ICollection<Item> items = await libraryClient.ItemsAllAsync();

            return _mapper.Map<ICollection<ItemDTO>>(items);
        }

        public async Task<ItemDTO> AddNewItem(ItemType type, ItemStatus status, int owner)
        {
            Item newItem = new Item()
            {
                ItemType = type,
                ItemStatus = status,
                OwnerId = owner
            };

            LibraryServiceHttpClient LibraryClient = new LibraryServiceHttpClient(url, httpClient);
            await LibraryClient.ItemsAsync(newItem);

            return _mapper.Map<ItemDTO>(newItem);
        }
    }     
}
