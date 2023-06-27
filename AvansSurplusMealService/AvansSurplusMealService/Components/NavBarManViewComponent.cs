using AvansSurplusMealService.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AvansSurplusMealService.Components
{
    public class NavBarManViewComponent : ViewComponent
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public NavBarManViewComponent(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Cookie config
            var user = signInManager.Context.User.Claims.ToList();
            string? email = null;
            string? role = null;
            if (user.Count > 0)
            {
                email = user[2].Value;
                role = user[4].Value;
            }

            NavBarVM dropVM = new NavBarVM()
            {
                Email = email,
                Role = role,
            };
            //Create cookie

            return View(dropVM);
        }
    }
}
