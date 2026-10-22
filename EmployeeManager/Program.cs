namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> employees = new List<string>{
                "Ahmet Yılmaz",
                "Zeynep Demir",
                "Can Kaya",
                "Elif Çelik"
            };

            Console.WriteLine("Employee Management System");

            bool devam = true;
            while (devam)
            {


                List<string> MenuOptions = new List<string>
                {

                "\n1. Add New Employee",
                "2. List Employees",
                "3. Search Employee",
                "4. Delete Employee",
                "5. Exit"
                };

                ;
                foreach (string menuOption in MenuOptions)
                {
                    Console.WriteLine(menuOption);
                }

                Console.WriteLine("\n" + "Please select an option:");

                string option = Console.ReadLine();

                if (option == "5")
                {
                    devam = false;
                }


                switch (option)
                {
                    case "1":

                        Console.WriteLine("\n" + "Enter employee name:");
                        string newEmployee = Console.ReadLine();

                        if (newEmployee == "")
                        {
                            Console.WriteLine("Invalid name. Please do not leave blank.");
                        }
                        else if (employees.Contains(newEmployee))
                        {
                            Console.WriteLine("This employee already exists.");
                        }
                        else if (!string.IsNullOrWhiteSpace(newEmployee))
                        {
                            employees.Add(newEmployee);
                            Console.WriteLine($"{newEmployee} added. \n");

                        }

                        else
                        {
                            Console.WriteLine("Invalid name. Please do not leave blank.");
                        }

                        break;


                    case "2":

                        Console.WriteLine("\n" + "Registered Employees:" + "\n");
                        foreach (var employee in employees)
                        {
                            Console.WriteLine(employee);
                        }
                        break;


                    case "3":
                        Console.WriteLine("Enter the name of the employee you want to search for:");
                        string searchName = Console.ReadLine();
                        if (employees.Contains(searchName))
                        {
                            Console.WriteLine($"{searchName} found.");
                        }
                        else
                        {
                            Console.WriteLine($"{searchName} not found.");
                        }
                        break;


                    case "4":
                        Console.WriteLine("Enter the name of the employee you want to delete:");
                        string deleteName = Console.ReadLine();
                        if (employees.Contains(deleteName))
                        {
                            employees.Remove(deleteName);
                            Console.WriteLine($"{deleteName} deleted.");
                        }
                        else
                        {
                            Console.WriteLine($"{deleteName} not found.");
                        }
                        break;


                    case "5":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again. \n");
                        break;

                }

            }
            Console.WriteLine("\n" + string.Join(", ", employees));
        }
    }
}