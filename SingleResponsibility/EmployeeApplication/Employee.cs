using System.Drawing;

namespace SingleResponsibility
{
    /// <summary>
    /// Single Responsibility Prensibi'ne uygun olarak yazılmış bir Employee Uygulamasıdır.
    /// Toplamda 3 farklı class oluşturuldu:
    ///     Employee, Company ve Card.
    /// Bu sayede her class ve metot kendi sorumluluğunu üstlendi.
    /// Company üzerinde gerekli kayıt işlemi aslında Company class'ı içerisinde yazıldı, Employee tarafında çağırıldı.
    /// Aynı şekilde Card oluşturmak için gerekli işlem de Card class'ı içerisinde yazıldı.
    /// </summary>
    public class Employee
    {
        private Card card;
        private Company company;
        public Employee() 
        {
            card = new Card();
            company = new Company();
        }
        public void Register(string name)
        {
            //Create employee profile
            Console.WriteLine($"Creating employee profile for: {name}");

            //Send employee profile to company
            company.RegisterEmployee();


            //creating id-card process to create 
            card.PrintCard();
        }
    }

    public class Company
    {
        public void RegisterEmployee()
        {
            //Getting employee profile and adding to company
            Console.WriteLine("Registered employee to the Company");
        }
    }

    public class Card
    {
        public void DesignCard()
        {
            //Designed card types
        }

        public void PrintCard()
        {
            //Printing designed cards
            Console.WriteLine("Printing employee-id card");
        }
    }
}
