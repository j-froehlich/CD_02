using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class CustomerModel { }

    public class Customer : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string description;
        private object settings;
        private object settingsApp;
        private object templates;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int CustomerId
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
                    RaisePropertyChanged("CustomerId");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
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
                    RaisePropertyChanged("Description");
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
        public object CustomerTemplates
        {
            get { return templates; }

            set
            {
                if (templates != value)
                {
                    templates = value;
                    RaisePropertyChanged("CustomerTemplates");
                }
            }
        }

        public DateTime CustomerCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("CustomerCreated");
                }
            }
        }

        public DateTime CustomerChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("CustomerChanged");
                }
            }
        }

        // object could contain change history of the Customer
        public object CustomerHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("CustomerHistory");
                }
            }
        }

        public int CustomerStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("CustomerStatus");
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
