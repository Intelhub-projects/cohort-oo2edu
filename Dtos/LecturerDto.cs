using System.Collections.Generic;
using SwiftEd.Models;

namespace SwiftEd.Dtos
{
    public class LecturerDto
    {
        public int Id {get;set;}
        public UserDto User { get; set; }
        public CourseDto Course { get; set; }
        public IList<StudentDto> Students { get; set; }
    }

    public class CreateLecturerRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassWord {get;set;} 

    }
    public class UpdateLecturerRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassWord {get;set;} 

    }


}