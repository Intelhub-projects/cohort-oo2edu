namespace SwiftEd.Models
{
    public class Admin : UserInfo
    {
        public int UserId {get;set;}
        public User User {get;set;}
        
    }
}