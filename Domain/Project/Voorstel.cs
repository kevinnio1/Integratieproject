using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Project
{
  public class Voorstel
  {
    private DateTime datum { get; set; }
    private Uri VideoURL { get; set; }
    IEnumerable<Comment> comments { get; set; }
    private VoorstelDetail voorstelDetail { get; set; }
  }
}
