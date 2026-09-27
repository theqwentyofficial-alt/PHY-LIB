namespace PHY_LIB.IO
{
    public interface IDataReader
    {
        Task<string> ReadFile(string path);
    }
}
