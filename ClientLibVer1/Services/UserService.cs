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

        public async Task<UserB> AddNewUser(string email, string password, UserStatus userstatus, UserRole userrole)
        {
            User newuser = new User();
            newuser.Email = email;
            newuser.Password = password;
            newuser.UserStatus = userstatus;
            newuser.UserRole = userrole;
            LibraryServiceHttpClient ClientLi = new LibraryServiceHttpClient(url, httpClient);
            await ClientLi.UsersAsync(newuser);
            UserB returnvalue = _mapper.Map<UserB>(newuser);
            return returnvalue;
        }
    }
}
