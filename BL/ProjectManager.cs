using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace BL
{
  public class ProjectManager
  {
    private readonly ProjectRepository repo;

    public ProjectManager()
    {
      repo = new DAL.EF.ProjectRepository();
    }
  }
}
