using System;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Exceptions;
using NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetworkIntegrationTests
{
    [TestFixture]
    public class FindUserByEmailTest
    {
        [Test]
        public void FindUserByEmailReturUserTest()
        {
            // Arrange
            var userService = new UserService();

            UserRegistrationData user1 = new UserRegistrationData() 
            { 
                Email = "e@e.e",
                Password = "12345678",
                LastName = "E",
                FirstName = "F",
            };

            // Act
            var user = userService.FindByEmail(user1.Email);

            // Assert
            Assert.AreEqual(user.Email, user1.Email);
        }
    }
}
