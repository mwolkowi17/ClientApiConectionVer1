using AutoMapper;
using ClientLib.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientLib.Services
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

        public async Task<ICollection<RecordDTO>> GetAllRecords()
        {
            LibraryServiceHttpClient LibraryClient = new LibraryServiceHttpClient(url, httpClient);
            ICollection<Record> records = await LibraryClient.RecordsAllAsync();

            return _mapper.Map<ICollection<RecordDTO>>(records);
        }
        
        public async Task<RecordDTO> AddNewRecord (int itemid,int userid,RecordStatus recordstatus,DateTime datetime)
        {
            Record newRecord = new Record()
            {
                ItemId = itemid,
                UserId = userid,
                RecordStatus = recordstatus,
                DateTime = datetime
            };

            LibraryServiceHttpClient LibraryClient = new LibraryServiceHttpClient(url, httpClient);
            await LibraryClient.RecordsAsync(newRecord);

            return _mapper.Map<RecordDTO>(newRecord);
        }
    }
}
