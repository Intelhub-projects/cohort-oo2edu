using System.Collections.Generic;
using SwiftEd.Models;

namespace SwiftEd.Dtos
{
    public class CourseDto
    {
        public int Id {get;set;}

        public string Name { get; set; }
        public string Description { get; set; }
        public IList<StudentDto> CourseStudent { get; set; }
        public IList<CourseMaterialDto> CourseMaterial { get; set; }
        public IList<LecturerDto> Lecturer { get; set; }
    }

    public class CreateCourseRequestModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
       
    }

    public class UpdateCourseRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
      
    }

}