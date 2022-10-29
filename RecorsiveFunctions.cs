using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class RecorsiveFunctions
    {
        public int GetFullNum(int n) //q1
        {
            if (n == 0)
                return 0;
            return n + GetFullNum(n - 1);
        }
        public int MultPosNums(int n) //q2
        {
            if (n == 1)
                return 1;
            if (n % 2 != 0)
                return n * MultPosNums(n - 1);
            else
                return MultPosNums(n - 1);
        }
        public int GetFactorial(int n) //q3
        {
            if (n == 1)
                return 1;
            return n * GetFactorial(n - 1);
        }
        public int GetAmountOfNums(long n) //q4
        {
            if (n < 10)
                return 1;
            return 1 + GetAmountOfNums(n / 10);
        }
        public int GetAmountOfEvenNums(long n) //q5
        {
            if (n < 10 && n % 2 == 0)
                return 1;
            if (n % 2 == 0)
                return 1 + GetAmountOfEvenNums(n / 10);
            return GetAmountOfEvenNums(n / 10);
        }
        public int GetLeftNumber(int n) //q6
        {
            if (n < 10)
                return n;
            return GetLeftNumber(n / 10);
        }
    }
}
