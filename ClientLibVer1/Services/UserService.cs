using AutoMapper;
using ClientLibVer1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientLibVer1.Services
{
    public class UserService
    {
        public static string url = "https://localhost:44384";
        public static HttpClient httpClient = new HttpClient();

        public IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ICollection<UserB>> GetAllUsers()
        {
            LibraryServiceHttpClient ClientLi = new LibraryServiceHttpClient(url,httpClient);
            ICollection<User> usercolection = await ClientLi.UsersAllAsync();
            ICollection<UserB> returnvalue = _mapper.Map<ICollection<UserB>>(usercolection);
            return returnvalue;
        }
    }
}
