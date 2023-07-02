namespace DependencyInversion
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan Database class ve içerisinde yer alan 
    ///     metodu kullandığı için bu class'a bağımlı olan MongoDbService class arasındaki ilişkiyi kurarken
    ///     bağımlılığı Dependency Inversion Prensibi'ne göre daha doğru sağlayabileceğimiz haliyle
    ///     bir örnek yer almaktadır.
    /// Dependency Inversion prensibi kullanılarak High Level class'ın Low Level class'a bağımlılığı
    ///     interface kullanılarak soyutlaştırılmış olup, bu iki class arasındaki doğrudan bağlantı ortadan 
    ///     kaldırılmıştır.
    /// </summary>
    ///
    public interface IDatabase
    {
        void Connect(string connectionString);
    }

    public class Database : IDatabase
    {
        public void Connect(string connectionString)
        {
            //....
        }
    }

    public class MongoDbService
    {
        private readonly IDatabase _db;
        public string ConnectionString { get; set; } = "";

        public MongoDbService(IDatabase database)
        {
            _db = database;
        }

        public bool Connect()
        {
            try
            {
                _db.Connect(ConnectionString);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
