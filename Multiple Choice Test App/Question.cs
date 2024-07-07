using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    public class Question : IQuestion
    {
        private string questionText;

        private char correctAnswerLetter;

        private char optionSelected;

        private int marksSecured;

        private List<IOption> options;

        public string QuestionText { get => questionText; set => questionText = value; }
        public char CorrectAnswerLetter { get => correctAnswerLetter; set => correctAnswerLetter = value; }
        public char OptionSelectedByStudent { get => optionSelected; set => optionSelected = value; }
        public int MarksSecured { get => marksSecured; set => marksSecured = value; }
        List<IOption> IQuestion.Options { get => options; set => options = value; }
    }
}
