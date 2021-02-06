using System.IO;

namespace MySolution.BusinessClasses
{
    public static class StaticFile
    {
        public static void SaveToFile(string directoryPath, string fileName, string content)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), content);
        }
    }
}
