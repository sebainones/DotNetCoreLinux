using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Reminders.Tests
{
    public class ReminderTest
    {
        [Fact]
        public void WhenGetAddressThenGetWhatExpected()
        {
            //Arrange
            const string expectedResult ="This will be a list of Addresses";
            var sut = new Reminders.Web.Controllers.AddressController();
            

            //Act.
 
            Microsoft.AspNetCore.Mvc.IActionResult actualResult = sut.GetAction();
            Microsoft.AspNetCore.Mvc.OkObjectResult okResult = actualResult as OkObjectResult;
            
            //Assert

            Assert.Equal(expectedResult,okResult.Value);
        }
    }
}
