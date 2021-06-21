using System;
using Xunit;
using FirstResponsiveWebAppBoell.Models;
using FirstResponsiveWebAppBoell.Controllers;
namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidYearTest()
        {
            // Arrange
            DetermineAgeModel age = new DetermineAgeModel();
            age.BirthYear = 1988;
            int expected = 33;

            // Act
            int? actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void PassingYearTest2()
        {
            // Arrange
            DetermineAgeModel age = new DetermineAgeModel();
            age.BirthYear = 2000;
            int expected = 21;

            // Act
            int? actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);

        }
  
    }
}
