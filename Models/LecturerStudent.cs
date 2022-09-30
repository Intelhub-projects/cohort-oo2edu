namespace SwiftEd.Models
{
    public class LecturerStudent : BaseEntity
    {
        public int StudentId {get;set;}
        public Student Student {get;set;}
        public int LecturerId {get;set;}
        public Lecturer Lecturer {get;set;}
        
    }
}