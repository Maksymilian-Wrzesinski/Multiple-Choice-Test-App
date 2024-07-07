using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option
{
    internal interface IOption
    {
        char OptionLetter { get; set; }
        string OptionText { get; set; }
    }
}
