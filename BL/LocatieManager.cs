using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public class LocatieManager
  {
    private readonly LocatieRepository repo;

    public LocatieManager()
    {
      repo = new DAL.EF.LocatieRepository();
    }
  }
}
