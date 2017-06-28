using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }
    }
    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var users = new List<User>();

            while (inputLine!="exit")
            {
                var splittedInput = inputLine.Split(' ');
                
                if (splittedInput[0]=="register")
                {
                    var newUser = new User()
                    {
                        Username = splittedInput[1],
                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.Contains(newUser))
                    {
                        users.Add(newUser);
                    }
                }
                else
                {
                    var sender = splittedInput[0];
                    var recipient = splittedInput[2];


                    var newMessage = new Message();
                    newMessage.Content = splittedInput[3];
                    newMessage.Sender = new User
                    {
                        Username = sender,
                        ReceivedMessages = new List<Message>()
                    };

                    var containsSender = users.Where(x => x.Username == sender).ToArray();
                    var containsRecipient = users.Where(x => x.Username == recipient).ToArray();

                    if (containsSender.Count()>0 && containsRecipient.Count()>0)
                    {
                        var recipientMessages = users.FirstOrDefault(x => x.Username == recipient);
                        if (recipientMessages!=null)
                        {
                            recipientMessages.ReceivedMessages.Add(newMessage);
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }

            var newInput = Console.ReadLine().Split(' ');
            var firstName = newInput[0];
            var secondName = newInput[1];

            var messagesFromFirstToSecond = users
                .Where(x => x.Username == secondName)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == firstName)
                .Count();
            var messagesFromSecondToFirst = users
                .Where(x => x.Username == firstName)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == secondName)
                .Count();

            if (messagesFromFirstToSecond==0 && messagesFromSecondToFirst==0)
            {
                Console.WriteLine("No messages");
            }
            for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
            {
                if (i < messagesFromFirstToSecond)
                {
                    Console.WriteLine($"{firstName}: {users.Where(x => x.Username == secondName).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == firstName).Select(x => x.Content).ToList()[i]}");
                }
                if (i < messagesFromSecondToFirst)
                {
                    Console.WriteLine($"{users.Where(x => x.Username == firstName).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == secondName).Select(x => x.Content).ToList()[i]} :{secondName}");
                }
            }
        }
    }
}
