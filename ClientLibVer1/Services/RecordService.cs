using AutoMapper;
using ClientLibVer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientLibVer1.Services
{
    public class RecordService
    {
        public static string url = "https://localhost:44384";
        public static HttpClient httpClient = new HttpClient();

        public IMapper _mapper;

        public RecordService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ICollection<RecordB>> GetAllUsers()
        {
            LibraryServiceHttpClient ClientLi = new LibraryServiceHttpClient(url, httpClient);
            ICollection<Record> recordcolection = await ClientLi.RecordsAllAsync();
            ICollection<RecordB> returnvalue = _mapper.Map<ICollection<RecordB>>(recordcolection);
            return returnvalue;
        }
        
    }
}
