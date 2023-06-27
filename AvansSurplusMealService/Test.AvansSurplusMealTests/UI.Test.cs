using AvansSurplusMealService.Controllers;
using AvansSurplusMealService.ViewModels;
using Core.Domain.Domain;
using Core.DomainServices.Core.DomainService.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Impl.DServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Security.Claims;
using System.Xml.Linq;

namespace Test.AvansSurplusMealTests
{
    public class UnitTest1
    {
        //| UC-1 | 
        //@Will be able to see a list of mealpackets
        //@Will be able to see own reserved mealpackets

        //Test UI-Meallist with meals available for reservation
        [Fact]
        public void TestIfMealListPageGivesBackView()
        {
            //Arrange

            var MockInterface = new Mock<IMealPacketRepo>();
            var MealListController = new MealBoxListController(MockInterface.Object);
            MockInterface.Setup(mock => mock.GetAllPacketsDB()).Returns(new List<MealPacket>()
            {
                new MealPacket(){Id = 16, Name = "Test", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 12),  CantineId = 2},
                new MealPacket(){Id = 17, Name = "Test2", Price = 9.90, TypeMeal = "TestType2", DeadlineDate = new DateTime(2023, 12, 9),  CantineId = 2}
            });
            //Act
            var result = MealListController.MealboxList();

            //Assert
            var MealList = result.Model as MealPacketListViewModel;
            Assert.Equal(2, MealList.OriginalList.Count);
            //List in order
            Assert.Equal(17, MealList.OriginalList[0].Id);
            Assert.Equal(16, MealList.OriginalList[1].Id);
        }

        //Test if own reservation list will give back mealpackets of his own.
        [Fact]
        public void TestIfControllerReturnsWithList()
        {
            //Arrange
            var MockIntf = new Mock<IStudentRepo>();
            var ProfileController = new ProfileController(MockIntf.Object);
            var EmailAddress = "Test@Example.com";
            Student student = new Student()
            {
                MealReservations = new List<MealPacket> {
                        new MealPacket(){Id = 2, Name = "Reserved packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 8),  CantineId = 2},
                        new MealPacket(){Id = 3, Name = "Future packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 9),  CantineId = 2}
                    },
                Name = "Test",
                Email = "Test@Example.com"
            };
            MockIntf.Setup(sr => sr.GetUserByEmail(EmailAddress))
                .Returns(student);

            //Act
            var result = ProfileController.ProfileReservations(EmailAddress);

            //Assert
            var StudentViewModel = result.Model as ProfileViewModel;

            Assert.Equal("Reserved packet", StudentViewModel.student.MealReservations[0].Name);
            Assert.Equal(2, StudentViewModel.student.MealReservations.Count);
        }


        //|UC-2 |
        //Cantine workers will see a list of Mealpackets
        [Fact]
        public void TestIfControllerWillReceiveMealsOfOwnCantine()
        {
            //Arrange
            var MockMealRepoIntf = new Mock<IMealPacketRepo>();
            var MockUserRepo = new Mock<IPersonelRepo>();
            var MockCantines = new Mock<ICantineRepo>();

            var Controller = new ContentManagementController(MockMealRepoIntf.Object, MockUserRepo.Object, MockCantines.Object);

            MockMealRepoIntf.Setup(m => m.GetAllPacketsPerCantine(1)).Returns(new List<MealPacket> {
                        new MealPacket(){Id = 2, Name = "Reserved packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 8)},
                        new MealPacket(){Id = 3, Name = "Future packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 7)}
                    });
            MockUserRepo.Setup(m => m.GetUserByEmail("Mock@example.com")).Returns(new Personel() { Id = 1, Email = "Mock@example.com", Name = "Gerard", role = "Personel", cantine = new Cantine() { Id = 1, City = "Breda", Location = "Hogeschoollaan", ServesWarmMeals = true } });
            MockCantines.Setup(CA => CA.GetAllCantines()).Returns(new List<Cantine> { new Cantine() { Id = 1, City = "Breda", Location = "Hogeschoollaan", ServesWarmMeals = true } });
            IEnumerable<ClaimsIdentity> claimsIdentities = new List<ClaimsIdentity>();
            ClaimsIdentity id = new ClaimsIdentity();
            id.AddClaim(new Claim("Mock", "MockValue"));
            id.AddClaim(new Claim("Mock", "MockValue"));
            id.AddClaim(new Claim("Email", "Mock@example.com"));

            ClaimsPrincipal MockUser = new(id);
            
            Controller._User = MockUser;
            //Act
            var result = Controller.MealPacketManagement();

            //Assert
            var ViewModel = result.Model as MealPacketManageVM;

            Assert.Equal(2, ViewModel.CurrentList.Count);
            Assert.Equal(3, ViewModel.CurrentList[0].Id);
            Assert.Equal(2, ViewModel.CurrentList[1].Id);
        }

        //Tests if controller gives back a view with that specific cantine

        [Fact]
        public void TestIfControllerGivesCantineOfCertainId()
        {
            //Arrange
            var MockMealRepoIntf = new Mock<IMealPacketRepo>();
            var MockUserRepo = new Mock<IPersonelRepo>();
            var MockCantines = new Mock<ICantineRepo>();

            var Controller = new ContentManagementController(MockMealRepoIntf.Object, MockUserRepo.Object, MockCantines.Object);

            MockMealRepoIntf.Setup(m => m.GetAllPacketsPerCantine(2)).Returns(new List<MealPacket> {
                        new MealPacket(){Id = 2, Name = "Reserved packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 8), CantineId = 2},
                        new MealPacket(){Id = 3, Name = "Future packet", Price = 9.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2023, 12, 7), CantineId = 2}
                    });
            MockCantines.Setup(CA => CA.GetAllCantines()).Returns(new List<Cantine> { new Cantine() { Id = 1, City = "Breda", Location = "Hogeschoollaan", ServesWarmMeals = true }, new Cantine() { Id = 2, City = "Breda", Location = "Hogeschoollaan", ServesWarmMeals = true } });

            //Act
            var result = Controller.MealPacketManagementChoice(2);

            //Assert
            var ViewModel = result.Model as MealPacketManageVM;

            Assert.Equal(2, ViewModel.CurrentList.Count);
            Assert.Equal(3, ViewModel.CurrentList[0].Id);
            Assert.Equal(2, ViewModel.CurrentList[1].Id);
        }
    }
}