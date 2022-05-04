using System;
using System.Collections.Generic;
using System.Net;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            List<string> posts = new List<string>();

            for (int i = 1; i < 5; i++)
            {
                var text = client.DownloadString($"http://jsonplaceholder.typicode.com/posts/{i}");
                posts.Add(text);
                
            }

            var cos = posts;
        }
    }
}
