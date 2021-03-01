using System;
using Xunit;
using EstimatedTime.Application;
namespace EstimatedTime.Acceptance.Test
{
    public class EstimatedDurationServiceShould
    {
        [Fact]
        public void ProcessDuration()
        {
            var sut = new EstimatedDurationService();
            var originalInput = "Walk on the beach at sunset at beautiful Platja d'es Capellans, Can Picafort, up to the hut bar for some cocktails. Estimated duration 1 hours and 1 minutes.";
            Assert.Equal(originalInput, sut.ProcessEstimatedDuration(originalInput));
            
        }
    }
}
