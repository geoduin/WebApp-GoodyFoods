using Core.DomainServices.Core.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.IF_Logic
{
    public class Roles: IRoleFactory
    {
        
        public Claim GetCharacterRole(string role)
        {
            return new Claim("CharacterRole", role);
        }

        public Claim GetAdminRole()
        {
            return GetCharacterRole("Admin");
        }

        public Claim GetPersonelRole()
        {
            return GetCharacterRole("Personel"); 
        }

        public Claim GetStudentRole()
        {
            return GetCharacterRole("Student");
        }

    }
}
