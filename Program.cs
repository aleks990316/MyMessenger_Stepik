using System;
using Newtonsoft.Json;

namespace MyMessenger_Stepik
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }
        static void Main(string[] args)
        {
            //Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message deserealizedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserealizedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2021-04-26T13:33:53.3454023Z"}
            //RusAl < 26.04.2021 13:33:53 >: Privet
            MessageID = 1;
            Console.WriteLine("Введите Ваше имя: ");
            UserName = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }
    }
}
