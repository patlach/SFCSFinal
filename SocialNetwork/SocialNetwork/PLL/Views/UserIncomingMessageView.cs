using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Incoming messages");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("No incoming messages");
                return;
            }

            incomingMessages.ToList().ForEach(incomingMessage =>
            {
                Console.WriteLine("From: {0}\nMessage: {1}", incomingMessage.SenderEmail, incomingMessage.Content);
            });
        }
    }
}
