namespace LiskovSubstitution.CoffeeApplication
{
    /// <summary>
    /// Bu örnekte Liskov Substitution prensibini uygulamadan coffee base class'ından türeyen 
    ///     kahve çeşitleri oluşturulmaya çalışılmıştır.
    /// Görüldüğü üzere coffee base class içerisinde 3 abstract metot yer almakta. 
    /// Bu metotlar coffee base class'tan türeyen her yeni kahve türünün 
    ///     espresso, süt ve şeker ile hazırlanması gerektiğini göstermektedir.
    /// Ancak aralarında FilterCoffee de yer almaktadır. 
    /// Filtre kahve espresso bazlı bir kahve değildir.
    ///     Bu durumda AddEspresso() metodu için exception fırlatmak durumunda kalmaktayız.
    /// Bu yüzden Liskov'u burada etkili bir şekilde uygulayabilir ve 
    ///     Not Implemented halde bırakmayacağımız şekilde metotlar yazabiliriz.
    /// </summary>
    public abstract class Coffee
    {
        public abstract void AddEspresso();
        public abstract void AddSugar();
        public abstract void AddMilk();
    }

    public class Latte : Coffee
    {
        public override void AddEspresso()
        {
            Console.WriteLine("Added one shot espresso to Latte");
        }

        public override void AddMilk()
        {
            Console.WriteLine("Added 200ml milk to Latte");
        }

        public override void AddSugar()
        {
            Console.WriteLine("Added one tea spoon sugar to Latte");
        }
    }

    public class FilterCoffee : Coffee
    {
        public override void AddEspresso()
        {
            throw new NotImplementedException();
        }

        public override void AddMilk()
        {
            Console.WriteLine("Added 200ml milk to Filter Coffee");
        }

        public override void AddSugar()
        {
            Console.WriteLine("Added one tea spoon sugar to Filter Coffee");
        }
    }

    public class Mocha : Coffee
    {
        public override void AddEspresso()
        {
            Console.WriteLine("Added one shot espresso to Mocha");
        }

        public override void AddMilk()
        {
            Console.WriteLine("Added 200ml milk to Mocha");
        }

        public override void AddSugar()
        {
            Console.WriteLine("Added one tea spoon sugar to Mocha");
        }
    }
}
