using System.Collections.Generic;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Interfaces
{
    public interface IUserDetails
    {
        List<UserDetails> GetUserDetails();
        UserDetails GetUser(string name);
    }
}
