using System.Collections.Generic;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Interfaces
{
    public interface IFeedbacks
    {
        List<Feedbacks> GetAllFeedbacks();
        public void UpdateFeedbackbyPM(int id, string pmcomments);
    }
}
