using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using EFRepo;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pocos;

namespace StudentAPI.Controllers
{
    [Route("api/Student/v1")]
    [ApiController]
    public class StudentController : ControllerBase

    {
        private readonly StudentLogic _logic;

        public StudentController()
        {
            var repo = new EfRepo();
            _logic = new StudentLogic(repo);

        }

        [HttpGet]
        [Route("get/id")]
        public ActionResult GetStudent([FromBody]Guid id)

        {
            StudentPoco poco = _logic.Get(id);

            if (poco == null)
            {
                //404
                return NotFound();

            }
            else
            {
                //200 
                return Ok(poco);

            }
        }

        [HttpPost]
        [Route("post")]
        public ActionResult PostStudent([FromBody]StudentDto student)
        {
       
            _logic.Create(student);
                return Ok();
        }
        

        [HttpPut]
        [Route("update")]
        public ActionResult UpdateStudent([FromBody]StudentDto student)
        {
            _logic.Update(student);
            return Ok();
        }


        [HttpDelete]
        [Route("delete")]

        public ActionResult DeleteStudent([FromBody]Guid id)
        {
            _logic.Delete(id);
            return Ok();
        }

    }  
}
