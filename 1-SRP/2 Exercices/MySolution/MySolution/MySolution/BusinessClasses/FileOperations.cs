using System.IO;

namespace MySolution.BusinessClasses
{
    public class FileOperations
    {
        public void SaveToFile(string directoryPath, string fileName, string content)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), content);
        }
    }
}
