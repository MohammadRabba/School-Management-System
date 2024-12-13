using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            //o	Create instances of at least three students and two teachers.
            Student student1 = new Student(1, "Ahmad", 20);
            Student student2 = new Student(2, "khaled", 20);
            Student student3 = new Student(3, "Yousef", 21);
            Teacher teacher1 = new Teacher(1, "Bahaa", 35);
            Teacher teacher2 = new Teacher(2, "Basil", 33);
            ///o	Create two courses and assign them to the teachers.
            Courses java = new Courses(1, "Java");
            Courses python = new Courses(2, "python");
            //o	Add the students, teachers, and courses to the school.
            school.addStuednt(student1);

            school.addStuednt(student2);

            school.addStuednt(student3);
            school.addTeacher(teacher1);
            school.addTeacher(teacher2);
            school.addCourse(python, "Basil");
            school.addCourse(java, "Bahaa");
            //o	Enroll the students in the courses.

            student1.EnrollInCourse(python);
            student2.EnrollInCourse(python);
            student2.EnrollInCourse(java);

            student3.EnrollInCourse(java);
            ///o	Display the details of all students, teachers, and courses.
            student1.getStudentDetails();
            student2.getStudentDetails();
            student3.getStudentDetails();
            teacher1.getTeacherDetails();
            teacher2.getTeacherDetails();

            python.getCoursDetails();
            java.getCoursDetails();
            //o	Print the school name and the total number of teachers.
            printData();
        }
        public static void printData()
        {

            Console.WriteLine(value: $"School Name is {Person.schoolName} , The Number of Teachers is {Teacher.nOfTeachers}");

        }
    }
    
}