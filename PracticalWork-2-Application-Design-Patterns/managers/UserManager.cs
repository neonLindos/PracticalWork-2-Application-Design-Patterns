using System;
using System.Collections.Generic;
using System.Linq;
using PracticalWork_2_Application_Design_Patterns.models;

namespace PracticalWork_2_Application_Design_Patterns.managers
{
    internal class UserManager
    {
        public List<User> Users { get; set; }

        public UserManager()
        {
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }

        public void UpdateUser(User oldUser, User newUser)
        {
            int index = Users.IndexOf(oldUser);
            if (index != -1)
            {
                Users[index] = newUser;
            }
        }

        public void GiveRoleToUser(User user, string roleName)
        {
            if (Users.Contains(user))
            {
                user.role = roleName; 
            }
        }
    }
}
