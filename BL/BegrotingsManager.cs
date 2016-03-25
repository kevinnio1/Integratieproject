using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace BL
{
  public class BegrotingsManager
  {
    private readonly BegrotingsRepository repo;

    public BegrotingsManager()
    {
      repo = new DAL.EF.BegrotingsRepository();
    }
  }
}
