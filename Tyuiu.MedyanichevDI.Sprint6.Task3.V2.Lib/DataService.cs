using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedyanichevDI.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int row = matrix.GetUpperBound(0) + 1;
            int colm = matrix.Length / row;
            
            
                for (int j = 0; j < colm; j++)
                {
                    if (matrix[0, j] % 2 == 0)
                    {
                        matrix[0, j] = 0;
                    }
                }

            
            return matrix;
        }

    }    
}
