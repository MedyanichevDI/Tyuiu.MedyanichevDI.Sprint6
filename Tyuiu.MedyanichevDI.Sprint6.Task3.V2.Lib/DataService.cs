using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedyanichevDI.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int row = matrix.GetUpperBound(0) + 1;
            int colm = matrix.Length / row;
            int[] firstColumn = new int[row];
            for (int i = 0; i < row; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }
            for (int i = 0; i <=1 ; i++)
            {
               
                if (firstColumn[i] % 2 == 0)
                {
                    firstColumn[i] = 0;
                } 

            }
            for (int i = 0; i < row; i++)
            {
                matrix[i, 0] = firstColumn[i];
            }
            return matrix;
        }

    }    
}
