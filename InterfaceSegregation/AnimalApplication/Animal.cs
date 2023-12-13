namespace InterfaceSegregation
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan Animal Interface ve bundan türeyen 
    ///     class'lar Interface Segregation Prensibi'ne daha uygun sayabileceğimiz haliyle bir örnek yer almaktadır.
    /// Interface Segregation Prensibi kullanılarak interface'ten türeyen classlar gerçekten sergileyebilecekleri
    ///     davranışların metotlarını implemente etme zorunluluğuna sahip oldular.
    /// Çünkü hayvanları tek bir interface'te toplamak yerine, özelliklerine göre sınıflandırmış olduk.
    /// Interface Segregation sayesinde class'larda NotImplemented durumda bir metot yazma durumu oluşmadı.
    /// </summary>
    public interface IRunnable
    {
        void Run();
    }

    public interface IBarkable
    {
        void Bark();
    }

    public interface ISwimmable
    {
        void Swim();
    }


    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("Fish is swimming..");
        }
    }

    public class Dog : IRunnable, IBarkable, ISwimmable
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking..");
        }

        public void Run()
        {
            Console.WriteLine("Dog is running..");
        }

        public void Swim()
        {
            Console.WriteLine("Dog is swimming..");
        }
    }

    public class Cat : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Cat is running..");
        }
    }
}
