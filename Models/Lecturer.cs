using System.Collections.Generic;
namespace SwiftEd.Models
{
    public class Lecturer : UserInfo
    {
        public int UserId {get;set;}
        public User User {get;set;}
        public int CourseId {get;set;}
        public Course Course {get;set;}
        public IList<LecturerStudent> LecturerStudents {get;set;} = new List<LecturerStudent>();
    }
}