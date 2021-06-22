using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class UserModel { }

    public class User : INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string lastName;
        private int customerId;
        private string description;
        private object settings;
        private object settingsApp;
        private object templates;
        private DateTime creationDate;
        private DateTime lastChanged;
        private int userImageId;
        private object history;
        private int status;

        public int UserId
        {
            get
            {
                return id;
            }

            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged("UserId");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastName; }

            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public int CustomerId
        {
            get { return customerId; }

            set
            {
                if (customerId != value)
                {
                    customerId = value;
                    RaisePropertyChanged("CustomerId");
                }
            }
        }

        public string Description
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("UserDescription");
                }
            }
        }

        // TODO:placeholder implementation
        public object Settings
        {
            get { return settings; }

            set
            {
                if (settings != value)
                {
                    settings = value;
                    RaisePropertyChanged("Settings");
                }
            }
        }

        // TODO:placeholder implementation
        public object SettingsApp
        {
            get { return settingsApp; }

            set
            {
                if (settingsApp != value)
                {
                    settingsApp = value;
                    RaisePropertyChanged("SettingsApp");
                }
            }
        }

        // TODO:placeholder implementation
        public object UserTemplates
        {
            get { return templates; }

            set
            {
                if (templates != value)
                {
                    templates = value;
                    RaisePropertyChanged("UserTemplates");
                }
            }
        }

        // TODO:placeholder implementation
        public int UserImage
        {
            get { return userImageId; }

            set
            {
                if (userImageId != value)
                {
                    userImageId = value;
                    RaisePropertyChanged("UserImage");
                }
            }
        }

        public DateTime UserCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("UserCreated");
                }
            }
        }

        public DateTime UserChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("UserChanged");
                }
            }
        }

        // object could contain change history of the User
        public object UserHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("UserHistory");
                }
            }
        }

        public int UserStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("UserStatus");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
