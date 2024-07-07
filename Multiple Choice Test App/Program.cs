using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Choice_Test_App
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Test Paper 1:");
            ITestPaper testPaper1 = CreateTestPaper();

            Console.WriteLine("Enter Test Paper 2: ");
            ITestPaper testPaper2 = CreateTestPaper();

            Console.WriteLine("Enter Studnet: ");
            IStudent student = CreateStudent();
            Console.WriteLine("Student name: " + student.StudentName+"\n");

            Console.WriteLine("Test paper 1 name: " + testPaper1.TestPaperName);
            Console.WriteLine("Test paper 1 subject: " + testPaper1.Subjectname);
            TakeTestPaper(testPaper1);

            Console.WriteLine("Test paper 2 name: " + testPaper2.TestPaperName);
            Console.WriteLine("Test paper 2 subject: " + testPaper2.Subjectname);
            TakeTestPaper(testPaper2);

            Console.WriteLine("Your marks on exam 1: ");
            Console.WriteLine(CalculateMarks(testPaper1));

            Console.WriteLine("Your marks on exam 2: ");
            Console.WriteLine(CalculateMarks(testPaper2));

            Console.ReadLine();
            Console.ReadLine();




        }

        static ITestPaper CreateTestPaper() 
        {
            ITestPaper testPaper = new TestPaper();

            Console.Write("Enter subject name ");
            testPaper.Subjectname = Console.ReadLine();

            Console.Write("Enter test paper name ");
            testPaper.TestPaperName = Console.ReadLine();

            testPaper.Questions = new List<IQuestion>();
            for(int i = 1; i<= 10; i++) 
            {
                Console.WriteLine("\nEnter question number " + i + ": ");
                IQuestion question = CreateTestQuestion();
                testPaper.Questions.Add(question);
            }
            return testPaper;
        }

        static IQuestion CreateTestQuestion() 
        {
            IQuestion testQuestion = new Question();

            Console.Write("Enter question text: ");
            testQuestion.QuestionText = Console.ReadLine();

            testQuestion.Options = new List<IOption>();
            for(char optionLetter = 'A'; optionLetter <= 'D'; optionLetter++)
            {
                Console.Write("Enter option " + optionLetter + ": ");
                string optionText = Console.ReadLine();
                IOption option = new Option { OptionLetter = optionLetter , OptionText = optionText};
                testQuestion.Options.Add(option);
            }
            Console.Write("Enter correct anwser letter: ");
            testQuestion.CorrectAnswerLetter = char.ToUpper(Console.ReadKey().KeyChar);

            return testQuestion;
        }

        static IStudent CreateStudent() 
        {
            IStudent student = new Student();

            Console.Write("Enter Studnet Roll number: ");
            student.RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter student name: ");
            student.StudentName = Console.ReadLine();

            student.TestPapers = new List<ITestPaper>();

            return student;
        }

        static void TakeTestPaper(ITestPaper testPaper)
        {
            foreach(IQuestion question in testPaper.Questions)
            {
                Console.WriteLine(question.QuestionText);
                foreach(IOption option in question.Options)
                {
                    Console.WriteLine(option.OptionLetter + ": " + option.OptionText);
                }
                Console.Write("Enter your anwser:");
                question.OptionSelectedByStudent = Console.ReadLine().ToUpper()[0];
            }
        }

        static int CalculateMarks(ITestPaper testpaper1)
        {
            int marksScored = 0;
            foreach(IQuestion question in testpaper1.Questions)
            {
                if(question.OptionSelectedByStudent == question.CorrectAnswerLetter)
                {
                    marksScored++;
                }
            }
            return marksScored;
        }


    }
}
