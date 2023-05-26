using Jenkins.CICD.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins.CICD.Test.Controllers
{
    public class WeatherForecastControllerTest
    {
        //private WeatherForecastController _controller;
        //private Mock<ILogger<WeatherForecastController>> _loggerMock;


        //public WeatherForecastControllerTest()
        //{
        //    _loggerMock = new Mock<ILogger<WeatherForecastController>>();
        //    _controller = new WeatherForecastController(_loggerMock.Object);
        //}

        //[Fact]
        //public void Get_ReturnsFiveWeatherForecasts()
        //{
        //    // Act
        //    var result = _controller.Get();

        //    // Assert
        //    Assert.Equal(5, result.Count());
        //}

        //[Fact]
        //public void Get_ReturnsWeatherForecastsWithValidDates()
        //{
        //    // Act
        //    var result = _controller.Get();

        //    // Assert
        //    foreach (var forecast in result)
        //    {
        //        Assert.True(forecast.Date >= DateOnly.FromDateTime(DateTime.Today));
        //    }
        //}

        //[Fact]
        //public void Get_ReturnsWeatherForecastsWithValidTemperatureRange()
        //{
        //    // Act
        //    var result = _controller.Get();

        //    // Assert
        //    foreach (var forecast in result)
        //    {
        //        Assert.True(forecast.TemperatureC >= -20);
        //        Assert.True(forecast.TemperatureC <= 55);
        //    }
        //}

        //[Fact]
        //public void Get_ReturnsWeatherForecastsWithValidSummary()
        //{
        //    // Act
        //    var result = _controller.Get();

        //    // Assert
        //    foreach (var forecast in result)
        //    {
        //        Assert.Contains(forecast.Summary, WeatherForecastController.Summaries);
        //    }
        //}
    }
}
