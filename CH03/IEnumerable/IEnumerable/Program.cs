using System.Runtime.InteropServices;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ ID = 1, Name = "Jame", Gender = "Male"},
                new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //Linq Query to Fetch all students with Gender Male
            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;

            foreach (var student in QuerySyntax)
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
