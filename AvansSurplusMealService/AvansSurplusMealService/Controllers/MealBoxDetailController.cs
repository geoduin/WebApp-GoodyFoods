using AvansSurplusMealService.ViewModels;
using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.IF_Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AvansSurplusMealService.Controllers
{
    public class MealBoxDetailController : Controller
    {
        private readonly IMealPacketRepo mealPacketRepo;

        public MealBoxDetailController(IMealPacketRepo MealRepo)
        {
            this.mealPacketRepo = MealRepo;
        }

        //Op basis van maaltijdpakket ID.
        [Authorize]
        public IActionResult MealPacketDetail(int id)
        {
            var meal = mealPacketRepo.GetPacketById(id);

            MealPacketViewModel view = new MealPacketViewModel()
            {
            Id = id,
            Name = meal.Name,
            Cantine = meal.Cantine,
            TypeMeal = meal.TypeMeal,
            Price = meal.Price,
            ProductList = meal.ProductList,
            PublishDate = meal.PublishDate,
            DateToReceive = meal.DeadlineDate
            };

            return View(view);
        }
    }
}
