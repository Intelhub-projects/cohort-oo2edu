using System.Collections.Generic;
using SwiftEd.Models;

namespace SwiftEd.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public IList<LecturerDto> Lecturers { get; set; }
    }
    public class CreateStudentRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassWord {get;set;} 
    }
    public class UpdateStudentRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassWord {get;set;} 
    }
}