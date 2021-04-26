using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserealizedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserealizedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2021-04-26T13:33:53.3454023Z"}
            //RusAl < 26.04.2021 13:33:53 >: Privet
        }
    }
}
