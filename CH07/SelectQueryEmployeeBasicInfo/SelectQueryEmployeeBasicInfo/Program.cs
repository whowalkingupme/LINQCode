namespace SelectQueryEmployeeBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Query Syntax
            IEnumerable<EmployeeBasicInfo> selectQuery = (from emp in Employee.GetEmployees()
                                                          select new EmployeeBasicInfo()
                                                          {
                                                              FirstName = emp.FirstName,
                                                              LastName = emp.LastName,
                                                              Salary = emp.Salary
                                                          });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary}");
            }

            //Method Syntax
            List<EmployeeBasicInfo> selectMethod = Employee.GetEmployees()
                                                  .Select(emp => new EmployeeBasicInfo()
                                                  {
                                                      FirstName = emp.FirstName,
                                                      LastName = emp.LastName,
                                                      Salary = emp.Salary
                                                  }).ToList();

            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary}");
            }

            Console.ReadKey();

        }
    }
}
