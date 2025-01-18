using BlogTest3.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlogTest3.Models;

namespace BlogTest3.Data;

public class BlogTest3Context : IdentityDbContext<BlogTest3User>
{
    public BlogTest3Context(DbContextOptions<BlogTest3Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<BlogTest3.Models.Blog> Blog { get; set; } = default!;
}
