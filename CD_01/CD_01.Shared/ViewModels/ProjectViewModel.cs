using System;
using System.Collections.Generic;
using System.Collections.objectModel;
using System.Text;
using CD_01.Models;

namespace CD_01.ViewModels
{
    class ProjectViewModel
    {

        public ObservableCollection<Project> Projects
        {
            get;
            set;
        }

        public void LoadProjects()
        {
            ObservableCollection<Project> projects = new ObservableCollection<Project>();

            projects.Add(new Project { ProjectId = 0, ProjectName = "test p", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });
            projects.Add(new Project { ProjectId = 1, ProjectName = "test rrrp", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });
            projects.Add(new Project { ProjectId = 2, ProjectName = "test sdfgp", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });
            projects.Add(new Project { ProjectId = 3, ProjectName = "test sdf p", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });
            projects.Add(new Project { ProjectId = 4, ProjectName = "test hdfhp", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });
            projects.Add(new Project { ProjectId = 5, ProjectName = "test asdfp", ProjectDescription = "blabla bla", ProjectCreated = DateTime.Now, ProjectChanged = DateTime.Now, ProjectStatus = 1, ProjectUser = 1 });

            Projects = projects;
        }
    }
}
