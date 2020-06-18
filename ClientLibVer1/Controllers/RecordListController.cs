using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientLib.Models;
using ClientLib.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientLib.Controllers
{
    public class RecordListController : Controller
    {
        private readonly RecordService _RecordService;

        public RecordListController( RecordService recordService)
        {
            _RecordService = recordService;
        }
        
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ICollection<RecordDTO> recordsToDisplay = await _RecordService.GetAllRecords();
            var model = new ClientLibViewModel()
            {
                RecordCollection = recordsToDisplay
            };
            
            return View(model);
        }

        public async Task<IActionResult> AddRecord(int itemidb, int useridb, Services.RecordStatus recordstatusb, DateTime datetimeb)
        {
            await _RecordService.AddNewRecord(itemidb, useridb, recordstatusb, datetimeb); 
            
            return RedirectToAction(nameof(Index));
        }
    }
}
