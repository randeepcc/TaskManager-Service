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
    public class ProjectController : ApiController
    {
        
        ProjectBO obj = new ProjectBO();

        [Route("GetAllProjects")]
        public IHttpActionResult Get()
        {
            return Ok(obj.GetAll());
        }

        // GET: api/Task/5
        [Route("GetProjectById/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(obj.GetProject(id));
            //return obj.GetTask(id);
        }

        // POST: api/Task
        [Route("UpdateProject")]
        [HttpPost]
        public IHttpActionResult Post(Project item)
        {
            obj.AddProject(item);
            return Ok("Project saved successfully");
        }

        // PUT: api/Task/5

        [Route("UpdateProject")]
        [HttpPut]
        public IHttpActionResult UpdateTask(Project item)
        {

            obj.EditProject(item);
            return Ok("Record saved successfully");
        }

        [Route("EndProject")]
        [HttpPut]
        public void End(int id)
        {
        }

        
    }
}
