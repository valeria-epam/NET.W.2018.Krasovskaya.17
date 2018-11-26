using System;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomGenerator
    {
     public RandomBytesFileGenerator(string workingDirectory, string fileExtension) : base(workingDirectory, fileExtension)
        {
            
        }

       protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }


    }
}
