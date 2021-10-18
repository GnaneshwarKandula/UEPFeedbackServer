using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UEPFeedbackServer.Interfaces;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private IFeedbacks feedbacks;

        public FeedbacksController(IFeedbacks repository)
        {
            feedbacks = repository;
        }

        //GET: api/Feedbacks
        [HttpGet]
        public ActionResult<IEnumerable<Feedbacks>> GetFeedbacks()
        {
            return feedbacks.GetAllFeedbacks();
        }

        [HttpGet]
        [Route("updateComment/id")]
        public void UpdateFeedbackbyID(int id, string PMcomments)
        {
            feedbacks.UpdateFeedbackbyPM(id, PMcomments);
        }
    }
}
