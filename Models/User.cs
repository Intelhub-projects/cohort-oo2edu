namespace SwiftEd.Models
{
    public class User : BaseEntity
    {
       public string Email {get;set;} 
       public string PassWord {get;set;} 
       public Admin Admin {get;set;}
       public Lecturer Lecturer {get;set;}
       public Student Student {get;set;}
       public Role Role {get;set;}
       public int RoleId {get;set;}
    }
}