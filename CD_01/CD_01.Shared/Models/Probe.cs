using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class ProbeModel { }

    public class Probe : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string description;
        private string location;
        private object parameter;
        private object settings;
        private object settingsUser;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int ProbeId
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
                    RaisePropertyChanged("ProbeId");
                }
            }
        }

        public string ProbeName
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
                    RaisePropertyChanged("ProbeName");
                }
            }
        }

        public string ProbeDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("ProbeDescription");
                }
            }
        }

        public string ProbeLocation
        {
            get { return location; }

            set
            {
                if (location != value)
                {
                    location = value;
                    RaisePropertyChanged("ProbeLocation");
                }
            }
        }

        // TODO:placeholder implementation
        public object ProbeParameters
        {
            get { return parameter; }

            set
            {
                if (parameter != value)
                {
                    parameter = value;
                    RaisePropertyChanged("ProbeParameters");
                }
            }
        }

        // TODO:placeholder implementation
        public object ProbeSettings
        {
            get { return settings; }

            set
            {
                if (settings != value)
                {
                    settings = value;
                    RaisePropertyChanged("ProbeSettings");
                }
            }
        }

        // TODO:placeholder implementation
        public object ProbeSettingsUser
        {
            get { return settingsUser; }

            set
            {
                if (settingsUser != value)
                {
                    settingsUser = value;
                    RaisePropertyChanged("ProbeSettingsUser");
                }
            }
        }

        public DateTime ProbeCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("ProbeCreated");
                }
            }
        }

        public DateTime ProbeChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("ProbeChanged");
                }
            }
        }

        // object could contain change history of the Probe
        public object ProbeHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("ProbeHistory");
                }
            }
        }

        public int ProbeStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("ProbeStatus");
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
