using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPulse.Infrastructure.Models;

public class FocusSessionSmell
{
    public Guid FocusSessionId { get; set; }
    public FocusSession? FocusSession { get; set; }

    public Guid CodeSmellId { get; set; }
    public CodeSmell? CodeSmell { get; set; }
}
