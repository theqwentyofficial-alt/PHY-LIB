using System.Data;
using System.Runtime.CompilerServices;

namespace PHY_LIB.IO
{
    public class DataReader : IDataReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async Task<string> ReadFile(string path)
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
