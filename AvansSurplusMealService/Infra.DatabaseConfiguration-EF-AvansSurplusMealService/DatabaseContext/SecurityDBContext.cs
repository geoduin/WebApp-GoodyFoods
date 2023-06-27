using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext
{
    public class SecurityDBContext : IdentityDbContext
    {
        public static string Password = "Min DaMin2@?";
        public static string Role = "Admin";
        public SecurityDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityUser Admin = new IdentityUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                Email = "Admin@example.com",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            Admin.PasswordHash = passwordHasher.HashPassword(Admin, Password);
            
            builder.Entity<IdentityUser>().HasData(Admin);

            builder.Entity<IdentityUserClaim<string>>().HasData(new IdentityUserClaim<string>()
            {
                Id = 1,
                UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                ClaimType = "CharacterRole",
                ClaimValue = Role
            });

        }
    }
}
