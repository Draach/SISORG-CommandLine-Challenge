namespace SisorgCommandLineApp.CommandStrategy
{
    internal class MoveFileCommandStrategy : BaseCommandStrategy
    {
        private readonly string directoryPath;
        public MoveFileCommandStrategy(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }
        public override void Execute(string[] arguments)
        {
            ThrowIfThereAreNoArguments(arguments);
            ThrowIfInvalidArgumentsQuantity(arguments);


            if (!IsPath(arguments[0]) && FileExists(JoinFileNameWithPath(arguments[0])))
            {
                File.Move(JoinFileNameWithPath(arguments[0]), JoinFileNameWithPath(arguments[1]));
            }
            else if (IsPath(arguments[0]) && IsPath(arguments[1]) && FileExists(arguments[0]))
            {
                string sourceFilePath = arguments[0];
                string destinationFolder = arguments[1];

                Directory.CreateDirectory(destinationFolder);

                string fileName = Path.GetFileName(sourceFilePath);
                Console.WriteLine($"FileName: {fileName}");

                string destinationFilePath = Path.Combine(destinationFolder, fileName);

                File.Move(sourceFilePath, destinationFilePath);
            }
        }

        private void ThrowIfInvalidArgumentsQuantity(string[] arguments)
        {
            // TODO: Improve error message?
            if (arguments.Length != 2) throw new Exception("Invalid arguments quantity");
        }

        private bool FileExists(string pathToFile)
        {
            return File.Exists(pathToFile);
        }

        private string JoinFileNameWithPath(string fileName)
        {
            return directoryPath + "\\" + fileName;
        }

        private bool IsPath(string value)
        {
            // TODO: Improve validation.
            return value.Contains("\\");
        }
    }
}
