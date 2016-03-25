using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Begroting
{
  public class CategorieA : Categorie
  {
    public string naam { get; set; }
    [RegularExpression("[0-9]{2}")]
    public int categrieID { get; set; }

    IEnumerable<CategorieB> CategoriesB;


  }
}
