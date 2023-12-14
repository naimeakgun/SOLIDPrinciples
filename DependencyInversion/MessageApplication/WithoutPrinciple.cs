namespace DependencyInversion.MessageApplication
{
    /// <summary>
    /// Bu örnekte Dependency Inversion Prensibi uygulanmadan 1 adet Low Level ve 2 adet High Level olmak üzere 
    ///     class'lar ve çağrılma durumu olacak şekilde 1 adet metot oluşturulmuştur.
    /// Low Level Class: Message
    /// Higs Level Class'lar: EmailService ve SMSService
    /// Low Level class'ı içerisinde FixCharacters metodu oluşturulmuş olup High Level class'lar tarafından
    ///     çağırılıp kullanılması sağlanmıştır.
    ///     Bu da High Level class'larımızın Low Level class'a doğrudan bağımlı olduğunu göstermekte.
    /// Dependency Inversion Prensibi bu bağımlılığı Low Level-High Level ilişkisinden Low Level-Abstraction-High Level
    ///     ilişkisi şeklinde değiştirmemizin daha iyi olabileceğini söylemektedir.
    ///     Yani High Level class'lar Low Level class'lara doğrudan bağımlı olmasın arada interface katmanı olsun istenmektedir.
    /// </summary>

    //Low Level Class
    public class Message
    {
        public string FixCharacters(string message)
        {
            //....fixing characters
            string fixedMessage = message;

            return fixedMessage;
        }
    }


    //High Level Class
    public class EmailService
    {
        private string To;
        private string Cc;
        private string Bcc;
        private string SendingMessage;
        public EmailService(string to, string cc, string bcc, string sendingMessage)
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.SendingMessage = sendingMessage;
        }
        public void SendEmail()
        {
            Message message = new Message();
            var fixedMessage = message.FixCharacters(this.SendingMessage);

            //...sending email
        }
    }
    public class SMSService
    {
        private string PhoneNumber;
        private string SendingMessage;
        public SMSService(string phoneNumber, string sendingMessage)
        {
            this.PhoneNumber = phoneNumber;
            this.SendingMessage = sendingMessage;
        }

        public void SendSMS()
        {
            Message message = new Message();
            var fixedMessage = message.FixCharacters(this.SendingMessage);

            //...sending sms
        }
    }
}
