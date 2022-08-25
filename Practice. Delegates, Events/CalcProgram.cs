namespace SoftServe_IT_Academy.Practice._Delegates__Events
{
    public delegate double CalcDelegate(int numberOne, int numberTwo, char sign);

    public class CalcProgram
    {
        public static double Calc(int numberOne, int numberTwo, char sign)
        {
            int result = 0;

            if (sign == char.Parse("+"))
            {
                result = numberOne + numberTwo;
            }
            if (sign == char.Parse("-"))
            {
                result = numberOne - numberTwo;
            }
            if (sign == char.Parse("*"))
            {
                result = numberOne * numberTwo;
            }
            if (sign == char.Parse("/"))
            {
                if (numberTwo != 0)
                {
                    result = numberOne / numberTwo;
                }
                else
                {
                    result = 0;
                }
            }

            return result;
        }

        public CalcDelegate funcCalc = Calc;
    }
}
