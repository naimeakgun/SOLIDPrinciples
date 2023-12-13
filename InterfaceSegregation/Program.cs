//AnimalApplication için bazı test çağırımları:
using InterfaceSegregation;

Console.WriteLine("Animal Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------\n");

var dog = new Dog();
dog.Bark();
dog.Run();

Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

var cat = new Cat();
cat.Run();


Console.WriteLine("\n\n\n");


//WorkerApplication için bazı test çağırımları:

Console.WriteLine("Worker Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------\n");

var worker = new Worker();
worker.Eat();
worker.Work();

Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

var manager = new Manager();
manager.Eat();
manager.Work();
manager.Manage();


Console.WriteLine("\n\n\n");