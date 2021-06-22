using System;
using System.Collections.Generic;
using System.Collections.objectModel;
using System.Text;
using CD_01.Models;

namespace CD_01.ViewModels
{
    class JobViewModel
    {

        public ObservableCollection<Job> Jobs
        {
            get;
            set;
        }

        //public void LoadJobs()
        //{
        //    ObservableCollection<Job> jobs = new ObservableCollection<Job>();

        //    jobs.Add(new Job { FirstName = "Mark", LastName = "Allain" });
        //    jobs.Add(new Job { FirstName = "Allen", LastName = "Brown" });
        //    jobs.Add(new Job { FirstName = "Linda", LastName = "Hamerski" });

        //    Jobs = jobs;
        //}
    }
}
