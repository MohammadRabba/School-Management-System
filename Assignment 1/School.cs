using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class School
    {
        List<Student> students;
        List<Teacher> teachers;
        List<Courses> allCourses;
        public School() {
            students = new List<Student>();
            teachers = new List<Teacher>();
            allCourses = new List<Courses>();
        }
       

        public void addStuednt(Student student)
        { if(students==null) students = new List<Student>();
            
            if (checkifExsist(student.name)) {
                students.Add(student);
                Student.nOfStudents++;
            }
            else
            {
                Console.WriteLine("Student Exsist Before");

            }
        }
        public void addTeacher(Teacher teacher)
        {
            if (teachers == null) teachers= new List<Teacher>();
            if (checkifExsist(teacher.name))    
            {
                teachers.Add(teacher);
                Teacher.nOfTeachers++;

            }
            else
            {
                Console.WriteLine(" Teacher Exsist Before");

            }

        }
        public void addCourse(Courses courseName, String teacherName)
        {
            if (allCourses == null) allCourses = new List<Courses>();

            if (!checkifExsist(teacherName))
            {
                Console.WriteLine("No Teacher Exsist");
            }
            else
            {
                Teacher existingTeacher = new Teacher(teacherName);
                if (existingTeacher != null)
                {
                    existingTeacher.assignCourse(courseName); 
                    Courses.nOfCourses++; 
                }
                else
                {
                    Console.WriteLine("Teacher with the name " + teacherName + " not found.");
                }
            }
        }
        public void DisplayAllStuednts()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Studet Id = {student.id} , Student Name is {student.name} , Student Age = {student.age}");
            }
        }
        public void DisplayAllTeachers()
        {
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"teacher Id = {teacher.id} , teacher Name is {teacher.name} , teacher Age = {teacher.age}");
            }
        }
        public void DisplayAllCourses()
        {
            foreach (Courses courses in allCourses)
            {
                Console.WriteLine($"course Id = {courses.id} , course Name is {courses.courseName} , teacher Name = {courses.teacherName}");
            }
        }
        public bool checkifExsistStudent(string name)
        {
            Student teacher = new Student(name);
            if (students.Contains(teacher))
            {
                return false;
            }
            return true;
        }
        public bool checkifExsist(string name)
        {
            Teacher teacher = new Teacher(name);
            if (teachers.Contains(teacher))
            {
                return false;
            }
            return true;
        }
    }
}