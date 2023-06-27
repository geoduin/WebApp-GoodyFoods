using AvansSurplusMealService.ViewModels;
using Core.DomainServices.Core.DomainService.Intf;
using Core.DomainServices.Core.Intf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AvansSurplusMealService.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPersonelRepo personelRepo;
        private readonly IRoleFactory roleMaker;

        public IStudentRepo StudentRepo { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public IDomainFactory DomainFactory { get; }

        public AccountController(
            IPersonelRepo personelRepo, 
            IStudentRepo studentRepo,
            UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager, 
            IRoleFactory RoleMaker,
            IDomainFactory domainFactory)
        {
            this.personelRepo = personelRepo;
            StudentRepo = studentRepo;
            UserManager = userManager;
            SignInManager = signInManager;
            roleMaker = RoleMaker;
            DomainFactory = domainFactory;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginViewModel model)
        {
            Console.WriteLine("User is ingelogd");
            //Betrekt identity framework
            if(model != null)
            {
                var result = await UserManager.FindByNameAsync(model.UserName);
                if(result != null)
                {
                    var SigninResult = await SignInManager.PasswordSignInAsync(result, model.Password, true, false);
                    if (SigninResult.Succeeded)
                    {
                        //Keys cookies
                        string EmailKey = "Email";

                        //Configuration Cookie
                        CookieOptions option = new CookieOptions();
                        option.Expires = DateTime.Now.AddDays(14);
                        option.MaxAge = TimeSpan.FromDays(14);
                        //Create cookie
                        Response.Cookies.Append(EmailKey, result.Email);

                        return RedirectToAction(controllerName: "Home", actionName: "StartPagina");
                    }
                }
            }
            //Returns to homepage
            return RedirectToAction(controllerName: "Home", actionName: "StartPagina");
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistrationPersonel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationUser(RegistrationViewModel registration)
        {
            //Als registratie volgens de modelstate voldoet, dan zal er op inputvalidatie gecontroleert worden
            Console.WriteLine(registration.Name);
            var NewUser = new IdentityUser()
            {
                UserName = registration.Name,
                Email = registration.Email,
            };

            var result = await UserManager.CreateAsync(NewUser, registration.Password);
            if (result.Succeeded)
            {

                await UserManager.AddClaimAsync(NewUser, roleMaker.GetCharacterRole("Student"));
                //Needs to add user to normal database
                var Student = DomainFactory.CreateBaseStudent(registration.Name, registration.Email, registration.DateOfBirth, "Student");
                StudentRepo.CreateUser(Student);

                return RedirectToAction(controllerName: "Account", actionName: "Login");
            }
            //Stuurt registratie naar domein database en gevoelige gegevens naar de idendity database.
            return View("Registration");
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationPersonel(RegistrationPersonelVM registration)
        {
            var Cantine = registration.Cantines[registration.Choice];
            var NewPersonel = new IdentityUser()
            {
                UserName = registration.PersonelName,
                Email = registration.Email,
            };

            var result = await UserManager.CreateAsync(NewPersonel, registration.Password);
            if (result.Succeeded)
            {
                await UserManager.AddClaimAsync(NewPersonel, roleMaker.GetCharacterRole("Personel"));
                var Personel = DomainFactory.CreatePersonel(registration.PersonelName, registration.Email, registration.DateOfBirth, "Personel", Cantine);
                personelRepo.CreateUser(Personel);
                return RedirectToAction(controllerName: "AccountController", actionName: "Login");
            }

            return RedirectToAction(controllerName: "AccountController", actionName: "RegistrationPersonel");
        }

        public async Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
    }
}
