using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
    {
        class Student
        {
            public string Fullname;
            public int Course;
            public string Subject;
            public string University;
            public string Email;
            public int Phonenumber;

            public Student(string fullname, int course, string subject, string university, string email, int phonenumber)
            {
                Fullname = fullname;
                Course = course;
                Subject = subject;
                University = university;
                Email = email;
                Phonenumber = phonenumber;

            }
            public void Information()
            {
                Console.WriteLine($"{Fullname} {Course} {Subject} {University} {Email} {Phonenumber}");
            }



        }
    }

