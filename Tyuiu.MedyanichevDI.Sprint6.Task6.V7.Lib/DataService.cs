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
                string input;
                using (var reader = new StreamReader(path))
                {
                    input = reader.ReadToEnd();
                }


                var words = input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
               

                var thirdWords = input
               .Select(line => input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
               .Where(words => words.Length >= 3)
               .Select(words => words[2]);


                string res = string.Join(" ", thirdWords);
                return res;
               

            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка: {ex.Message}", ex);
            }
        }

       
        
    }
}
