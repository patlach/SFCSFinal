using System;
using System.Runtime.Serialization;

namespace SocialNetwork.BLL.Services
{
    [Serializable]
    internal class UserNotfoundException : Exception
    {
        public UserNotfoundException()
        {
        }

        public UserNotfoundException(string message) : base(message)
        {
        }

        public UserNotfoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNotfoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}