using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Person
    {
        
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public DateTime addmitionDate { get; set; }
            public const string schoolName = "Palestine School";
        public List<Courses> AssignedCourses { get; set; }
        //public virtual void getDetails()
        //{

        //    Console.WriteLine($"id={id} , Name = {name} , Age = {age} , Admission Date is {addmitionDate} , School Name is {schoolName} ");
        //    foreach (Courses course in AssignedCourses) {
        //        Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} , Teacher Name is {course.teacherName}");
        //    }
        //}
        //public virtual void getAllCourses()
        //{
        //    foreach (Courses course in AssignedCourses)
        //    {
        //        Console.WriteLine($"course id = {course.id} , Course Name = {course.courseName} ");
        //                }
        //}
    }
}
