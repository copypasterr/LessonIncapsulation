using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonIncapsulation
{
    public class TeachersData
    {
        public static Teachers TeacherDT(int id)
        {
            Teachers teach1 = new Teachers
            {
                ID = 1,
                Subject = SubjectsData.Literature(),
                Fullname = "Koman Nadiy",
                PhoneNumber = "066233464",
                HoursWorked = 96,
                Experience = 15
            };

            Teachers teach2 = new Teachers
            {
                ID = 2,
                Subject = SubjectsData.English(),
                Fullname = "Zhelehivsky Zoryan",
                PhoneNumber = "065233454",
                HoursWorked = 135,
                Experience = 2
            };

            Teachers teach3 = new Teachers
            {
                ID = 3,
                Subject = SubjectsData.Math(),
                Fullname = "Samborsky Kvitan",
                PhoneNumber = "099233423",
                HoursWorked = 150,
                Experience = 35
            };

            if (id < teach1.ID) id = 1;
            else if (id > teach3.ID) id = 3;

            if (teach1.ID == id) return teach1;
            else if (teach2.ID == id) return teach2;
            else if (teach3.ID == id) return teach3;
            else
            {
                Console.WriteLine("Error, wrong id");
                return null;
            }
        }


        /// <summary>
        /// Пошук вчителя по id
        /// </summary>
        /// <param name="a"></param>
        public static void PrintTeach(int a)
        {
            Console.WriteLine("Name:" + TeacherDT(a).Fullname);
            Console.WriteLine("Subject:" + TeacherDT(a).Subject);
            Console.WriteLine("Phone:" + TeacherDT(a).PhoneNumber);
        }


        public static void ShowAll()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Name:" + TeacherDT(i).Fullname);
                Console.WriteLine("Subject:" + TeacherDT(i).Subject);
                Console.WriteLine("Phone:" + TeacherDT(i).PhoneNumber);
            }
        }

    }
}
