using AutoMapper;
using ClientLibVer1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ClientLibVer1.Services
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

        public async Task<ICollection<ItemB>> GetAll()
        //public async Task<ItemViewModel[]> GetAll()
        {
            LibraryServiceHttpClient ClientLi = new LibraryServiceHttpClient(url, httpClient);
            ICollection<Item> kolekcja = await ClientLi.ItemsAllAsync();
            ICollection<ItemB> returnvalue = _mapper.Map<ICollection<ItemB>>(kolekcja);
            return returnvalue;
        }


    }
       
        
    
        
    
}
