//return input.Skip(1).SkipWhile(x => !char.IsDigit(x)).ToString();
using System.Linq;

namespace EstimatedTime.Domain
{
    public class EstimatedDuration
    {
        const string _ONEHOURSONEMINUTES = "1 hours and 1 minutes";

        public string GetEstimatedTime(string input)
        {
            var splittedInput = input.Split(" and ");

            var hours = splittedInput[0];

            var minutes = splittedInput[1];

            if(hours.StartsWith("0"))
            {
                return minutes;
            }

            if (minutes.StartsWith("0"))
            {
                return hours;
            }

            var formattedHours = GetFormattedTime(hours);
            var formattedMinutes = GetFormattedTime(minutes);
            
            return $"{formattedHours} and {formattedMinutes}";
        }

        private string GetFormattedTime(string input)
        {
            int.TryParse( input.Split(" ").First(), out var number);

            if (number==1)
            {
                return input.SkipLast(1).ToString();
                
            }

            return input;

        }
    }
}
