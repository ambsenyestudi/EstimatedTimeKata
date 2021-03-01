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
            var estimatedTime = new EstimatedDuration();
            Assert.Equal(expected, estimatedTime.GetEstimatedTime());
        }
    }
}
