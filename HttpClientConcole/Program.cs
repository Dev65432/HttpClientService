using System;

namespace HttpClientConcole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            HttpClientService.HttpClientService httpClientService = new HttpClientService.HttpClientService();
            httpClientService.DebugWriteLine();
        }
    }
}
