using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace task2
{
    class Program2
    {
    static void Main(string[] args)
        {
            JObject json=null;
            string fileName = @"C:\Users\This_User\Desktop\jsonFile.txt";
           //convert txt file to string
            string text = File.ReadAllText(fileName);
            //try to convert to object json
            try
            {
                json = JObject.Parse(text);
            }
            //if the func JObject.Parse dont work i printed the problem
            catch (Exception ep)
            {  
                Console.WriteLine(ep.Message);
            }
            if (json != null)
            {
                foreach (var e in json)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
