using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
  public class LocatieRepository
  {
    private IntegratieProjectDbContext ctx = null;
    public LocatieRepository()
    {
      ctx = new IntegratieProjectDbContext();
    }

  }
}
