using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class JobModel { }

    public class Job : INotifyPropertyChanged
    {

        private int id;
        private string name;
        private string description;
        private object settings;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int JobId
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
                    RaisePropertyChanged("JobId");
                }
            }
        }

        public string JobName
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
                    RaisePropertyChanged("JobName");
                }
            }
        }

        public string JobDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("JobDescription");
                }
            }
        }

        // TODO:placeholder implementation
        public object JobSettings
        {
            get { return settings; }

            set
            {
                if (settings != value)
                {
                    settings = value;
                    RaisePropertyChanged("JobSettings");
                }
            }
        }

        public DateTime JobCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("JobCreated");
                }
            }
        }

        public DateTime JobChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("JobChanged");
                }
            }
        }

        // object could contain change history of the Job
        public object JobHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("JobHistory");
                }
            }
        }

        public int JobStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("JobStatus");
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
