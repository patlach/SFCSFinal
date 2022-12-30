using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        UserService userService;
        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Incoming messages: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Outgoing messages: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("Your profile data (press 1)");
                Console.WriteLine("Edit your profile data (press 2)");
                Console.WriteLine("Add frends (press 3)");
                Console.WriteLine("Write message (press 4)");
                Console.WriteLine("View incoming messages (press 5)");
                Console.WriteLine("View outgoing messages (press 6)");
                Console.WriteLine("Log out (press 7)");

                string enterValue = Console.ReadLine();

                if (enterValue == "7") break;

                switch (enterValue)
                {
                    case "1":
                        Program.userInfoView.Show(user);
                        break;
                    case "2":
                        Program.userEditView.Show(user);
                        break;
                    case "3":
                        Program.friendMenuViews.Show(user);
                        break;
                    case "4":
                        Program.sendMessageView.Show(user);
                        break;
                    case "5":
                        Program.userIncomingMessageView.Show(user.IncomingMessages);
                        break;
                    case "6":
                        Program.userOutgoingMessageView.Show(user.OutgoingMessages);
                        break;

                }
            }
        }
    }
}
