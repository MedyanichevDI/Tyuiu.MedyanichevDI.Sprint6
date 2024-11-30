using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedyanichevDI.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double[] res = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0.25)
                {
                    res[count] = 0;
                    count++;
                    break;
                }
                else
                {
                    res[count] = Math.Round(5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5)), 2);
                    count++;
                }
            }
            return res;
        }
    }
}

