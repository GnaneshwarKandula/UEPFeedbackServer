using Microsoft.EntityFrameworkCore;
using UEPFeedbackServer.Models;

namespace UEPFeedbackServer.Data
{
    public class BackEndData : DbContext
    {
        public BackEndData(DbContextOptions<BackEndData> options) : base(options) { }
        public DbSet<UserDetails> Userdetails { get; set; }
        public DbSet<Feedbacks> Feedbacks { get; set; }
    }
}
