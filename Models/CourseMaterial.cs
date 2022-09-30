namespace SwiftEd.Models
{
    public class CourseMaterial : BaseEntity
    {
        public string Name {get;set;}
        public string Description {get;set;}
        public int CourseId {get;set;}
        public Course Course {get;set;}
        public string CourseMaterialContent {get;set;}
    }
}