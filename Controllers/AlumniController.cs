using System;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.AspNetCore.Mvc;

namespace finalPOCService.Controllers
{
    [ApiController]
    [Route("exl/[controller]")]
    public class AlumniController : ControllerBase
    {
        IAlumni alumni;
        public AlumniController(IAlumni _alumni)
        {
            alumni = _alumni;
        }

        [HttpGet]
        [Route("Get Alumni Details")]
        public IActionResult getalumnidetails()
        {
            return Ok(alumni.GetAlumni());
        }

        [HttpPost]
        [Route("Add Alumni Details")]
        public IActionResult addemployeedetails(Alumni alum)
        {
            return Ok(alumni.AddAlumni(alum));
        }

        [HttpGet]
        [Route("Search Alumni")]
        public IActionResult searchemployee(int rollno)
        {
            var res = alumni.SearchAlumniByRollno(rollno);
            if ( res == null)
            {
                return Ok("Alumni Not found!. Enter correct Roll no");
            }
            return Ok(res);
        }
        
        [HttpDelete]
        [Route("Delete Alumni ")]
        public IActionResult DeleteAlumniByRollno(int rollno)
        {
            return Ok(alumni.DeleteAlumniByRollno(rollno));
        }
    }
}