namespace Executor.Contracts
{
    public interface IDirectoryChanger
    {
        void ChangeCurrentDirectoryRelative(string realtivePath);

        void ChangeCurrentDirectoryAbsolute(string absolutePath);
    }
}
