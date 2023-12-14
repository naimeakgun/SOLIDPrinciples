namespace SingleResponsibility
{
    /// <summary>
    /// Single Responsibility Prensibi'ne uygun olarak yazılmış bir Shopping uygulamasıdır.
    /// Toplamda 3 farklı class oluşturuldu:
    ///     Shopping, EmailSender ve Logger.
    /// Bu sayede her class ve metot kendi sorumluluğunu üstlendi.
    /// Shopping işlemleri için gerekli loglama işlemi aslında Logger class'ı içerisinde yazıldı, Shopping tarafında çağırıldı.
    /// Aynı şekilde Shopping işlemleri için gerekli email gönderim işlemi aslında EmailSender class'ı içerisinde yazıldı.
    /// </summary>
    public class Shopping
    {
        private Logger logger;
        private EmailSender emailSender;
        public Shopping()
        {
            logger = new Logger();
            emailSender = new EmailSender();
        }
        public void AddCart(string product)
        {
            try
            {
                //Adding product to cart
                Console.WriteLine($"{product} is added to cart");

                //logging information
                logger.Info("Adding Cart");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        public void CreateOrder()
        {
            try
            {
                //Creating order

                //Sending email to customer
                emailSender.SendEmail();

                //logging information
                logger.Info("Creating Order");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }

    public class EmailSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void SendEmail()
        {
            //Sending Email
            Console.WriteLine("Email sending");
        }
    }

    public class Logger
    {
        public void Info(string message)
        {
            //Logging
            Console.WriteLine($"Logging info: {message}");
        }
        public void Error(Exception ex)
        {
            //Logging
            Console.WriteLine("Logging");
        }
    }
}
