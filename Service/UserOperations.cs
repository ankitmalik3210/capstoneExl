using System;
using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.models;

namespace finalPOCService.service
{
    public class UserOperations : IUser
    {
        DatabaseContext db;
        public UserOperations(DatabaseContext _db)
        {
            db = _db;
        }
        int IUser.accountCreate(User user)
        {
            db.users.Add(user);
            return db.SaveChanges();
        }

        bool IUser.loginAccount(User user)
        {
            var res = db.users.Find(user.userName);
            if (res == null)
            {
                return false;
            }
            else
            {
                if (res.password == user.password)
                {
                    return true;
                }
                return false;
            }
        }
    }
}