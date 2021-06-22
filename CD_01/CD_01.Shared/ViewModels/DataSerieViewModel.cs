using System;
using System.Collections.Generic;
using System.Collections.objectModel;
using System.Text;
using CD_01.Models;

namespace CD_01.ViewModels
{
    class DataSerieViewModel
    {

        public ObservableCollection<DataSerie> DataSerie
        {
            get;
            set;
        }

        public void LoadDataSeries()
        {
            ObservableCollection<DataSerie> dataSeries = new ObservableCollection<DataSerie>();

            dataSeries.Add(new DataSerie { DataSerieId = 0, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 1, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 2, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 3, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 4, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 5, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 6, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 7, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 8, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 9, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 10, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 11, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 12, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 13, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 14, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });
            dataSeries.Add(new DataSerie { DataSerieId = 15, DataSerieName = "DS 01", DataSerieDescription = "Mark", DataSerieCreated = DateTime.Now, DataSerieChanged = DateTime.Now, DataSerieStatus = 1 });

            DataSerie = dataSeries;
        }
    }
}
