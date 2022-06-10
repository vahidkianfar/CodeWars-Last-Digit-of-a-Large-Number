using System.Numerics;

namespace CodeWars_Last_Digit_of_a_Large_Number
{
    public class LastDigit
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            //**** Clever Solution **** => return (int)BigInteger.ModPow(n1, n2, 10);
            // HOW???!
            var n1Str= n1.ToString();
            var n2Str= n2.ToString();
            if (n1Str.Length == 1 & n1Str[0] == '0' & n2Str.Length == 1 & n1Str[0] == '0') return 1;
            if (n1Str.Length == 1 & n1Str[0] == '0')
                return 0;
            if (n2Str.Length == 1 & n2Str[0] == '0')
                return 1;
            var numberN1 = n1Str[n1.ToString().Length - 1] - '0';
            var numberN2 = 0;
            foreach (var digit in n2Str)
            {
                numberN2 = numberN2 * 10 + (digit - '0');
                numberN2 %= 4;
            }

            if (numberN2 == 0) numberN2 = 4;
            var lastDigit = Math.Pow(numberN1, numberN2);
            lastDigit %= 10;
            return (int)lastDigit;

        }
    
  
    }
}