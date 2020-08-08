using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using StudentRegApp.Models.ConData;

namespace StudentRegApp.Data
{
  public partial class ConDataContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public ConDataContext(DbContextOptions<ConDataContext> options):base(options)
    {
    }

    public ConDataContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<StudentRegApp.Models.ConData.Student>()
              .HasOne(i => i.Gender)
              .WithMany(i => i.Students)
              .HasForeignKey(i => i.GenderID)
              .HasPrincipalKey(i => i.GenderID);
        builder.Entity<StudentRegApp.Models.ConData.Student>()
              .HasOne(i => i.Class1)
              .WithMany(i => i.Students)
              .HasForeignKey(i => i.CurrentClassID)
              .HasPrincipalKey(i => i.ClassID);


        this.OnModelBuilding(builder);
    }


    public DbSet<StudentRegApp.Models.ConData.Class1> Class1s
    {
      get;
      set;
    }

    public DbSet<StudentRegApp.Models.ConData.Gender> Genders
    {
      get;
      set;
    }

    public DbSet<StudentRegApp.Models.ConData.Student> Students
    {
      get;
      set;
    }
  }
}
