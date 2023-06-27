using AvansSurplusMealService.ViewModels;
using Core.DomainServices.Core.DomainService.Intf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Security.Claims;

namespace AvansSurplusMealService.Controllers
{
    public class ContentManagementController : Controller
    {
        private readonly IMealPacketRepo mealPacketRepo;
        private readonly ICantineRepo cantineRepo;

        public IPersonelRepo Repo { get; }
        public ClaimsPrincipal _User { get; set; }

        public ContentManagementController(IMealPacketRepo mealPacketRepo, IPersonelRepo repo, ICantineRepo cantineRepo)
        {
            this.mealPacketRepo = mealPacketRepo;
            Repo = repo;
            this.cantineRepo = cantineRepo;
        }

        [Authorize]
        public IActionResult ContentManager()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ViewResult MealPacketManagement()
        {
            if(this.User != null)
            {
                _User = this.User;
            }
            var email = _User.Claims.ToArray()[2].Value;
            //Retrieve email from personel by checking claims
            var User = Repo.GetUserByEmail(email);

            //Based on the user base cantine, it will retrieve Mealpackets based on Ids
            var ListOfMeals = mealPacketRepo.GetAllPacketsPerCantine(User.cantine.Id);
            var CanteenList = cantineRepo.GetAllCantines();
            //Puts them in a ViewModel
            MealPacketManageVM Vm = new MealPacketManageVM()
            {
                CurrentList = ListOfMeals.OrderByDescending(d => d.PublishDate).ToList(),
                CantineList = CanteenList,
                City = User.cantine.City,
                Location = User.cantine.Location
            };

            return View(Vm);
        }

        [Authorize]
        public ViewResult MealPacketManagementChoice(int id)
        {
            int CantineId = id;
            //Based on the user base cantine, it will retrieve Mealpackets based on Ids
            var ListOfMeals = mealPacketRepo.GetAllPacketsPerCantine(CantineId);
            var CanteenList = cantineRepo.GetAllCantines();
            //Puts them in a ViewModel
            MealPacketManageVM Vm = new MealPacketManageVM()
            {
                CurrentList = ListOfMeals.OrderByDescending(d => d.PublishDate).ToList(),
                CantineList = CanteenList,
                CurrentCanteen = CanteenList.Where(c => c.Id == CantineId).First(),
            };

            return View("MealPacketManagement", Vm);
        }
    }
}
