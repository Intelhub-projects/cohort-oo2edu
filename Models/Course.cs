using System.Collections.Generic;
namespace SwiftEd.Models
{
    public class Course : BaseEntity
    {
       public string Name {get;set;}
       public string Description {get;set;}
       public IList<CourseStudent> CourseStudent {get;set;} = new List<CourseStudent>();
       public IList<CourseMaterial> CourseMaterial {get;set;} = new List<CourseMaterial>();
       public IList<Lecturer> Lecturer {get;set;} = new List<Lecturer>();
    }
}