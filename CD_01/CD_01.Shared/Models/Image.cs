using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class ImageModel { }

    public class Image : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string description;
        private string fileName;
        private string location;
        private object parameter;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int ImageId
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
                    RaisePropertyChanged("ImageId");
                }
            }
        }

        public string ImageName
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
                    RaisePropertyChanged("ImageName");
                }
            }
        }

        public string ImageDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("ImageDescription");
                }
            }
        }

        public string ImageFileName
        {
            get { return fileName; }

            set
            {
                if (fileName != value)
                {
                    fileName = value;
                    RaisePropertyChanged("ImageFileName");
                }
            }
        }

        public string ImageLocation
        {
            get { return location; }

            set
            {
                if (location != value)
                {
                    location = value;
                    RaisePropertyChanged("ImageLocation");
                }
            }
        }

        // TODO:placeholder implementation
        public object ImageParameters
        {
            get { return parameter; }

            set
            {
                if (parameter != value)
                {
                    parameter = value;
                    RaisePropertyChanged("ImageParameters");
                }
            }
        }

        public DateTime ImageCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("ImageCreated");
                }
            }
        }

        public DateTime ImageChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("ImageChanged");
                }
            }
        }

        // object could contain change history of the Image
        public object ImageHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("ImageHistory");
                }
            }
        }

        public int ImageStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("ImageStatus");
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
