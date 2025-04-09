using System.Text;

namespace ConsoleApp5;

internal static class Program
{
    private static async Task Main()
    {
        using var source = new MemoryStream(Encoding.ASCII.GetBytes("123m4a555r2at22"));
        using var destination = new MemoryStream();
        
        await TransferSymbols(source, destination);
        
        destination.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(destination);
        var result = await reader.ReadToEndAsync();
        Console.WriteLine(result);
    }

    private static async Task TransferSymbols(Stream source, Stream destination)
    {
        var readBuffer = new byte[1024];
        var writeBuffer = new List<byte>();
        var offset = 0;

        while (true)
        {
            var bytesRead = await source.ReadAsync(readBuffer, 0, readBuffer.Length);
            if (bytesRead == 0) break;

            for (var i = 0; i < bytesRead; ++i)
            {
                var b = readBuffer[i];
                if (b >= 97 && b <= 122)
                {
                    writeBuffer.Add(b);
                }
            }

            await destination.WriteAsync(writeBuffer.ToArray(), 0, writeBuffer.Count);
            writeBuffer.Clear();
        }
    }
}