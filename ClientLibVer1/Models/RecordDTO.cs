using ClientLib.Services;
using System;

namespace ClientLib.Models
{
    public class RecordDTO
    {
        public int RecordId { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public DateTime DateTime { get; set; }
    }
}
