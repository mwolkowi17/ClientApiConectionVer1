using AutoMapper;
using ClientLib.Models;
using ClientLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLib
{
    public class Mappingprofile: Profile
    {
        public Mappingprofile()
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<User, UserDTO>();
            CreateMap <Record, RecordDTO>();
        }
    }
}
