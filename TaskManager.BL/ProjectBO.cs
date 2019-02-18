using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;
using Task = TaskManager.DAL.Project;

namespace TaskManager.BL
{
    public class ProjectBO
    {
        public List<Project> GetAll()
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.Projects.ToList();
            }
        }

        public Project GetProject(int ID)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.Projects.Find(ID);               
            }
        }

        //add Project
        public void AddProject(Project item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Projects.Add(item);
                db.SaveChanges();
            }
        }

        //update Project
        public void EditProject(Project item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
