using Microsoft.EntityFrameworkCore;

public class ApprovalsContext : DbContext
{
    public DbSet<Approval> Approvals { get; set; }

    public ApprovalsContext(DbContextOptions options) : base(options)
    {
    }
}
