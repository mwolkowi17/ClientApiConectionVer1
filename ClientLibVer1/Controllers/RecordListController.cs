﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibVer1.Models;
using ClientLibVer1.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientLibVer1.Controllers
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
            ICollection<RecordB> fordisplay = await _RecordService.GetAllUsers();
            var model = new ClientLibViewModel()
            {
                Recordcolection = fordisplay
            };
            return View(model);
        }
    }
}
