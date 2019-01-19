using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;
using Task = TaskManager.DAL.Task;

namespace TaskManager.BL
{
    public class TaskBO
    {
        public List<Task> GetAll()
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.Tasks.ToList();
            }
        }

        public Task GetTask(int ID)
        {
            return null;
        }

        //add task
        public void AddTask(Task item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Tasks.Add(item);
                db.SaveChanges();
            }
        }

        //update task
        public void Edit (Task item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        //delete
        public void Delete(int id)
        {

        }
    }
}
