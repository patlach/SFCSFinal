using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;

        public FriendService()
        {
            friendRepository = new FriendRepository();
        }

        public void AddFriend(FriendData friendData, User user)
        {
            var userRepository = new UserRepository();

            if(String.IsNullOrEmpty(friendData.FriendEmail))
                throw new ArgumentNullException();

            if (!new EmailAddressAttribute().IsValid(friendData.FriendEmail))
                throw new ArgumentNullException();

            if (userRepository.FindByEmail(friendData.FriendEmail) == null)
                throw new ArgumentNullException();

            var friendID = userRepository.FindByEmail(friendData.FriendEmail).id;

            var friendEntity = new FriendEntity()
            {
                user_id = user.Id,
                friend_id = friendID,
            };

            if(this.friendRepository.Create(friendEntity) == 0)
            {
                throw new Exception();
            }
        }
    }
}
