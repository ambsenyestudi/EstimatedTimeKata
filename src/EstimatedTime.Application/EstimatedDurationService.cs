using EstimatedTime.Domain;
using System;

namespace EstimatedTime.Application
{
    public class EstimatedDurationService
    {
        public string ProcessEstimatedDuration(string input)
        {
            var duration = new EstimatedDuration();
            return duration.GetEstimatedTime();
        }
    }
}
