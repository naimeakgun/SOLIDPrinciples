namespace InterfaceSegregation.WorkerApplication
{
    /// <summary>
    /// Bu örnekte Interface Segregation prensibini uygulamadan worker interface'inden türeyen 
    ///     çalışan tanımları oluşturulmaya çalışılmıştır.
    /// Görüldüğü üzere worker interface içerisinde 3 adet metot imzası yer almakta. 
    /// Bu metotlar worker interface'ten türeyen her yeni çalışanın
    ///     hem çalışabildiğini, hem yemek yiyebildiğini, hem de yönetebildiğini göstermektedir. 
    /// Ancak bütün çalışanlar interface içerisinde yer alan zorunlu metotları
    ///     dolduracak şekilde özelliklere sahip değildir.
    /// Yönetici olmayan çalışanlar yönetme sorumluluğuna sahip değildir ancak çalışabilir ve yemek yiyebilirler.
    ///     Bu durumda Manage() metodu için exception fırlatmak durumunda kalmaktayız.
    /// Bu yüzden Interface Segregation prensibini etkili bir şekilde uygulayabilir ve 
    ///     Not Implemented halde bırakmayacağımız şekilde metotlar yazabiliriz.
    /// </summary>
    public interface IWorker
    {
        void Eat();
        void Work();
        void Manage();
    }

    public class Manager : IWorker
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

    public class Worker : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Worker is eating..");
        }

        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Worker is working..");
        }
    }
}
