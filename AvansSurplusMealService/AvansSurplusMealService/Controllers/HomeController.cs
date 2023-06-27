using AvansSurplusMealService.ViewModels;
using Core.DomainServices.Core.DomainService.Intf;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AvansSurplusMealService.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IMealPacketRepo mealPacketRepo;
        private readonly IStudentRepo studentRepo;

        public HomeController(
            UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            IMealPacketRepo mealPacketRepo,
            IStudentRepo studentRepo)
        {
            _userManager = userManager;
            this.signInManager = signInManager;
            this.mealPacketRepo = mealPacketRepo;
        }

        public IActionResult StartPagina()
        {
            //read cookie from Request object  
            //Cookie config
            var user = signInManager.Context.User.Claims.ToList();
            Console.WriteLine(user);
            if(user.Count > 0)
            {
                //Iets doen met account gegevens
            }
            //Haal meest recente maaltijden op
            var LatestMealPackets = mealPacketRepo.GetAllPacketsDB();

            LatestMealPackets = LatestMealPackets.Take(4).ToList();
            /*var ReservationsUser = studentRepo.GetUserByEmail("");
            var Personel = personelRepo.GetUserByEmail("");
            var Cantines = cantineRepo.GetAllCantines();*/

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                MealPackets = LatestMealPackets,
                Email = null,
                Cantines = null,
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}