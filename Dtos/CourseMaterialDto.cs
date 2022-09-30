using Microsoft.AspNetCore.Http;
using SwiftEd.Models;

namespace SwiftEd.Dtos
{
    public class CourseMaterialDto
    {
        public int Id {get;set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public CourseDto Course { get; set; }
        public string CourseMaterialContent { get; set; }
    }

    public class CreateCourseMaterialRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId {get;set;}
        public IFormFile CourseMaterialContent { get; set; }
    }

    public class UpdateCourseMaterialRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseMaterialContent { get; set; }
    }
}