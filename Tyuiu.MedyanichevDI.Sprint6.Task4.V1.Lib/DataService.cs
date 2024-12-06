using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedyanichevDI.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass = new double[stopValue-startValue];
            int con = 0;
           for (int i = startValue; i < stopValue+1; i++)
            {
                if (i == 1.2)
                {
                    mass[con] = 0.0;
                    con++;
                }
                else
                {
                    mass[con] = Math.Round(Math.Sin(i) / (i + 1.2) + Math.Cos(i) * (7 * i) - 2, 2);
                    con++;
                }
               
            }
           return mass;
        }
    }
}
