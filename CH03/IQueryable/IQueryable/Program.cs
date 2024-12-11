﻿namespace IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
                new Student(){ ID = 1, Name = "James", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}

            };

            //Linq Query to Fetch all students with Gender Male
            IQueryable<Student> MethodSyntax = studentList.AsQueryable()
                                .Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach (var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID} Name : {student.Name}");
            }

            Console.ReadKey();

        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
