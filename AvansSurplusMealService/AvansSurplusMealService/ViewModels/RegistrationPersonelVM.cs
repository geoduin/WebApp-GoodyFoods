using Core.Domain.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AvansSurplusMealService.ViewModels
{
    public class RegistrationPersonelVM
    {
        public string WorkerId { get; set; }
        public string PersonelName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }
        public int Choice { get; set; }
        public List<Cantine> Cantines { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
    }
}
