using System.Collections.Generic;
using System.Linq;
using UEPFeedbackServer.Data;
using UEPFeedbackServer.Interfaces;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Repositories
{
    public class UserDetailsRepository : IUserDetails
    {
        private BackEndData dbContext;

        public UserDetailsRepository(BackEndData context)
        {
            dbContext = context;
        }
        public List<UserDetails> GetUserDetails()
        {
            return dbContext.Userdetails.ToList();
        }
        public UserDetails GetUser(string name)
        {
            return dbContext.Userdetails.Where(x => x.Username == name).SingleOrDefault();
        }
    }
}
