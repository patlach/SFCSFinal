using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class FriendMenuView
    {
        public void Show(User user)
        {
            Console.WriteLine("Add Friend (press 1)");
            Console.WriteLine("Delete Friend (press 2)");

            switch (Console.ReadLine())
            {
                case "1":
                    Program.friendAddView.Show(user);
                    break;
                case "2":
                    Console.WriteLine("You can't"); ;
                    break;
            }
        }
    }
}
