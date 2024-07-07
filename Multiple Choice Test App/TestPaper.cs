using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    public class TestPaper : ITestPaper
    {
        private string subjectName;
        private string testPaperName;
        private List<IQuestion> questions;
        public string Subjectname { get => subjectName; set => subjectName = value; }
        public string TestPaperName { get => testPaperName; set => testPaperName = value; }
        List<IQuestion> ITestPaper.Questions { get => questions; set => questions = value; }
    }
}
