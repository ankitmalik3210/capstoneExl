using System;
using finalPOCService.models;

namespace finalPOCService.functionality
{
    public interface IUser
    {
        public int accountCreate(User user);
        public bool loginAccount(User user);
    }
}