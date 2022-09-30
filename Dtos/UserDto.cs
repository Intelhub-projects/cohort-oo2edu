using SwiftEd.Models;

namespace SwiftEd.Dtos
{
      public class UserDto
    {
        public int Id {get;set;}
       public string Email {get;set;} 
       public string PassWord {get;set;} 
       public AdminDto Admin {get;set;}
       public LecturerDto Lecturer {get;set;}
       public StudentDto Student {get;set;}
      
       public RoleDto Role {get;set;}

    }

  

    public class LoginUserDto
    {
         public string Email { get; set; }
        public string Password { get; set; }
    }
}