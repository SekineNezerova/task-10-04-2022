using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml.Serialization;

namespace Task1_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string resJson = httpClient.GetStringAsync("https://json2csharp.com/xml-to-csharp").Result;
            StreamWriter sw = new StreamWriter(@"C:\Users\User\Desktop\10.04.2022task\file.json");
            sw.WriteLine();
            sw.Close();
            Console.WriteLine(sw);
            FileInfo file = new FileInfo(@"C:\Users\User\Desktop\10.04.2022task\file.json");
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(resJson);

        }
    }
}
