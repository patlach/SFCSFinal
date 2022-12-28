using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class SendMessageView
    {
        UserService userService;
        MessageService messageService;

        public SendMessageView(UserService userService, MessageService messageService)
        {
            this.userService = userService;
            this.messageService = messageService;
        }

        public void Show(User user)
        {
            var sendingMessageData = new MessageSendingData();

            Console.WriteLine("Enter recipient email");
            sendingMessageData.RecipientEmail = Console.ReadLine();

            Console.WriteLine("Enter message");
            sendingMessageData.Content = Console.ReadLine();

            sendingMessageData.SenderId = user.Id;

            try
            {
                messageService.SendMessage(sendingMessageData);

                SuccessMessage.Show("Message was send");

                user = userService.FindById(user.Id);
            }
            catch (UserNotfoundException)
            {
                ErrorMessage.Show("User not found.");
            }
            catch (ArgumentNullException)
            {
                ErrorMessage.Show("Message can't be empty.");
            }
            catch (Exception)
            {
                ErrorMessage.Show("Error to send message.");
            }
        }

    }
}
