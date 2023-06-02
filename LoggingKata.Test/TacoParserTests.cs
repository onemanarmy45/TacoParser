using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
           //Arrange

            var tacoParserInstance = new TacoParser();

            //Act

            var actual = tacoParserInstance.Parse(line).Location.Longitude;

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange

            var tacoParserInstance = new TacoParser();

            //Act

            var actual = tacoParserInstance.Parse(line).Location.Latitude;

            //Assert

            Assert.Equal(expected, actual);
        }

    }
}