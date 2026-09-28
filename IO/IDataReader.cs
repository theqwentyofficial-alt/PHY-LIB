namespace PHY_LIB.IO
{
    public interface IDataReader
    {
   public Task<string> ReadFileAsync(string path);
    }
}
