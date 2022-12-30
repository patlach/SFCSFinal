using NUnit.Framework;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetworkUnitTest
{
    public class Tests
    {
        [Test]
        public void AddFriendCreateTest()
        {

            FriendRepository friendRepository = new FriendRepository();

            var friendsEntity = new FriendEntity()
            {
                friend_id = 1,
                user_id = 2
            };

            Assert.True(friendRepository.Create(friendsEntity) != 0);
        }
    }
}