namespace DependencyInversion
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan Mesage class ve içerisinde yer alan 
    ///     metodu kullandığı için bu class'a bağımlı olan EmailService ve SMSService class'larla arasındaki ilişkiyi kurarken
    ///     bağımlılığı Dependency Inversion Prensibi'ne göre daha doğru sağlayabileceğimiz haliyle
    ///     bir örnek yer almaktadır.
    /// Dependency Inversion prensibi kullanılarak High Level class'ın Low Level class'a bağımlılığı
    ///     interface kullanılarak soyutlaştırılmış olup, bu iki class arasındaki doğrudan bağlantı ortadan 
    ///     kaldırılmıştır.
    /// </summary>
    ///
    public interface IMessage
    {
        public string FixCharacters(string message);
    }

    public class Message : IMessage
    {
        public string FixCharacters(string message)
        {
            Console.WriteLine("fixing characters");

            //....fixing characters
            string fixedMessage = message;

            return fixedMessage;
        }
    }
    public class EmailService
    {
        private string To;
        private string Cc;
        private string Bcc;
        private string SendingMessage;
        private readonly IMessage Message;
        public EmailService(string to, string cc, string bcc, string sendingMessage, IMessage message)
        {
            this.To = to;
            this.Cc = cc;
            this.Bcc = bcc;
            this.SendingMessage = sendingMessage;
            this.Message = message;
        }
        public void SendEmail()
        {

            var fixedMessage = this.Message.FixCharacters(this.SendingMessage);

            Console.WriteLine("Sending Email...");
            //...sending email
        }
    }
    public class SMSService
    {
        private string PhoneNumber;
        private string SendingMessage;
        private readonly IMessage Message;
        public SMSService(string phoneNumber, string sendingMessage, IMessage message)
        {
            this.PhoneNumber = phoneNumber;
            this.SendingMessage = sendingMessage;
            this.Message = message;
        }

        public void SendSMS()
        {
            var fixedMessage = this.Message.FixCharacters(this.SendingMessage);

            Console.WriteLine("Sending SMS...");
            //...sending sms
        }
    }
}
