using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Task2_Json
{
    class Program
    {


        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string strjson = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;

            List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(strjson);
            foreach (Root item in roots)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
