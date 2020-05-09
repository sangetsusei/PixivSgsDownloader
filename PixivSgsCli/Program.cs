using System;
using CommandDotNet;

namespace PixivSgsCli
{
    class Program
    {
        static int Main(string[] args)
        {
             return new AppRunner<MainEntry>()
                .UseDefaultMiddleware()
                .Run(args);
        }

    }

    class MainEntry
    {

    }
}
