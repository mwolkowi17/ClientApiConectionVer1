using System.Collections.Generic;
using System.Threading.Tasks;
using ClientLib.Models;
using ClientLib.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientLib.Controllers
{
    public class ItemListController : Controller
    {
        private readonly ItemService _itemService;
        
        public ItemListController( ItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ICollection<ItemDTO> itemsDTOToDIsplay = await _itemService.GetAll();
            var model = new ClientLibViewModel()
            {
                ItemCollection = itemsDTOToDIsplay
            };
            
            return View(model);
        }

        public async Task<IActionResult> AddItem(Services.ItemType typeDTO, Services.ItemStatus statusDTO, int ownerDTO)
        {
            await _itemService.AddNewItem(typeDTO, statusDTO, ownerDTO);

            return RedirectToAction(nameof(Index));
        }
    }
}
