using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Project;
using Domain.Begroting;

namespace DAL.EF
{
  [DbConfigurationType(typeof(IntegratieProjectDbConfiguration))]
  public class IntegratieProjectDbContext : DbContext
  {
    public IntegratieProjectDbContext() : base("DefaultConnection")
    {
    }
    public DbSet<Project> Project { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Voorstel> Voorstellen { get; set; }
    public DbSet<Begroting> Begrotingen { get; set; }
    public DbSet<Categorie> Categorieen { get; set; }
    public DbSet<Jaarrekening> jaarrekeningen { get; set; }
    
  }
}
