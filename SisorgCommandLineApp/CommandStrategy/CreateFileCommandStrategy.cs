namespace SisorgCommandLineApp.CommandStrategy
{
    internal class CreateFileCommandStrategy : CommandStrategy
    {
        private readonly string directoryPath;
        public CreateFileCommandStrategy(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public override void Execute(string[] arguments)
        {
            ThrowIfThereAreNoArguments(arguments);
            CreateFile(arguments[0]);
        }

        private void CreateFile(string fileName)
        {
            ThrowIfNameIsInvalid(fileName);
            string filePath = directoryPath + "\\" + fileName;
            File.Create(filePath);
        }

        private void ThrowIfNameIsInvalid(string fileName)
        {
            if (fileName is null || fileName == "") throw new Exception($"{fileName} is empty or not a valid file name.");
            string extension = Path.GetExtension(fileName);
            if (extension.Length < 1) throw new Exception("Invalid file name extension.");
        }
    }
}
