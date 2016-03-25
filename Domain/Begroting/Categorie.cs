using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Begroting
{
  public interface Categorie
  {

    [Required]
    string naam { get; set; }
    [Required]
    int categrieID { get; set; }

    

  }
}
