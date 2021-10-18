using System;
using System.ComponentModel.DataAnnotations;

namespace UEPFeedbackServer.Models
{
    public class Feedbacks
    {
        [Key]
        public int PK_Feedbackid { get; set; }
        public int FK_Employeeid { get; set; }
        public string EmployeeComments { get; set; }
        public int Ratings { get; set; }
        public string ProjectManagerComments { get; set; }
        public Boolean StatusApprovalbyPM { get; set; }
        public Boolean StatusApprovalbyCM { get; set; }
        public string CompetencyManagerComments { get; set; }
        public int Questionid { get; set; }
        public string EmployeeResponse { get; set; }
    }
}
