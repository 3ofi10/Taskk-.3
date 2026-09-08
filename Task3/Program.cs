using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Task3
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool running = true;
            while (running)
            {
                
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("1. Employees Screen");
                Console.WriteLine("2. Clients Screen");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
               
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        ShowEmployeesScreen();
                        break;
                    case "2":
                        ShowClientsScreen();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, press any key to try again...");
                        Console.ReadKey();
                        break;
                }

            }
            Console.Clear();
        }












        static void ShowEmployeesScreen() {
            Console.Clear();
            // Display the Employees in the list
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------------------Employees------------------------:");
            Console.ForegroundColor = ConsoleColor.White;
            var EmployeeManager = new GenericListManager<Employee>();
            EmployeeManager.Add(new Employee { Id = 1, Name = "Omar Aloufy", Salary = 5500 });
            EmployeeManager.Add(new Employee { Id = 2, Name = "Omar Shalaby", Salary = 7500 });
            EmployeeManager.Add(new Employee { Id = 3, Name = "Marwan Ehab", Salary = 9500 });
            EmployeeManager.Add(new Employee { Id = 4, Name = "Youssef Mahmoud", Salary = 11500 });


            Employee? employee = EmployeeManager.Find(e => e.Id == 3);
            List<Employee> HighSalaryemployees = EmployeeManager.Where(e => e.Salary > 7500);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("High Salary Employees:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var emp in HighSalaryemployees)
            {
                Console.WriteLine(emp);
            }

            EmployeeManager.Edit(
                e => e.Id == 1, new Employee { Id = 1, Name = "Omar Alofy", Salary = 6000 }
                );


            EmployeeManager.Delete(e => e.Id == 4);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Employee Count:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(EmployeeManager.GetCount());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last Created At:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(EmployeeManager.GetLastCreatedAt());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last Search At:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(EmployeeManager.GetLastSearchAt());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Logs:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var log in EmployeeManager.GetLogs())
            {
                Console.WriteLine(log);
            }
        }








        // Display the Client in the list
        static void ShowClientsScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------Clients------------------------:");
            var ClientManager = new GenericListManager<Client>();
            ClientManager.Add(new Client { Id = 1, Name = "Omar Aloufy", Email = "alofyomar511@gmail.com" });
            ClientManager.Add(new Client { Id = 2, Name = "Omar Shalaby", Email = "omar.shalaby@gmail.com" });
            ClientManager.Add(new Client { Id = 3, Name = "Marwan Ehab", Email = "marwan.ehab@gmail.com" });
            ClientManager.Add(new Client { Id = 4, Name = "Youssef Mahmoud", Email = "youssef.mahmoud@gmail.com" });
           
            Client? client = ClientManager.Find(c => c.Id == 2);
            List<Client> HighValueClients = ClientManager.Where(c => c.Id < 3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("High Value Clients:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var emp in HighValueClients)
            {
                Console.WriteLine(emp);
            }
            Console.ForegroundColor = ConsoleColor.White;
            ClientManager.Edit(
                c => c.Id == 1, new Client { Id = 1, Name = "Omar Alofy", Email = "alofyomar511@gmail.com" }
                );

            ClientManager.Delete(c => c.Id == 4);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Client Count:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ClientManager.GetCount());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last Created At:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ClientManager.GetLastCreatedAt());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last Search At:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ClientManager.GetLastSearchAt());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Logs:");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var log in ClientManager.GetLogs())
            {
                Console.WriteLine(log);
            }

        }


            
        
    }
}
