using IQueryable.Models;

namespace IQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new LinqcodeContext())
            {
                //Fetch the Top 2 Records from the Students Database table where Gender = Male
                IQueryable<Student> listStudents = dbContext.Students
                                   .AsQueryable()
                                   .Where(x => x.Gender == "Male");
                listStudents = listStudents.Take(2);
                Console.WriteLine("Top 2 Student Where Gender = Male");
                foreach (var std in listStudents)
                {
                    Console.WriteLine(std.FirstName + " " + std.LastName);
                }

                Console.ReadKey();
            }
        }
    }
}
