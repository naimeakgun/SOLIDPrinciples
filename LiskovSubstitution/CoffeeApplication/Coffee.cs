namespace LiskovSubstitution
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan coffee base class ve bundan türeyen 
    ///     kahve class'larının daha doğru sayabileceğimiz haliyle bir örnek yer almaktadır.
    /// Liskov Subtitution Prensibi kullanılarak base'den türeyen classlar base olarak nitelendirebiliyor tümüyle artık.
    /// Yani Latte, hem IEspresso'dan hem de ICoffee'den türediği ve bütün özelliklerini taşıdığı için 
    ///     aynı zamanda espresso bazlıdır ve bir kahvedir diyebiliyoruz.
    /// Aynı şekilde, FilterCoffe sadece ICoffee'den türediği için aynı zamanda kahvedir diyebiliyoruz.
    ///     Not: FilterCoffee espresso bazlı olmadığı için IEspresso'dan türetilmedi. 
    ///          Farklı olarak filtre kahve bazlı olduğu için ona özel AddFilterCoffee() metodu eklendi. 
    /// Liskov sayesinde class'larda NotImplemented durumda bir metot yazma durumu oluşmadı.
    /// </summary>
    public interface IEspresso
    {
        void AddEspresso();
    }

    public interface ICoffee
    {
        void AddMilk();
        void AddSugar();
    }

    public class Latte : IEspresso, ICoffee
    {
        public Latte()
        {
            Console.WriteLine("***Latte Order is being prepared.");
        }

        public void AddEspresso()
        {
            Console.WriteLine("\t ***Added one shot espresso to Latte");
        }

        public void AddMilk()
        {
            Console.WriteLine("\t ***Added 200ml milk to Latte");
        }

        public void AddSugar()
        {
            Console.WriteLine("\t ***Added one tea spoon sugar to Latte");
        }
    }

    public class FilterCoffee : ICoffee
    {
        public FilterCoffee()
        {
            Console.WriteLine("***Filter Coffee Order is being prepared.");
        }

        public void AddFilterCoffee()
        {
            Console.WriteLine("\t ***Added 100ml Filter Coffee to Filter Coffee");
        }

        public void AddMilk()
        {
            Console.WriteLine("\t ***Added 200ml milk to Filter Coffee");
        }

        public void AddSugar()
        {
            Console.WriteLine("\t ***Added one tea spoon sugar to Filter Coffee");
        }
    }
    public class Mocha : IEspresso, ICoffee
    {
        public Mocha()
        {
            Console.WriteLine("***Mocha Order is being prepared.");
        }

        public void AddEspresso()
        {
            Console.WriteLine("\t ***Added one shot espresso to Mocha");
        }

        public void AddMilk()
        {
            Console.WriteLine("\t ***Added 200ml milk to Mocha");
        }

        public void AddSugar()
        {
            Console.WriteLine("\t ***Added one tea spoon sugar to Mocha");
        }
    }
}
