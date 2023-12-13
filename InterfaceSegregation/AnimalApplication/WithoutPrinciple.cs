namespace InterfaceSegregation.AnimalApplication
{
    /// <summary>
    /// Bu örnekte Interface Segregation Prensibi uygulanmadan Animal Interface'inden türeyen 
    ///     hayvan tanımları oluşturulmaya çalışılmıştır.
    /// Görüldüğü üzere Animal Interface içerisinde 4 adet metot imzası yer almakta. 
    /// Bu metotlar Animal Interface'ten türeyen her yeni hayvan türünün 
    ///     hem uçabildiğini, hem havlayabilidiğini, hem yüzebildiğini 
    ///     hem de koşabildiğini göstermektedir.
    /// Ancak bütün hayvanlar interface içerisinde yer alan zorunlu metotları
    ///     dolduracak şekilde özelliklere sahip değildir.
    /// Kediler uçamaz, havlayamaz ama koşabilir.
    ///     Bu durumda Fly() ve Bark() metotları için exception fırlatmak durumunda kalmaktayız.
    /// Bu yüzden Interface Segregation prensibini etkili bir şekilde uygulayabilir ve 
    ///     Not Implemented halde bırakmayacağımız şekilde metotlar yazabiliriz.
    /// </summary>
    public interface Animal
    {
       void Fly();
       void Bark();
       void Swim();
       void Run();
    }

    public class Cat : Animal
    {
        public void Bark()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Cat is running..");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking..");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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
}
