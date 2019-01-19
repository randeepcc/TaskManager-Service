using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TaskManager.DAL;
using TaskManager.BL;

namespace TaskManager.UnitTest
{[TestFixture]
    public class TaskBOTest
    {
        [Test]
        public void testGetAll()
        {
            TaskBO obj = new TaskBO();
            int actual = obj.GetAll().Count;
            Assert.Greater(actual, 0);
        }

        [Test]
        public void testAdd()
        {
            TaskBO BO = new TaskBO();
            DAL.Task obj = new TaskManager.DAL.Task()
            {
                Name = "Task Unit",
                Priority = 2,
                ParentID = 4,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };

            BO.AddTask(obj);
            DAL.Task obj2 = BO.GetAll().Last();
            Assert.AreEqual(obj.Name, obj2.Name);

        }

    }
}
