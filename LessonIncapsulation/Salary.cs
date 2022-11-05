using System.Runtime.CompilerServices;

namespace LessonIncapsulation
{
    public class Salary
    {
        public double Count(Subjects subject, Teachers teacher) 
        {
            double result = 0;

            if(teacher.Experience <= 3)
              return subject.WorkPrice*teacher.HoursWorked*1.1;

            else if (teacher.Experience <= 15)
                return subject.WorkPrice*teacher.HoursWorked*1.3;

            else if (teacher.Experience <= 30)
                return subject.WorkPrice * teacher.HoursWorked * 1.6;

            else return result;
        }

    }
}
