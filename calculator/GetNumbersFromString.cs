using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculator
{
    public static class GetNumbersFromString
    {
        public static List<string> SplitNumbers(this string userInPut)
        {
            string _usreInPut = userInPut;

            
            List<string> numbersInput = new List<string>();
            Regex regex = new Regex(@"\d+(\.\d+)?");
            var matches = regex.Matches(userInPut);
            foreach (Match match in matches)
            {
                numbersInput.Add(match.Value);

            }
            return  numbersInput;
        }
        
    }
}
