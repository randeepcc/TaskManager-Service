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
    public class UserController : ApiController
    {
        // GET: api/User

        UsersBO obj = new UsersBO();

        [Route("GetAllUsers")]
        public IHttpActionResult Get()
        {
            return Ok(obj.GetAll());
        }

        // GET: api/Task/5
        [Route("GetUserById/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok(obj.GetUsers(id));
            //return obj.GetTask(id);
        }

        // POST: api/Task
        //[Route("AddUser")]
        //[HttpPost]
        public IHttpActionResult Post(UserDetail item)
        {
            obj.AddUser(item);
            return Ok("User saved successfully");
        }

        // PUT: api/Task/5

        [Route("UpdateUser")]
        [HttpPut]
        public IHttpActionResult UpdateTask(UserDetail item)
        {

            obj.EditUser(item);
            return Ok("User updated successfully");
        }

        [Route("EndProject")]
        [HttpPut]
        public void End(int id)
        {
        }
    }
}
