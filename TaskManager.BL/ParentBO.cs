using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;
using Task = TaskManager.DAL.ParentTask;

namespace TaskManager.BL
{
    public class ParentBO
    {
        public List<ParentTask> GetAll()
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.ParentTasks.ToList();
            }
        }

        public ParentTask GetParentTasks(int ID)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.ParentTasks.Find(ID);
            }
        }

        //add Project
        public void AddParentTask(ParentTask item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.ParentTasks.Add(item);
                db.SaveChanges();
            }
        }

        //update Project
        public void EditParentTask(ParentTask item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
