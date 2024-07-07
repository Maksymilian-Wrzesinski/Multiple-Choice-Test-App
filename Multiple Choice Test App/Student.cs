using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    public class Student : IStudent
    {
        private int rollNo;
        private string studentName;
        private List<ITestPaper> testPaperList;
        public int RollNo { get => rollNo; set => rollNo = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        List<ITestPaper> IStudent.TestPapers { get => testPaperList; set => testPaperList = value; }
    }
}
