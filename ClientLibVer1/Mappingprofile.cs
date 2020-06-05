using AutoMapper;
using ClientLibVer1.Models;
using ClientLibVer1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1
{
    public class Mappingprofile: Profile
    {
        public Mappingprofile()
        {
            CreateMap<Item, ItemB>();
        }
    }
}
