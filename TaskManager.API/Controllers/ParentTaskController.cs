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
    public class ParentTaskController : ApiController
    {
        ParentBO obj = new ParentBO();

        [Route("GetAllParentTasks")]
        public IHttpActionResult Get()
        {
            return Ok(obj.GetAll());
        }

        // GET: api/Project/5
        [Route("GetParentTaskById/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(obj.GetParentTasks(id));
        }

       
        public IHttpActionResult Post(ParentTask item)
        {
            obj.AddParentTask(item);
            return Ok("Task saved successfully");
        }

        // PUT: api/Project/5

        [Route("UpdateParentTask")]
        [HttpPut]
        public IHttpActionResult UpdateTask(ParentTask item)
        {
            obj.EditParentTask(item);
            return Ok("Record saved successfully");
        }

        [Route("EndParent")]
        [HttpPut]
        public void End(int id)
        {
        }

    }
}
