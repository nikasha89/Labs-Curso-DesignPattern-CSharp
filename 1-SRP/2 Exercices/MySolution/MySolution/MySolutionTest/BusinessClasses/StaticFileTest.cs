using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySolution.BusinessClasses;
using System.Collections.Generic;
using System.IO;

namespace MySolutionTest
{
    [TestClass]
    public class StaticFileTest
    {  
        [TestMethod]
        public void TestSaveToFile_FileWithContent_1FileSaved()
        {
            const string FolderName = "FolderNameTest";
            const string FileName = "FileNameTest";

            StaticFile.SaveToFile(FolderName, FileName, "ContentTest");

            Assert.IsTrue(File.Exists(Path.Combine(FolderName, FileName)));

            RemoveFileFromFolder(FolderName, FileName);
        }

        [TestMethod]
        public void TestSaveToFile_FileWithNullContent_1FileSaved()
        {
            const string FolderName = "FolderNameTest";
            const string FileName = "FileNameTest";

            StaticFile.SaveToFile(FolderName, FileName, null);

            Assert.IsTrue(File.Exists(Path.Combine(FolderName, FileName)));

            RemoveFileFromFolder(FolderName, FileName);
        }

        private void RemoveFileFromFolder(string folderName, string fileName)
        {
            File.Delete(Path.Combine(folderName, fileName));
            if (Directory.GetFiles(folderName).Equals(0))
                Directory.Delete(folderName);
        }
    }
}
