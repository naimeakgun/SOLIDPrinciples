//DatabaseApplication için bazı test çağırımları:
using DependencyInversion;

Console.WriteLine("Database Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------\n");

var mongoDbService = new MongoDbService(new Database());
mongoDbService.ConnectionString = "test....";
if (mongoDbService.Connect())
{
    Console.WriteLine("MongoDb connection is successful.");
}
else
{
    Console.WriteLine("MongoDb connection is unsuccessful.");
}

Console.WriteLine("\n--------------------------------------------------------------------------------------\n\n\n");



//MessageApplication için bazı test çağırımları:
Console.WriteLine("Message Application Informations");
Console.WriteLine("---------------------------------- Sending Email ---------------------------------------\n");

var emailService = new EmailService("to", "cc", "bcc", "sending message", new EmailMessage());
emailService.SendEmail();

Console.WriteLine("---------------------------------- Sending SMS ------------------------------------------\n");


var smsService = new SMSService("phone number", "sending message", new SMSMessage());
smsService.SendSMS();