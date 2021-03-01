
namespace EstimatedTime.Domain
{
    public class EstimatedDuration
    {
        const string _SEPARATOR = " and ";

        public string GetEstimatedTime(string input)
        {
            var splittedInput = input.Split(_SEPARATOR);

            var hours = GetFormattedHours(splittedInput[0]);

            var minutes = GetFormattedMinutes(splittedInput[1]);

            if(hours.StartsWith("0"))
            {
                return minutes;
            }

            if (minutes.StartsWith("0"))
            {
                return hours;
            }
                        
            return $"{hours}{_SEPARATOR}{minutes}";
        }

        private string GetFormattedMinutes(string input) =>
            GetFormattedTime(input);

        private string GetFormattedHours(string input) =>
            GetFormattedTime(input);

        private string GetFormattedTime(string input)
        {
            if(!IsSingular(input))
            {
                return input;
            }
            return input.TrimEnd('s');
        }
        
        private bool IsSingular(string input)
        {
            var numberRaw = input.Split(" ")[0];
            var number = int.Parse(numberRaw);
            return number == 1;
        }
    }
}
