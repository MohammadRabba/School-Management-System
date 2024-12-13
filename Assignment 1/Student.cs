using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Student : Person
    {
        public static int nOfStudents = 0;
        public Student(string _name)
        {
            
            name = _name;
            
            addmitionDate = DateTime.Now;
            AssignedCourses = new List<Courses>();


        }
        public Student(int _id, string _name, int _age)
        {
            id = _id;
            name = _name;
            age = _age;
            addmitionDate = DateTime.Now;
            AssignedCourses = new List<Courses>();


        }
        public void EnrollInCourse(Courses course)
        {
            if (AssignedCourses.Contains(course))
                    {
                Console.WriteLine("This Student Exsist Before");
            }
            else{
                AssignedCourses.Add(course);
                Courses.nOfStudents =+ 1;
            }
        }
        public  void getStudentDetails()
        {

            Console.WriteLine($"id={id} , Name = {name} , Age = {age} , Admission Date is {addmitionDate} , School Name is {schoolName} ");
            foreach (Courses course in AssignedCourses)
            {
                Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} , Teacher Name is {course.teacherName}");
            }
        }
        public void getEnrolledCourses()
        {
            foreach (Courses course in AssignedCourses)
            {
                Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} , Teacher Name is {course.teacherName}");
            }
        }
        //public override void getAllCourses()
        //{
        //    foreach (Courses course in AssignedCourses)
        //    {
        //        Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} , Teacher Name is {course.teacherName}");
        //    }
        //}
       
    } }