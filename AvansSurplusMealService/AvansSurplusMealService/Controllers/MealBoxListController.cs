using AvansSurplusMealService.ViewModels;
using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Core.DomainServices.ExtensieMethods;
using Microsoft.AspNetCore.Mvc;


namespace AvansSurplusMealService.Controllers
{
    public class MealBoxListController : Controller
    {
        private readonly IMealPacketRepo _mealPacketRepo;

        public MealBoxListController(IMealPacketRepo mealPacketRepo)
        {
            _mealPacketRepo = mealPacketRepo;
        }

        [HttpGet]
        public ViewResult MealboxList() {
            MealPacketListViewModel ViewModel = new MealPacketListViewModel();
            ViewModel.OriginalList = _mealPacketRepo
                .GetAllPacketsDB()
                .GetAvailableMeal()
                .OrderBy(mp => mp.DeadlineDate)
                .ToList();

            return View(ViewModel);
        } 
    }
}
