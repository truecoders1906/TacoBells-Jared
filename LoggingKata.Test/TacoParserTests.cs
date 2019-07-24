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
        [InlineData("32.571331,-85.499655,Taco Bell Auburn", "Taco Bell Auburn", 32.571331, -85.499655)]
        [InlineData("33.59453,-86.694742,Taco Bell Birmingham", "Taco Bell Birmingham", 33.59453, -86.694742)]
        
        public void ShouldParse(string str, string expectedname, double expectedlatitude, double expectedlongitude)
        {
            // TODO: Complete Should Parse

            // Arrange
            TacoParser tacoparse = new TacoParser();
            Point expectedtacolocation = new Point(expectedlatitude, expectedlongitude);
            
            // Act
            ITrackable actual =  tacoparse.Parse(str);

            // Assert
            Assert.Equal(expectedname, actual.Name);
            Assert.Equal(expectedtacolocation.Latitude, actual.Location.Latitude);
            Assert.Equal(expectedtacolocation.Longitude, actual.Location.Longitude);
            
        }

        [Theory]
        [InlineData("32.571331,-85.499655Taco Bell Auburn")]
        [InlineData("42424242, sifjsifsi Taco Time")]
        [InlineData("32.571331, Cheddar , Taco Bell Auburn")]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse

            // Arrange
            TacoParser badtacoparse = new TacoParser();
            
            // Act
             ITrackable actual = badtacoparse.Parse(str);

            // Assert
            Assert.Null(actual);
            
        }
    }
}
