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
    public class UserListController : Controller
    {
        private readonly UserService _UserService;

        public UserListController(UserService userService)
        {
            _UserService = userService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ICollection<UserB> userfordisplay = await _UserService.GetAllUsers();
            var model = new ClientLibViewModel()
            {
                Usercolection = userfordisplay
            };
            return View(model);
        }
    }
}
