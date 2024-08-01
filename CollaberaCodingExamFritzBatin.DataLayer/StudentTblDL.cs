using CollaberaCodingExamFritzBatin.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CollaberaCodingExamFritzBatin.DataLayer
{

    public class StudentTblDL
    {
        private readonly CollaberaDbContext _context;
        public StudentTblDL(CollaberaDbContext context)
        {
            _context=context;
        }

        public  Task<List<StudentTbl>> GetAllStudents()
        {
            return _context.StudentTbls.ToListAsync();
        }

        public async Task<StudentTbl?> GetStudent(int Id)
        {
            var student = await _context.StudentTbls.FindAsync(Id);
            if (student == null)
            {
                return null;
            }

            return student;

        }

        public async Task<StudentTbl> AddStudent(AddStudent entity)
        {

            var student = new StudentTbl()
            {
               
                Name = entity.Name,
                CityId = entity.CityId,
                CourseId = entity.CourseId,
                GenderId = entity.GenderId,
            };

            await _context.StudentTbls.AddAsync(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<StudentTbl?> UpdateStudent(int Id , UpdateStudent entity)
        {
            var student = await _context.StudentTbls.FindAsync(Id);
            if(student == null)
            {
                return null;
            }

            //student.Id = entity.Id;
            student.Name = entity.Name;
            student.CityId = entity.CityId;
            student.CourseId = entity.CourseId;
            student.GenderId = entity.GenderId;

            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<StudentTbl?> DeleteStudent(int Id)
        {
            var student = await _context.StudentTbls.FindAsync(Id);
            if (student == null)
            {
                return null;
            }

            _context.Remove(student);
            await _context.SaveChangesAsync();

            return student;

        }
    }
}