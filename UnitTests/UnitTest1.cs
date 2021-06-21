using System;
using Xunit;
using FirstResponsiveWebAppBoell.Models;

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
        [Fact]
        public void BadYear()
        {
            // Arrange
            DetermineAgeModel age = new DetermineAgeModel();
            age.BirthYear = 1700;
            int expected = 0;

            // Act
            int? actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void BadYear2()
        {
            // Arrange
            DetermineAgeModel age = new DetermineAgeModel();
            age.BirthYear = 2022;
            int expected = 0;

            // Act
            int? actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void PassingYear3()
        {
            // Arrange
            DetermineAgeModel age = new DetermineAgeModel();
            age.BirthYear = 2020;
            int expected = 1;

            // Act
            int? actual = age.AgeThisYear();

            // Assert
            Assert.Equal(actual, expected);

        }

    }
}
