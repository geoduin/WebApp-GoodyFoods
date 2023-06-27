using Core.Domain.Domain;
using Core.DomainServices.ExtensieMethods;
using Xunit;

namespace Test.Infra.EF_Data
{
    public class ExtensionMethodTest
    {
        //Tests if meals are sorted from old to new
        [Fact]
        public void TestIfListIsFilledWithReservedMeals()
        {
            //Arrange
            List<MealPacket> packets = new List<MealPacket>()
            {
                new MealPacket(){Id = 1, Name = "Test", Price = 9.90, TypeMeal = "TestType", DeadlineDate = DateTime.Now.AddDays(1),  CantineId = 2, StudentClaim = new Student() { Id = 1, Email = "Student@Example.com", StudentId= "1128892" }},
                new MealPacket(){Id = 2, Name = "Test2", Price = 19.90, TypeMeal = "TestType2", DeadlineDate =  DateTime.Now.AddDays(5),  CantineId = 2},
                new MealPacket(){Id = 3, Name = "Test3", Price = 19.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2021, 12, 25),  CantineId = 2, StudentClaim = new Student() { Id = 1, Email = "Student@Example.com", StudentId= "1128892" } },
                new MealPacket(){Id = 4, Name = "Test4", Price = 9.90, TypeMeal = "TestType2", DeadlineDate = new DateTime(2021, 11, 25),  CantineId = 2},
                new MealPacket(){Id = 5, Name = "Test5", Price = 29.90, TypeMeal = "TestType", DeadlineDate = DateTime.Now.AddDays(6),  CantineId = 2},
                new MealPacket(){Id = 6, Name = "Test6", Price = 39.90, TypeMeal = "TestType2", DeadlineDate = DateTime.Now.AddDays(3),  CantineId = 2}
            };
            //Act
            var result = packets.GetReservedMeals();
            //Assert
            Assert.Equal(2, result.Count());
        }

        //Tests if method gives only mealpackets not reserved
        [Fact]
        public void TestIfListHasGivesMealsWithoutReservations()
        {
            //Arrange
            List<MealPacket> packets = new List<MealPacket>()
            {
                new MealPacket(){Id = 1, Name = "Test", Price = 9.90, TypeMeal = "TestType", DeadlineDate = DateTime.Now.AddDays(1),  CantineId = 2, StudentClaim = new Student() { Id = 1, Email = "Student@Example.com", StudentId= "1128892" }},
                new MealPacket(){Id = 2, Name = "Test2", Price = 19.90, TypeMeal = "TestType2", DeadlineDate =  DateTime.Now.AddDays(5),  CantineId = 2},
                new MealPacket(){Id = 3, Name = "Test3", Price = 19.90, TypeMeal = "TestType", DeadlineDate = new DateTime(2021, 12, 25),  CantineId = 2, StudentClaim = new Student() { Id = 1, Email = "Student@Example.com", StudentId= "1128892" } },
                new MealPacket(){Id = 4, Name = "Test4", Price = 9.90, TypeMeal = "TestType2", DeadlineDate = new DateTime(2021, 11, 25),  CantineId = 2},
                new MealPacket(){Id = 5, Name = "Test5", Price = 29.90, TypeMeal = "TestType", DeadlineDate = DateTime.Now.AddDays(6),  CantineId = 2},
                new MealPacket(){Id = 6, Name = "Test6", Price = 39.90, TypeMeal = "TestType2", DeadlineDate = DateTime.Now.AddDays(3),  CantineId = 2}
            };
            //Act
            var result = packets.GetAvailableMeal().ToList();
            //Assert
            Assert.Equal(3, result.Count);
        }

    }
}