using System;
using Xunit;
using PPS.Core.Models;
using PPS.Core.Security;

using PPS.Data.Services;

namespace PPS.Test
{
    public class AthleteServiceTests
    {
        private AthleteService service;

        public AthleteServiceTests()
        {
            service = new AthleteService();
            service.Initialise();
        }

        [Fact]
        public void EmptyDbShouldReturnNoAthletes()
        {
            // act
            var athletes = service.GetAthletes();

            // assert
            Assert.Equal(0, athletes.Count);
        }
        
       
    }
}
