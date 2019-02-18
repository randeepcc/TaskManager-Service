using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL;
using Task = TaskManager.DAL.UserDetail;

namespace TaskManager.BL
{
    public class UsersBO
    {
        public List<UserDetail> GetAll()
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.UserDetails.ToList();
            }
        }

        public UserDetail GetUsers(int ID)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                return db.UserDetails.Find(ID);
            }
        }

        //add User
        public void AddUser(UserDetail item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.UserDetails.Add(item);
                db.SaveChanges();
            }
        }

        //update UserDetail
        public void EditUser(UserDetail item)
        {
            using (TaskDBEntities db = new TaskDBEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
