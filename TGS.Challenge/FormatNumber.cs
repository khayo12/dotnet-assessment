using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            if (value > 1000000000)
            {
                throw new ArgumentOutOfRangeException("The number must not be greater than 1000000000.");
            }
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The number must not be less than 0.");
            }
            var stringValue = value.ToString();
            var temp = new StringBuilder();
            var commaValue = new StringBuilder();
            var length = stringValue.Length;
            var index = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                temp.Append(stringValue[i]);
                index++;
                if (index % 3 == 0 && i != 0)
                {
                    temp.Append(",");
                }
            }

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                commaValue.Append(temp[i]);
            }

            return commaValue.ToString();
        }
    }
}
