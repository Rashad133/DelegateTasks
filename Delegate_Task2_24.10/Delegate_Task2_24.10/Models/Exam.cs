using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task2_24._10.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }= DateTime.Now;
        public DateTime EndDate { get; set; }=DateTime.Now;
    }
}
