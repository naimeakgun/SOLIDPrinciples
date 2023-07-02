namespace DependencyInversion.DatabaseApplication
{
    /// <summary>
    /// Bu örnekte Dependency Inversion prensibini uygulamadan 1 adet Low Level ve 1 adet High Level olmak üzere 
    ///     class'lar ve çağrılma durumu olacak şekilde 1 metot oluşturulmuştur.
    /// Low Level Class: Database
    /// Higs Level Class: MongoDbService
    /// Low Level class'ı içerisinde Connect metodu oluşturulmuş olup High Level class tarafından
    ///     çağırılıp kullanılması sağlanmıştır.
    ///     Bu da High Level class'ımızın Low Level class'a bağımlı olduğunu göstermekte.
    ///     Bu metotta bir değişiklik olması durumunda doğrudan High Level class da etkilenecektir.
    /// Dependency Inversion prensibi bu bağımlılığı Low Level - High Level ilişkisinden Low Level - Abstraction - High Level
    ///     ilişkisi şeklinde değiştirmemizin daha iyi olabileceğini söylemektedir.
    ///     Yani High Level class'lar Low Level class'lara doğrudan bağımlı olmasın arada interface katmanı olsun istenmektedir.
    /// </summary>
    public class Database
    {
        public void Connect(string connectionString)
        {
            //....
        }
    }

    public class MongoDbService
    {
        public string ConnectionString { get; set; } = "";
        public void Connect()
        {
            Database db = new Database();
            db.Connect(ConnectionString);
        }
    }
}
