using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Project
{
  public class Project
  {
    private DateTime beginDatum { get; set; }
    private DateTime eindDatum { get; set; }
    private String text { get; set; }
    private Soort type { get; set; }
    private Status status { get; set; }
    private IEnumerable<Voorstel> voorstellen { get; set; }
    private ProjectDetail projectDetail { get; set; }
  }
}
