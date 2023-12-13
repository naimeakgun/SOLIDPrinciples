//CoffeeApplication için bazı test çağırımları:
using LiskovSubstitution;

Console.WriteLine("Coffee Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------\n");

var latte = new Latte();
latte.AddSugar();
latte.AddMilk();

Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

var mocha = new Mocha();
mocha.AddEspresso();
mocha.AddMilk();

Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

var filterCoffee = new FilterCoffee();
filterCoffee.AddFilterCoffee();
filterCoffee.AddSugar();




Console.WriteLine("\n\n\n");




//PaymentApplication için bazı test çağırımları:

Console.WriteLine("Payment Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------");

double cash = 100;
double paymentAmount = 80;
string customer = "Naime Akgün";
var cashPayment = new CashPayment(cash, paymentAmount, customer);
cashPayment.Pay();


Console.WriteLine("\n--------------------------------------------------------------------------------------\n");

var creditCardPayment = new CreditCardPayment(paymentAmount, customer);
creditCardPayment.Pay();