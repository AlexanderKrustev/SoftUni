namespace Executor.Contracts
{
    public interface IAsyncDownloader
    {
        void DownloadAsync(string fileURL);
    }
}
