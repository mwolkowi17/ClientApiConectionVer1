using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLibVer1.Models;
using ClientLibVer1.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientLibVer1.Controllers
{
    public class ItemListController : Controller
    {
        private readonly ItemService _ItemService;
        
        public ItemListController( ItemService itemService)
        {
            _ItemService = itemService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
           ICollection<ItemB> fordisplay = await _ItemService.GetAll();
            var model = new ClientLibViewModel()
            {
                Itemcolection = fordisplay
            };
            return View(model);
        }
    }
}
