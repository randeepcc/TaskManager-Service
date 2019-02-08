using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManager.DAL;
using TaskManager.BL;
using System.Web.Http.Cors;

namespace TaskManager.API.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [Route("GetById/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(obj.GetTask(id));
            //return obj.GetTask(id);
        }

        // POST: api/Task
        public IHttpActionResult Post(Task item)
        {
            obj.AddTask(item);
            return Ok("Record saved successfully");
        }

        // PUT: api/Task/5

        [Route("UpdateTask")]  
        [HttpPut]
        public IHttpActionResult UpdateTask(Task item)
        {
            
            obj.Edit(item);
            return Ok("Record saved successfully");
        }

        [Route("EndTask")]
        [HttpPut]
        public void End(int id)
        {
        }

        // DELETE: api/Task/5
        [Route("DeleteTask/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteTask(int id)
        {
            obj.Delete(id);
            return Ok("Record deleted successfully");
        }
    }
}
