using CollaberaCodingExamFritzBatin.DataLayer;
using CollaberaCodingExamFritzBatin.Model;
using Microsoft.EntityFrameworkCore;

namespace CollaberaCodingExamFritzBatin.BusinessLayer
{
    public class StudentTblBL
    {
        private StudentTblDL _studentTblDL;
        private CollaberaDbContext _context;

        public StudentTblBL(CollaberaDbContext context)
        {
            _context=context;
        }

        public Task<List<StudentTbl>> GetAllStudents()
        {
            _studentTblDL = new StudentTblDL(_context);

            return _studentTblDL.GetAllStudents();
        }

        public Task<StudentTbl?> GetStudent(int Id)
        {
            _studentTblDL = new StudentTblDL(_context);

            return _studentTblDL.GetStudent(Id);
        }

        public Task<StudentTbl> AddStudent(AddStudent student)
        {
            _studentTblDL = new StudentTblDL(_context);

            return _studentTblDL.AddStudent(student);
        }

        public Task<StudentTbl?> UpdateStudent(int Id, UpdateStudent student)
        {
            _studentTblDL = new StudentTblDL(_context);

            return _studentTblDL.UpdateStudent(Id, student);
        }

        public Task<StudentTbl?> DeleteStudent(int Id)
        {
            _studentTblDL = new StudentTblDL(_context);

            return _studentTblDL.DeleteStudent(Id);
        }
    }
}