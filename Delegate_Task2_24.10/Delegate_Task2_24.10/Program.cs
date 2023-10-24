using Delegate_Task2_24._10.Models;

namespace Delegate_Task2_24._10
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>
            {
                new Exam { Subject="Kimya",ExamDuration=2, StartDate = DateTime.Now },
                new Exam { Subject="Riyaziyyat",ExamDuration=3, StartDate = DateTime.Now },
                new Exam {Subject="Ingilis-dili",ExamDuration=1, StartDate = DateTime.Now },
                new Exam {Subject="Fizika",ExamDuration=4,StartDate = DateTime.Now  },
                new Exam {Subject="Az/dili",ExamDuration=2,StartDate = DateTime.Now  },
            };


        }
    }
}