using System;
using System.Collections.Generic;
namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManagement dm = new DataManagement();
            int check = 0;

            while (true)
            {
                Console.WriteLine("\n===== University Management System =====");
                Console.WriteLine("1. Find Student by Roll Number");
                Console.WriteLine("2. List All Students");
                Console.WriteLine("3. List All Courses");
                Console.WriteLine("4. List All Faculties");
                Console.WriteLine("5. Get All Students Sorted by Marks");
                Console.WriteLine("6. Get Average Marks of Each Department");
                Console.WriteLine("7. Get Faculties Teaching More Than 2 Courses");
                Console.WriteLine("8. Group Students by Department");
                Console.WriteLine("9. Top 3 Students by Marks");
                Console.WriteLine("10. Department-wise Student Count");
                Console.WriteLine("11. Faculty-Course Mapping");
                Console.WriteLine("-1. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out check))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (check == -1)
                {
                    Console.WriteLine("Exiting... Goodbye!");
                    break;
                }

                switch (check)
                {
                    case 1:
                        Console.Write("Enter your roll number: ");
                        string id = Console.ReadLine();
                        dm.FindStudent(id);
                        break;

                    case 2:
                        dm.ListStudents();
                        break;

                    case 3:
                        dm.ListCourses();
                        break;

                    case 4:
                        dm.ListFaculties();
                        break;

                    case 5:
                        dm.GetStudentsSortedByMarks();
                        break;

                    case 6:
                        dm.GetAverageMarksByDepartment();
                        break;

                    case 7:
                        dm.GetFacultiesWithMoreThanTwoCourses();
                        break;

                    case 8:
                        dm.GroupStudentsByDepartment();
                        break;

                    case 9:
                        dm.GetTop3StudentsByMarks();
                        break;

                    case 10:
                        dm.GetDepartmentWiseStudentCount();
                        break;

                    case 11:
                        //dm.GetFacultyCourseMapping();
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
