using CollaberaCodingExamFritzBatin.BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace CollaberaCodingExamFritzBatin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly CollaberaDbContext _context;
        private StudentTblBL _studentTblBL;

        public StudentsController(CollaberaDbContext context)
        {
            _context=context;
        }


        [HttpGet]
        [Route("{StudentId:int}")]
        public async Task<IActionResult> GetStudent([FromRoute] int StudentId)
        {
            _studentTblBL = new StudentTblBL(_context);
            
            var result = await _studentTblBL.GetStudent(StudentId);

            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            _studentTblBL = new StudentTblBL(_context);

            return Ok(await _studentTblBL.GetAllStudents());
        }

        [HttpPost] 
        public async Task<IActionResult> CreateStudent(AddStudent entity)
        {
            if(entity == null)
            {
                return BadRequest();
            }
            else
            {
                _studentTblBL = new StudentTblBL(_context);
                return Ok(await _studentTblBL.AddStudent(entity));
            }
        }

        [HttpPut]
        [Route("{StudentId:int}")]
        public async Task<IActionResult> UpdateStudent([FromRoute] int StudentId, UpdateStudent entity)
        {
           
            if (entity == null)
            {
                return BadRequest();
            }
            else
            {
                _studentTblBL = new StudentTblBL(_context);
                var result = await _studentTblBL.UpdateStudent(StudentId, entity);

                return result != null ? Ok(result) : NotFound();
            }

        }

        [HttpDelete]
        [Route("{StudentId:int}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] int StudentId)
        {
            _studentTblBL = new StudentTblBL(_context);
            
            var result = await _studentTblBL.DeleteStudent(StudentId);

            return result != null ? Ok(result) : NotFound();
        }
    }
}
