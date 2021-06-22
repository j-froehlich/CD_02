using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CD_01.Models
{
    class DataSerieModel { }

    public class DataSerie : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string description;
        private Array imageIds;
        private object parameter;
        private DateTime creationDate;
        private DateTime lastChanged;
        private object history;
        private int status;

        public int DataSerieId
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
                    RaisePropertyChanged("DataSerieId");
                    // RaisePropertyChanged("FullName");
                }
            }
        }

        public string DataSerieName
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
                    RaisePropertyChanged("DataSerieName");
                }
            }
        }

        public string DataSerieDescription
        {
            get { return description; }

            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("DataSerieDescription");
                }
            }
        }

        // TODO:placeholder implementation
        public Array DataSerieImages
        {
            get { return imageIds; }

            set
            {
                if (imageIds != value)
                {
                    imageIds = value;
                    RaisePropertyChanged("DataSerieImages");
                }
            }
        }

        // TODO:placeholder implementation
        public object DataSerieParameters
        {
            get { return parameter; }

            set
            {
                if (parameter != value)
                {
                    parameter = value;
                    RaisePropertyChanged("DataSerieParameters");
                }
            }
        }

        public DateTime DataSerieCreated
        {
            get { return creationDate; }

            set
            {
                if (creationDate != value)
                {
                    creationDate = value;
                    RaisePropertyChanged("DataSerieCreated");
                }
            }
        }

        public DateTime DataSerieChanged
        {
            get { return lastChanged; }

            set
            {
                if (lastChanged != value)
                {
                    lastChanged = value;
                    RaisePropertyChanged("DataSerieChanged");
                }
            }
        }

        // object could contain change history of the DataSerie
        public object DataSerieHistory
        {
            get { return history; }

            set
            {
                if (history != value)
                {
                    history = value;
                    RaisePropertyChanged("DataSerieHistory");
                }
            }
        }

        public int DataSerieStatus
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    RaisePropertyChanged("DataSerieStatus");
                }
            }
        }

        //public string FullName
        //{
        //    get
        //    {
        //        return firstName + " " + lastName;
        //    }
        //}

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
