using System;

namespace LessonIncapsulation
{
    public class StudentsData
    {
        private static Students StudsData(int id)
        {
            Students stud1 = new Students
            {
                ID = 1,
                Year = "12",
                Fullname = "Koman Nadiy",
                PhoneNumber = "066233464",
                Adress = "Nadiyna 22"
            };

            Students stud2 = new Students
            {
                ID = 2,
                Year = "12",
                Fullname = "Zhelehivsky Zoryan",
                PhoneNumber = "065233454",
                Adress = "Zoryana 12"
            };

            Students stud3 = new Students
            {
                ID = 3,
                Year = "12",
                Fullname = "Samborsky Kvitan",
                PhoneNumber = "099233423",
                Adress = "Kvitna 10"
            };

            if (id < stud1.ID) id = 1;
            else if (id > stud3.ID) id = 3;

            if (stud1.ID == id) return stud1;
            else if (stud2.ID == id) return stud2;
            else if (stud3.ID == id) return stud3;
            else
            {
                Console.WriteLine("Error, wrong id");
                return null;
            }
        }

        /// <summary>
        /// Пошук студента по id
        /// </summary>
        /// <param name="a"></param>
        public static void PrintStud(int a)
        {
            Console.WriteLine("Name:"+ StudsData(a).Fullname);
            Console.WriteLine("Year:" + StudsData(a).Year);
            Console.WriteLine("Phone:" + StudsData(a).PhoneNumber);
        }

        public static void ShowAll()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Name:" + StudsData(i).Fullname);
                Console.WriteLine("Year:" + StudsData(i).Year);
                Console.WriteLine("Phone:" + StudsData(i).PhoneNumber);
            }
        }
    }
}

