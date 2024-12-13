using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Teacher : Person
    {
        public static int nOfTeachers = 0;
        public Teacher(string _name)
        {
            name = _name;
            addmitionDate = DateTime.Now;
            AssignedCourses = new List<Courses>();

        }
        public Teacher(int _id, string _name, int _age)
        {
            id = _id;
            name = _name;
            age = _age;
            addmitionDate = DateTime.Now;
            AssignedCourses = new List<Courses>();

        }
        public void assignCourse(Courses course)
        {
            if (AssignedCourses.Contains(course))
            {
                Console.WriteLine("This Teacher already Exsist Before");
            }
            else
            {
                course.addTeacher(name);
                AssignedCourses.Add(course);
            }
        }
        public  void getTeacherDetails()
        {

            Console.WriteLine($"id={id} , Name = {name} , Age = {age} , Admission Date is {addmitionDate} , School Name is {schoolName} ");
            foreach (Courses course in AssignedCourses)
            {
                Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} ");
            }
        }
        public void getAssignedCourses()
        {
            foreach (Courses course in AssignedCourses)
            {
                Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} ");
            }
        }
        //public override void getDetails()
        //{

        //    Console.WriteLine($"id={id} , Name = {name} , Age = {age} , Admission Date is {addmitionDate} , School Name is {schoolName} ");
        //    foreach (Courses course in AssignedCourses)
        //    {
        //        Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} ");
        //    }
        //}
    }
    } 