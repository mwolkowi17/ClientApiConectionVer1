using System.Collections.Generic;
using System.Threading.Tasks;
using ClientLib.Models;
using ClientLib.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientLib.Controllers
{
    public class UserListController : Controller
    {
        private readonly UserService _userService;

        public UserListController(UserService userService)
        {
            _userService = userService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ICollection<UserDTO> usersToDisplay = await _userService.GetAllUsers();
            var model = new ClientLibViewModel()
            {
                UserCollection = usersToDisplay
            };
            
            return View(model);
        }

        public async Task<IActionResult> AddUser(string emalilb, string passwordb, Services.UserStatus userstatusb, Services.UserRole userroleb)
        {
            await _userService.AddNewUser(emalilb, passwordb, userstatusb, userroleb);

            return RedirectToAction(nameof(Index));
        }
    }
}
