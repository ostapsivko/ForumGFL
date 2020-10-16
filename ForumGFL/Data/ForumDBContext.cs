using ForumGFL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumGFL.Data
{
    public class ForumDBContext : IdentityDbContext
    {
        public ForumDBContext(DbContextOptions<ForumDBContext> options)
            :base(options)
        { 
            
        }
        public DbSet<Topic> Topics { get; set; }

        public DbSet<ForumMessage> ForumMessage { get; set; }
    }
}
