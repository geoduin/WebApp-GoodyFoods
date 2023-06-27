using Core.Domain.Domain;
using Core.Domain.Domain.Enums;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * EntityFrameworkCore\ADD-MIGRATION -Context SurplusDatabaseContext
 * EntityFrameworkCore\UPDATE-DATABASE -Context SurplusDatabaseContext
 * 
 * EntityFrameworkCore\ADD-MIGRATION -Context SecurityDBContext
 * EntityFrameworkCore\UPDATE-DATABASE -Context SecurityDBContext
*/

namespace Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext
{
    public class SurplusDatabaseContext : DbContext
    {

        //Tabellen
        public DbSet<Student> Students { get; set; }

        public DbSet<Personel> Personels { get; set; }

        public DbSet<MealPacket> MealPackets { get; set; }

        public DbSet<Cantine> Cantines { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<MealPacketProduct> ProductList { get; set; }

        public SurplusDatabaseContext(DbContextOptions<SurplusDatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Filled Data
            //Cantines
            IEnumerable<Cantine> Cantines = new List<Cantine>()
            {
                new Cantine(){Id = 1, Location= "LD-Gebouw", City= "Breda", ServesWarmMeals = true, OtherInfo = "Niets"},
                new Cantine(){Id = 2, Location= "LA-Gebouw", City= "Breda", ServesWarmMeals = false, OtherInfo = "Is te vinden op de vijfde etage van het LA gebouw"},
            };
            
            IEnumerable<MealPacket> mealPackets = new List<MealPacket>()
            {
                new MealPacket(){ Id = 1, Name = "Zomerse Special", Price = 21.88, TypeMeal = "Gezond", DeadlineDate = DateTime.Now.AddDays(1),   CantineId = 1},
                new MealPacket(){Id = 2, Name = "Vleespakket", Price = 25.00, TypeMeal = "Vless", DeadlineDate = DateTime.Now.AddDays(2),  CantineId = 2, StudentClaimId = 1},
                new MealPacket(){ Id = 3, Name = "Vegapakket", Price = 12.99, TypeMeal = "Gezond", DeadlineDate = DateTime.Now.AddDays(2),   CantineId = 1},
                new MealPacket(){Id = 4, Name = "Sandwich pakket", Price = 10.00, TypeMeal = "Sandwiches", DeadlineDate = DateTime.Now.AddDays(3),  CantineId = 2},
                new MealPacket(){ Id = 5, Name = "Snackpakket", Price = 12.50, TypeMeal = "Snack", DeadlineDate = DateTime.Now.AddDays(4),  CantineId = 1},
                new MealPacket(){Id = 6, Name = "Hartige pakket", Price = 9.90, TypeMeal = "Snack", DeadlineDate = new DateTime(2022, 9, 1),  CantineId = 2},

            };
            IEnumerable<Student> students = new List<Student>() {
                new Student() { Id = 1, Name = "Dave", Email= "xin20wang@example.com", DateOfBirth = new DateTime(2001, 12, 12), role = "Student", StudentId = "200000"},
                new Student(){ Id = 2, Name = "Test", Email= "Test@example.com", DateOfBirth = new DateTime(2002, 11, 11), role = "Student", StudentId = "200001"},
                new Student(){Id = 3, Name = "Admin", Email = "Admin@example.com", DateOfBirth= new DateTime(1982, 11, 11), role = "Admin", StudentId = "0"}
            };

            IEnumerable<Personel> personel = new List<Personel>() { new Personel()
            { Id = 1, Name = "Admin", Email = "Admin@example.com", role = "Admin", WorkerId = "001", cantineId = 1}};

            //One to one relation between MealPacket and Reservations

            //One to many between mealpacket and cantine
            modelBuilder.Entity<MealPacket>()
                .HasOne(c => c.Cantine)
                .WithMany(mp => mp.MealList)
                .HasForeignKey(c => c.CantineId);

            modelBuilder.Entity<MealPacket>()
                .HasOne(c => c.StudentClaim)
                .WithMany(mp => mp.MealReservations)
                .HasForeignKey(c => c.StudentClaimId);

            //One to many personel and cantine
            modelBuilder.Entity<Cantine>()
                .HasMany(p => p.PersonelList)
                .WithOne(pl => pl.cantine)
                .HasForeignKey(p => p.cantineId);


            //Many to many between product and mealPacket
            modelBuilder.Entity<MealPacketProduct>()
                .HasKey(pc => new { pc.MealPacketId, pc.ProductId });
            
            modelBuilder.Entity<MealPacketProduct>()
                .HasOne(pl => pl.Product)
                .WithMany(p => p.ProductList)
                .HasForeignKey(pl => pl.ProductId);

            modelBuilder.Entity<MealPacketProduct>()
                .HasOne(pl => pl.MealPacket)
                .WithMany(mp => mp.ProductList)
                .HasForeignKey(pl => pl.MealPacketId);
            
            //Constraint that product cannot be added to mealpacket when the cantine does not offer warm meals
            
            //|FillData
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Cantine>().HasData(Cantines);
            modelBuilder.Entity<MealPacket>().HasData(mealPackets);
            modelBuilder.Entity<Personel>().HasData(personel);
        }
    }
}
