using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace LessonIncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Input student's id:");
              StudentsData.PrintStud(Int32.Parse(Console.ReadLine()));
              Console.WriteLine("Input teacher's id:");
              TeachersData.PrintTeach(Int32.Parse(Console.ReadLine()));
              Console.WriteLine("Input '1' Show all student data, '2' if show all teacher data,'3 ' count teacher salary");

              switch (Console.ReadLine())
              {
                  case "1":
                      StudentsData.ShowAll();
                      break;

                  case "2":
                      TeachersData.ShowAll();
                      break;

                  case "3":
                      Subjects sub = new Subjects();
                      Salary salary = new Salary();
                      Console.WriteLine("Enter teacher's id");
                      salary.Count(sub, TeachersData.TeacherDT(Int32.Parse(Console.ReadLine())));
                      break;

                  default:
                      Console.WriteLine("Wrong data");
                      break;

              }

            
            
        }
    }
}
