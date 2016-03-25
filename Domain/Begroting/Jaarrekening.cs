using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Begroting
{
  public class Jaarrekening
  {
    private string groep { get; set; }
    private string naamBestuur { get; set; }
    private Actie actie { get; set; }
    private CategorieA categorieA { get; set; }
    private CategorieB categorieB { get; set; }
    private CategorieC categorieC { get; set; }
    private DateTime boekJaar { get; set; }
    private double uitgave { get; set; }
  }
}
