using System.Runtime.Remoting.Messaging;

namespace LessonIncapsulation
{
    public class SubjectsData
    {
        public static Subjects Math()
        {
            Subjects subject1 = new Subjects()
            {
                Subject = "Math",
                ID = 1,
                WorkPrice = 11
            };

            return subject1;
        }

        public static Subjects Literature()
        {
            Subjects subject1 = new Subjects()
            {
                Subject = "Literature",
                ID = 2,
                WorkPrice = 9
            };


            return subject1;
        }

        public static Subjects English()
        {
            Subjects subject1 = new Subjects()
            {
                Subject = "English",
                ID = 3,
                WorkPrice = 12
            };


            return subject1;
        }
        
    }
}