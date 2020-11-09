using System;
using Xunit;
using HeroesLib; //add reference to HeroesLib using reference cmd

namespace HeroesTest
{
    public class HeroTest
    {

        Hero testHero = new Hero();

        // [Fact]
        [Theory] //fact works with single input. Use [theory] when working with multiple inputs to test
        [InlineData("Unit Testing God")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowersShouldAddSuperPower(string superPower)
        {
            //Arrange (arranging variables/artifacts that i might need in testing)
            // string superPower = "Unit Testing God";

            //Act (Do the thing you wanna test)
            testHero.AddSuperPowers(superPower);

            //Assert
            Assert.Equal(superPower, Hero.superPowers.Peek());

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowersShouldThrowArgumentException(string superPower) {

            //Catching exceptions in unit tests, act ad assert are in same
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPowers(superPower));
        }
    }
}
