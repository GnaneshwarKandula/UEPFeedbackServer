using System.ComponentModel.DataAnnotations;

namespace UEPFeedbackServer.Models
{
    public class UserDetails
    {
        private UserDetails user;

        [Key]
        public int PK_Employeeid { get; set; }
        public string Username { get; set; }
        public string Designation { get; set; }
        public string Emailid { get; set; }
        public string Password { get; set; }
        public string Projectname { get; set; }
        public string Projectid { get; set; }
        public string Projectmanager { get; set; }
    }
}
