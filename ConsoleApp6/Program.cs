﻿using System;
using System.Buffers;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal static class Program
    {
        private const int MinBufferSize = 2014;

        private static async Task<long> CountSymbols(Stream source, Thread reference)
        {
            Console.Write( ReferenceEquals(Thread.CurrentThread, reference) ? "same " : "other" );

            var count = 0L;

            var buffer = ArrayPool<byte>.Shared.Rent(MinBufferSize);
            try
            {
                while (true)
                {
                    var bytesRead = await source.ReadAsync(buffer, 0, buffer.Length);

                    if (0 == bytesRead)
                    {
                        break;
                    }

                    count += bytesRead;
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }

            Console.Write( ReferenceEquals(Thread.CurrentThread, reference) ? "same " : "other" );

            return count;
        }

        private static void Main()
        {
            var thisAssemblyFilePath = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path;

            using (var assembly = new MemoryStream(new byte[31000]))
            {
                CountSymbols(assembly, Thread.CurrentThread).Wait();
            }
        }
    }
}