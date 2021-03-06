using EstimatedTime.Domain;
using System;
using Xunit;

namespace EstimatedTime.Unit.Test
{
    public class EstimatedTimeShould
    {
        [Fact]
        public void ProcessSingleTimeUnits()
        {
            var expected = "1 hour and 1 minute";
            var input = "1 hours and 1 minutes";
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }

        [Fact]
        public void NotShowMinutesWhenZeroMinutes()
        {
            var expected = "2 hours";
            var estimatedTime = new EstimatedDuration();
            var input = "2 hours and 0 minutes";
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }

        [Fact]
        public void NotShowHoursWhenZeroHours()
        {
            var expected = "45 minutes";
            var input = "0 hours and 45 minutes";
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }

        [Fact]
        public void ShowingTheProperHoursWhenMinutesAreTen()
        {
            var expected = "3 hours and 10 minutes";
            var input = "3 hours and 10 minutes";
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }

        [Fact]
        public void ShowOneHour()
        {
            var expected = "1 hour";
            var input = "1 hours and 0 minutes";
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }
        [Fact]
        public void ShowOneMinute()
        {
            var expected = "1 minute";
            var input = "0 hours and 1 minutes";
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime(input));
        }
    }
}
