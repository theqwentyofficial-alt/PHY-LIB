using System.Data;
using System.Runtime.CompilerServices;

namespace PHY_LIB.IO
{
    public class DataReader : IDataReader
    {
        public async Task<string> ReadFileAsync(string path)
        {
            using (StreamReader reader = new(path))
            {
                CancellationToken token = new();
                string data = await reader.ReadToEndAsync(token);
                return data;
            }
        }
    }
}
