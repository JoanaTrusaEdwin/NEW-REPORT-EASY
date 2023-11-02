using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NEW_REPORT_EASY.Models

public class AppDbContext : DbContext
{
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<AnonymousIncidentReport> AnonymousIncidentReports { get; set; }
    public DbSet<Incident> Incidents { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Urgency> Urgencies { get; set; }
    public DbSet<Media> Media { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("C:\\Users\\USER\\source\\repos\\JoanaTrusaEdwin\\Report-Easy\\Report Easy\\SqlQuery_1.sql\");
    }
}

