using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public interface IBasicMaths
    {
        int Sum(int num1, int num2);
        int Sub(int num1, int num2);
        int Div(int num1, int num2);
        int Mul(int num1, int num2);

    }
    public interface IAdvanceMaths 
    {
        int fac(int num1, int num2);
        int pernum(int num1, int num2);
        int pow(int num1, int num2);
        int mean(int num1, int num2);



    }



}
