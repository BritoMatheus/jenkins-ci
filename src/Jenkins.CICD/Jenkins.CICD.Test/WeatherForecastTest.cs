namespace Jenkins.CICD.Test
{
    public class WeatherForecastTests
    {
        [Fact]
        public void TemperatureF_ReturnsCorrectValue()
        {
            // Arrange
            var forecast = new WeatherForecast { TemperatureC = 25 };

            // Act
            int temperatureF = forecast.TemperatureF;

            // Assert
            Assert.Equal(76, temperatureF);
        }

        [Fact]
        public void TemperatureF_RoundsDownWhenTemperatureCIsNegative()
        {
            // Arrange
            var forecast = new WeatherForecast { TemperatureC = -15 };

            // Act
            int temperatureF = forecast.TemperatureF;

            // Assert
            Assert.Equal(6, temperatureF);
        }

        [Fact]
        public void TemperatureF_RoundsUpWhenTemperatureCHasDecimalPart()
        {
            // Arrange
            var forecast = new WeatherForecast { TemperatureC = 30 };

            // Act
            int temperatureF = forecast.TemperatureF;

            // Assert
            Assert.Equal(85, temperatureF);
        }
    }
}
