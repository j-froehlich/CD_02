using System;
using System.Collections.Generic;
using System.Collections.objectModel;
using System.Text;
using CD_01.Models;

namespace CD_01.ViewModels
{
    class UserViewModel
    {

        public ObservableCollection<User> Users
        {
            get;
            set;
        }

        public void LoadUsers()
        {
            ObservableCollection<User> users = new ObservableCollection<User>();

            users.Add(new User { UserId = 0, FirstName = "Mark", LastName = "Allain", CustomerId = 0, Description = "...", UserCreated = DateTime.Now, UserChanged = DateTime.Now, UserStatus = 1 });
            users.Add(new User { UserId = 1, FirstName = "Allen", LastName = "Brown", CustomerId = 0, Description = "...", UserCreated = DateTime.Now, UserChanged = DateTime.Now, UserStatus = 1 });
            users.Add(new User { UserId = 2, FirstName = "Linda", LastName = "Hamerski", CustomerId = 0, Description = "...", UserCreated = DateTime.Now, UserChanged = DateTime.Now, UserStatus = 1 });

            Users = users;
        }
    }
}
