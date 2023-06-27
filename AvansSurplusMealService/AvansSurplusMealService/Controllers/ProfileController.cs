using AvansSurplusMealService.ViewModels;
using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Microsoft.AspNetCore.Mvc;


namespace AvansSurplusMealService.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IStudentRepo studentRepo;

        public ProfileController(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public ViewResult ProfileReservations(string id)
        {
            string email = id;
            var Student = studentRepo.GetUserByEmail(email);
            
           
            ProfileViewModel VM = new ProfileViewModel() { student = Student };
            return View(VM);
        }
    }
}
