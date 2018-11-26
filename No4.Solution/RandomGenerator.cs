using System;
using System.IO;
using Path = System.IO.Path;

namespace No4.Solution
{
    public abstract class RandomGenerator
    {
        public string WorkingDirectory { get; }

        public string FileExtension { get; }

        protected RandomGenerator(string workingDirectory, string fileExtension)
        {
            WorkingDirectory = workingDirectory;
            FileExtension = fileExtension;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        public void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }
            File.WriteAllBytes(Path.Combine(WorkingDirectory, fileName), content);
        }

        protected abstract byte[] GenerateFileContent(int contentLength);
    }
}
