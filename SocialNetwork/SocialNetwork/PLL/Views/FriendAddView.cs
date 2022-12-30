using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddView
    {
        FriendService friendService;

        public FriendAddView(FriendService friendService)
        {
            this.friendService = friendService;
        }

        public void Show(User user)
        {
            var friendData = new FriendData();

            Console.WriteLine("Enter friend email:");
            friendData.FriendEmail = Console.ReadLine();

            try
            {
                friendService.AddFriend(friendData, user);
                Console.WriteLine("Friend was added successfully");
            }
            catch (UserNotfoundException)
            {
                ErrorMessage.Show("User not found");
            }
        }

    }
}
