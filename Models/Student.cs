using System.Collections.Generic;
namespace SwiftEd.Models
{
    public class Student : UserInfo
    {
        public int UserId {get;set;}
        public User User {get;set;}
        public IList<LecturerStudent> LecturerStudents {get;set;} = new List<LecturerStudent>();
    }
}