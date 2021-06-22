using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class ProbeSettingsModel { }

    public class ProbeSettings : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string description;
        private int probeId;
        private object settings;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;

        public int ProbeSettingsId
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
                    RaisePropertyChanged("ProbeSettingsId");
                }
            }
        }

        public string ProbeSettingsName
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
                    RaisePropertyChanged("ProbeSettingsName");
                }
            }
        }

        public string ProbeSettingsDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("ProbeSettingsDescription");
                }
            }
        }

        public int ProbeSettingsTarget
        {
            get { return probeId; }

            set
            {
                if (probeId != value)
                {
                    probeId = value;
                    RaisePropertyChanged("ProbeSettingsTarget");
                }
            }
        }

        // TODO:placeholder implementation
        public object ProbeSettingsSettings
        {
            get { return settings; }

            set
            {
                if (settings != value)
                {
                    settings = value;
                    RaisePropertyChanged("ProbeSettingsSettings");
                }
            }
        }

        public DateTime ProbeSettingsCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("ProbeSettingsCreated");
                }
            }
        }

        public DateTime ProbeSettingsChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("ProbeSettingsChanged");
                }
            }
        }

        // object could contain change history of the ProbeSettings
        public object ProbeSettingsHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("ProbeSettingsHistory");
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
