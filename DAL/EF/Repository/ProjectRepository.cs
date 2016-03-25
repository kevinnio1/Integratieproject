using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
  public class ProjectRepository
  {
    private IntegratieProjectDbContext ctx = null;
    public ProjectRepository()
    {
      ctx = new IntegratieProjectDbContext();
    }

  }
}
