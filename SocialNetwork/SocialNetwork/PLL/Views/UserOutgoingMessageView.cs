using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserOutgoingMessageView
    {
        public void Show(IEnumerable<Message> outgoingMessage)
        {
            Console.WriteLine("Outgoing Messages");

            if (outgoingMessage.Count() == 0)
            {
                Console.WriteLine("No outgoing messages");
                return;
            }

            outgoingMessage.ToList().ForEach(message =>
            {
                Console.WriteLine("To: {0}\nMessage: {1}", message.RecipientEmail, message.Content);
            });
        }
    }
}
