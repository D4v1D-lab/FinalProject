using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;


namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext (DbContextOptions<SacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }

        public DbSet<SacramentMeetingPlanner.Models.Speakers> Speakers { get; set; }
    }
}

