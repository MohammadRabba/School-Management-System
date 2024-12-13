using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Courses
    {
        public int id { get; set; }
        public string courseName { get; set; }
        public string teacherName { get; set; }
        public static int nOfCourses = 0;
        public static int nOfStudents = 0;
        public Courses(int _id,string _courseName)
        {id= _id; courseName= _courseName; 
        }
        public void addTeacher(string _teacherName)
        {
            teacherName = _teacherName;
        }
        public void getCoursDetails()
        {

            Console.WriteLine($"id={id} , Name = {courseName} , Teacher Name = {teacherName}");

        }
        public void displayAllCourses(Courses[] courses)
        {
            foreach (Courses course in courses)
            {
                Console.WriteLine($"id={course.id} , Name = {course.courseName} , Teacher Name = {course.teacherName}");
            }
        }

    }
}