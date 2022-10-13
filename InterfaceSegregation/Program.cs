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