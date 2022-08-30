using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._IEnumerable__IEnumerator_interfaces
{
    public class ShowPower
    {
        public static IEnumerable<float> SuperPower(int number, int degree)
        {
            if (degree == 0)
            {
                yield return 1F;
            }
            else if (number == 0)
            {
                yield break;
            }
            else
            {
                int count = degree > 0 ? degree : degree * -1;
                float result = number;
                if (degree > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        yield return i < 1 ? result : result *= number;
                    }
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        yield return i < 1 ? result = 1 / (float)number : result /= number;
                    }
                }
            }
        }
    }
}
