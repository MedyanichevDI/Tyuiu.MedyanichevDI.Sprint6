using System.Reflection.PortableExecutable;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedyanichevDI.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7 
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            try
            {
                string[] lines = File.ReadAllLines(path);

                //var words = input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                string res = "";
                foreach (string line in lines)
                {
                    // Разделяем строку на слова
                   var words = line.Split(new[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries);

                    // Если в строке есть 3 или более слов
                    if (words.Length >= 3)
                    {
                        // Добавляем третье слово в результат
                        res += words[2] + " ";
                    }
                }

                return res.Trim();
            
               

            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка: {ex.Message}", ex);
            }
        }

       
        
    }
}
