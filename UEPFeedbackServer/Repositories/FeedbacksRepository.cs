using System.Collections.Generic;
using System.Linq;
using UEPFeedbackServer.Data;
using UEPFeedbackServer.Interfaces;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Repositories
{
    public class FeedbacksRepository : IFeedbacks
    {
        private BackEndData dbContext;
        public FeedbacksRepository(BackEndData context)
        {
            dbContext = context;
        }
        public List<Feedbacks> GetAllFeedbacks()
        {
            return dbContext.Feedbacks.ToList();
        }
        public void UpdateFeedbackbyPM(int ID, string PMComments)
        {
            var data = dbContext.Feedbacks.First(a => a.FK_Employeeid == ID);
            data.ProjectManagerComments = PMComments;
            dbContext.SaveChanges();
        }
    }
}
