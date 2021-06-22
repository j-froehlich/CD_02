using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class ProjectModel { }

    public class Project : INotifyPropertyChanged
    {

        private int id;
        private string name;
        private string description;
        private string location;
        private string fileName;
        private string fileType;
        private int userId;
        private Array probeId;
        private object settings;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int ProjectId
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
                    RaisePropertyChanged("ProjectId");
                }
            }
        }

        public string ProjectName
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
                    RaisePropertyChanged("ProjectName");
                }
            }
        }

        public string ProjectDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("ProjectDescription");
                }
            }
        }

        public string ProjectLocation
        {
            get { return location; }

            set
            {
                if (location != value)
                {
                    location = value;
                    RaisePropertyChanged("ProjectLocation");
                }
            }
        }

        // TODO:placeholder implementation
        public string ProjectFileName
        {
            get { return fileName; }

            set
            {
                if (fileName != value)
                {
                    fileName = value;
                    RaisePropertyChanged("ProjectFileName");
                }
            }
        }

        // TODO:placeholder implementation
        public string ProjectFileType
        {
            get { return fileType; }

            set
            {
                if (fileType != value)
                {
                    fileType = value;
                    RaisePropertyChanged("ProjectFileType");
                }
            }
        }

        // TODO:placeholder implementation
        public int ProjectUser
        {
            get { return userId; }

            set
            {
                if (userId != value)
                {
                    userId = value;
                    RaisePropertyChanged("ProjectUser");
                }
            }
        }

        // TODO:placeholder implementation
        public Array ProjectProbes
        {
            get { return probeId; }

            set
            {
                if (probeId != value)
                {
                    probeId = value;
                    RaisePropertyChanged("ProjectProbes");
                }
            }
        }

        // TODO:placeholder implementation
        public object ProjectSettings
        {
            get { return settings; }

            set
            {
                if (settings != value)
                {
                    settings = value;
                    RaisePropertyChanged("ProjectSettings");
                }
            }
        }

        public DateTime ProjectCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("ProjectCreated");
                }
            }
        }

        public DateTime ProjectChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("ProjectChanged");
                }
            }
        }

        // object could contain change history of the Project
        public object ProjectHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("ProjectHistory");
                }
            }
        }

        public int ProjectStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("ProjectStatus");
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
