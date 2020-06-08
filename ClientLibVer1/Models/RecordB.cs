using ClientLibVer1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Models
{
    public class RecordB
    {
        public int RecordId { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public DateTime DateTimeB { get; set; }
    }
}
