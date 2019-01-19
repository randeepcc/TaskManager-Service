using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManager.DAL;
using TaskManager.BL;

namespace TaskManager.API.Controllers
{
    public class TaskController : ApiController
    {
        // GET: api/Task
        TaskBO obj = new TaskBO();

        [Route("GetAll")]
        public IHttpActionResult Get()
        {
            return Ok(obj.GetAll());
        }

        // GET: api/Task/5
        public IHttpActionResult Get(int id)
        {
            return Ok(obj.GetTask(id));
        }

        // POST: api/Task
        public IHttpActionResult Post(Task item)
        {
            obj.AddTask(item);
            return Ok("Record saved successfully");
        }

        // PUT: api/Task/5
        [Route("UpdateTask")]
        public void Put(Task item)
        {
        }

        [Route("EndTask")]
        [HttpPut]
        public void End(int id)
        {
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
        }
    }
}
