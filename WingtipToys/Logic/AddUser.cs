using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingtipToys.Models;

namespace WingtipToys.Logic
{
    public class AddUser
    {
        public bool AddUserToDb(string id, string username, string path)
        {
            var myUser = new User();
            myUser.UserID = id;
            myUser.Username = username;
            myUser.ImagePath = path;
            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.Users.Add(myUser);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}