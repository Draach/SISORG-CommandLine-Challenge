using SisorgCommandLineApp.CommandStrategy.Interfaces;

namespace SisorgCommandLineApp.CommandStrategy
{
    internal abstract class BaseCommandStrategy : ICommandStrategy
    {
        public abstract void Execute(string[] arguments);

        #region utils
        protected void ThrowIfThereAreNoArguments(string[] arguments)
        {
            if (arguments is null || arguments.Length == 0) throw new ArgumentNullException(nameof(arguments));
        }
        #endregion
    }
}
