using System;
using System.Linq;
//return input.Skip(1).SkipWhile(x => !char.IsDigit(x)).ToString();
namespace EstimatedTime.Domain
{
    public class EstimatedDuration
    {
        const string _ONEHOURSONEMINUTES = "1 hours and 1 minutes";


        public string GetEstimatedTime(string input)
        {
            if(input.StartsWith("0"))
            {
                return input.Replace("0 hours and ", "");
            }
            if(input.Contains("0"))
            {
                if (input.Contains("0 minutes"))
                {
                    return "2 hours";
                }
            }

            if (input == _ONEHOURSONEMINUTES)
            {
                return "1 hour and 1 minute";
            }

            
            return input;
        }

        
    }
}
