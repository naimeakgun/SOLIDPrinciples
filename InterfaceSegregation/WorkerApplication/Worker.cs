using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan worker interface ve bundan türeyen 
    ///     class'ları daha doğru sayabileceğimiz haliyle bir örnek yer almaktadır.
    /// Interface Segregation prensibi kullanılarak interface'ten türeyen classlar gerçekten sergileyebilecekleri
    ///     davranışların metotlarını implemente etme zorunluluğuna sahip oldular.
    /// Çünkü çalışanları tek bir interface'te toplamak yerine, özelliklerine göre sınıflandırmış olduk.
    /// Interface Segregation sayesinde class'larda NotImplemented durumda bir metot yazma durumu oluşmadı.
    /// </summary>
    public interface IManageable
    {
        void Manage();
    }

    public interface IWorkable
    {
        void Eat();
        void Work();
    }

    public class Manager : IManageable, IWorkable
    {
        public void Eat()
        {
            Console.WriteLine("Manager is eating..");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is managing..");
        }

        public void Work()
        {
            Console.WriteLine("Manager is working..");
        }
    }

    public class Worker : IWorkable
    {
        public void Eat()
        {
            Console.WriteLine("Worker is eating..");
        }

        public void Work()
        {
            Console.WriteLine("Worker is working..");
        }
    }
}
