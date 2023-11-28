//EmployeeApplication için bazı test çağırımları:
using SingleResponsibility;

Employee employee = new Employee();

Console.WriteLine("Employee Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------");
employee.Register("Employee1");
Console.WriteLine("\n\n");
employee.Register("Employee2");
Console.WriteLine("\n\n\n");






//ShoppingApplication için bazı test çağırımları:
Shopping shopping = new Shopping();
Console.WriteLine("Shopping Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------");
shopping.AddCart("Test Product 1");
Console.WriteLine("\n");
shopping.AddCart("Test Product 2");
Console.WriteLine("\n\n");
shopping.CreateOrder();
