namespace dictio


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                new Employee(1, "CEO", "Sefris", 66, 200),
                new Employee(2, "Lead Developer", "Griselbrand", 43, 150),
                new Employee(3, "Designer", "Minn", 39, 170),
                new Employee(4, "Full-Stack Developer", "Farideh", 31, 120),
                new Employee(5, "Intern", "Omnath", 23, 100),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {
                {0, "zero"},
                {1, "one" },
                {2, "two"},
                {3, "three" },
                {4, "four"},
                {5, "five"}
            };

            



                Dictionary<int, Employee> employeesDirectory = new Dictionary<int, Employee>();
            foreach (Employee emp in employees) 
            {
                employeesDirectory.Add(emp.ID, emp);
            }

            //Update entry on a Dictionary
            int KeyToUpdate = 4;
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee(KeyToUpdate, "Full-Stack Developer", "Niv", 12000, 100);
            }

            //Remove entry 
            int KeyToRemove = 5;
            if (employeesDirectory.Remove(KeyToRemove))
            {
                Console.WriteLine($"The employee with ID {KeyToRemove} was removed");
            }

            for (int i =  0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<int, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine($"Employee ID: {employeeValue.ID}");
                Console.WriteLine($"Employee Name: {employeeValue.Name}");
                Console.WriteLine($"Employee Age: {employeeValue.Age}");
                Console.WriteLine($"Employee Role: {employeeValue.Role}");
                Console.WriteLine($"Employee Salary: {employeeValue.Salary}");

            }
            

            Employee empl = employeesDirectory[3];
            // Console.WriteLine($"The ID of this employee is the number {empl.ID}, his name is {empl.Name}, he/she is {empl.Age} years old and has a rate of {empl.Rate}, making his/her salary be: {empl.Salary}");

            Employee result = null;
            int idResult = int.Parse(Console.ReadLine());
            if (employeesDirectory.TryGetValue(idResult, out result))
            {
                Console.WriteLine("Value retrieved.");
                Console.WriteLine($"Employee ID: {result.ID}");
                Console.WriteLine($"Employee Name: {result.Name}");
                Console.WriteLine($"Employee Age: {result.Age}");
                Console.WriteLine($"Employee Role: {result.Role}");
                Console.WriteLine($"Employee Salary: {result.Salary}");
            }
            else
            {
                Console.WriteLine("There is not employee with the given ID.");
            }


        }
    }
}