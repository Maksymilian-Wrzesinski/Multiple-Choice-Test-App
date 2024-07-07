using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPaper
{
    internal interface ItestPaper
    {
        string Subjectname { get; set; }
        string TestPaperName { get; set; }

        List<IQuestion> questions { get; set; }
    }
}
