using AutoMapper;
using ClientLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientLib.Services
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

        public async Task<ICollection<UserDTO>> GetAllUsers()
        {
            LibraryServiceHttpClient libraryClient = new LibraryServiceHttpClient(url,httpClient);
            ICollection<User> users = await libraryClient.UsersAllAsync();
  
            return _mapper.Map<ICollection<UserDTO>>(users);
        }

        public async Task<UserDTO> AddNewUser(string email, string password, UserStatus userstatus, UserRole userrole)
        {
            User newUser = new User() 
            {
                Email = email,
                Password = password,
                UserStatus = userstatus,
                UserRole = userrole
            };

            LibraryServiceHttpClient libraryClient = new LibraryServiceHttpClient(url, httpClient);
            await libraryClient.UsersAsync(newUser);

            return _mapper.Map<UserDTO>(newUser);
        }
    }
}
