using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NovikovaVA.Sprint6.Task6.V28.Lib
{
    public class DataService : ISprint6Task6V28
    {
 
            
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    for (int i = 1; i < words.Length; i++)
                    {
                        if (i == words.Length - 2)
                            resStr = resStr + " " + words[i];
                    }
                }
            }
            return resStr;
        }
    }
}
