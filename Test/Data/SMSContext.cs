using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class SMSContext : DbContext
    {
        public SMSContext (DbContextOptions<SMSContext> options)
            : base(options)
        {
        }

        public DbSet<Test.Models.SendSMS> SendSMS { get; set; }
    }
}