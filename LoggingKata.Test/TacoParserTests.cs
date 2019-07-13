using System;
using Xunit;
using LoggingKata;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // Arrange


            // Act
            

            // Assert
        }

        [Theory]
        [InlineData("Example")]
        
        [InlineData("33.59453,-86.694742,Taco Bell Birmingham", "Taco Bell Birmingham", 33.59453, -86.694742)]
        public void ShouldParse(string str, string expectedname, double expectedlongitude, double expectedlatitude)
        {
            // TODO: Complete Should Parse

            // Arrange
            TacoParser tacoparse = new TacoParser();
            TacoBell taco = new TacoBell();
            Point expectedtacolocation = new Point(expectedlongitude, expectedlatitude);
            // Act
            tacoparse.Parse(str);

            // Assert
            Assert.Equal(expectedname, taco.Name);
            Assert.Equal(expectedtacolocation, taco.Location);
            
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse

            // Arrange
            TacoParser badtacoparse = new TacoParser();

            // Act


            // Assert
        }
    }
}
