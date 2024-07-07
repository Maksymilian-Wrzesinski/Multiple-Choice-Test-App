using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option
{
    public class Option : IOption
    {
        private char optionLetter;
        private string optionText;
        public char OptionLetter { get => optionLetter; set => optionLetter = value; }
        public string OptionText { get => optionText; set => optionText = value; }
    }
}
