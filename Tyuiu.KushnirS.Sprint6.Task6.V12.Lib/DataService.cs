using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KushnirS.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string s = "iKDOjtfsPmw";
        public string CollectTextFromFile(string path)
        {
            HashSet<string> uniqueWords = new HashSet<string>();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] temp = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string item in temp)
                        {

                            if (item.IndexOf('w', StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                uniqueWords.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }


            return s;
        }
    }
}