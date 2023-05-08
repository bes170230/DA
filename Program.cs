using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
namespace DA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATA ANALYSIS");
            JsonReadService.ReadJsonFile(AskForJsonFileName());
            
        }

        public static string AskForJsonFileName()
        {
        BEGIN:
            Console.Write("\nName of JSON file? ");
            var response = Console.ReadLine();
           if (File.Exists(response))
            {
                Console.Write(Environment.NewLine);
                return response;
            }
           else
            {
               Console.Write("\nError: File doesn't exist!");
               goto BEGIN;
            }
        }
    }
}
