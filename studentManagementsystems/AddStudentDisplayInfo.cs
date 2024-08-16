using StudentManagementSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    internal class AddStudentDisplayInfo
    {
        EnumImplementations enms = new EnumImplementations();
        StudentClass studentClass;
        public void MessageDisplay(List<StudentClass> students)
        {
            Console.WriteLine("<-----Add a New Student----->");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Middle Name (optional): ");
            string middleName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            long age = int.Parse(Console.ReadLine());

            Console.Write("Enter Roll No: ");
            long rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Class from 1 to 12th");
            enms.EnumClass();
            SchoolClass enumsclass = (SchoolClass)int.Parse(Console.ReadLine());

            // Subjects implementations
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            Console.WriteLine(
                "Enter the subject with commaa separated numbers (example)------>(Physic,100)");
            Console.WriteLine("if you have filled the subjects then (Types)----->Exit");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                var parts = input.Split(',');
                subjects.Add(parts[0], int.Parse(parts[1]));
            }

            // Hobbbies implementations

            List<string> Hobby = new List<string>();
            Console.WriteLine("Enter your Hobbies ");
            Console.WriteLine("You can add up to 7 hobbies");
            Console.WriteLine("If you have filled the hobbies, type 'exit' to stop.");

            while (true)
            {
                if (Hobby.Count >= 7)
                {
                    Console.WriteLine("You have reached the maximum number of hobbies.");
                    break;
                }

                string hobby = Console.ReadLine();

                if (hobby.ToLower() == "exit")
                {
                    break;
                }

                Hobby.Add(hobby);
            }

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            var studentss =
                new StudentClass(firstName, middleName, lastName, age, rollNo,
                                 enumsclass, subjects, Hobby, address

                );
            students.Add(studentss);
        }
    }
}
