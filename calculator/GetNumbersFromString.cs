using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculator
{
    public class GetNumbersFromString
    {
        public static List<string> SplitNumbers(string userInPut)
        {
            string _usreInPut = userInPut;

            string usreInPutLower = _usreInPut.ToLower();

           
            List<string> numbersInput = new List<string>();
            Regex regex = new Regex(@"\d+(\.\d+)?");
            var matches = regex.Matches(usreInPutLower);
            foreach (Match match in matches)
            {
                numbersInput.Add(match.Value);

            }
            return  numbersInput;
        }
        
    }
}
