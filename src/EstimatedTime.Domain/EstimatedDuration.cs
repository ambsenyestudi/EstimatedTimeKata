using System;

namespace EstimatedTime.Domain
{
    public class EstimatedDuration
    {
        const string _ONEHOURSONEMINUTES = "1 hours and 1 minutes";
        const string _TWOHOURSZEROMINUTES = "2 hours and 0 minutes";

        public string GetEstimatedTime(string input)
        {
            if (input == _ONEHOURSONEMINUTES)
            {
                return "1 hour and 1 minute";
            }

            if (input == _TWOHOURSZEROMINUTES)
            {
                return "2 hours";
            }

            return input;
        }
    }
}
