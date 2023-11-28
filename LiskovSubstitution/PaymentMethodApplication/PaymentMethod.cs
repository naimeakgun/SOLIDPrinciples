namespace LiskovSubstitution
{
    /// <summary>
    /// Burada WithoutPrinciple class dosyası içerisinde yer alan IPayment interface  ve bundan türeyen 
    ///     ödeme class'larının daha doğru sayabileceğimiz haliyle bir örnek yer almaktadır.
    /// Liskov Subtitution Prensibi kullanılarak interface'ten türeyen classlar base olarak 
    ///     nitelendirebiliyor tümüyle artık.
    /// Yani Cash, hem ICashPayment'tan, hem IReceipt'ten  hem de IPay'den türediği 
    ///     ve bütün özelliklerini taşıdığı için aynı anda hem nakit ödeme yapılabilen hem de makbuz alınabilen 
    ///     bir ödeme türüdür diyebiliyoruz.
    /// Aynı şekilde, CreditCard sadece IReceipt ve IPay'den türediği için fiziksel anlamda para işlemi olmadan 
    ///     ödeme yapılıp makbuz alınabilen bir ödeme türüdür diyebiliyoruz.
    /// Liskov sayesinde class'larda NotImplemented durumda bir metot yazma durumu oluşmadı.
    /// </summary>
    public interface ICashPayment
    {
        double GetRemainderOfMoney(double cash, double paymentAmount);
        bool IsPayable(double cash, double paymentAmount);
    }

    public interface IReceipt
    {
        void PrintReceipt(double paymentAmount, string customer);
    }
    public interface IPay
    {
        void Pay();
    }

    public class CashPayment : ICashPayment, IReceipt, IPay
    {
        private double cash;
        private double paymentAmount;
        private string customer;

        public CashPayment(double cash, double paymentAmount, string customer)
        {
            this.cash = cash;
            this.paymentAmount = paymentAmount;
            this.customer = customer;
            Console.WriteLine("Cash Payment method is ready to pay................");
            Console.WriteLine("***************************************************");
        }

        public double GetRemainderOfMoney(double cash, double paymentAmount)
        {
            return cash - paymentAmount;
        }

        public bool IsPayable(double cash, double paymentAmount)
        {
            if (cash >= paymentAmount)
            {
                Console.WriteLine("The cash is enough to pay.");
                return true;
            }
            else
            {
                throw new Exception("The cash is not enough to pay. Please give more money.");
            }
        }

        public void Pay()
        {
            if(IsPayable(cash, paymentAmount))
            {
                var remainder = GetRemainderOfMoney(cash, paymentAmount);
                if (remainder > 0)
                {
                    Console.Write($"Please take back remainder of money {remainder} TL.\n");
                }

                Console.WriteLine("The payment amount is received with cash.\n");
                PrintReceipt(paymentAmount, customer);
            }
        }

        public void PrintReceipt(double paymentAmount, string customer)
        {
            Console.WriteLine("The receipt is preparing......\n");
            Console.WriteLine("THE RECEIPT__________________________________\n" +
                $"{customer} paid {paymentAmount} TL with cash.\n" +
                $"Payment Amount is {paymentAmount} TL.\n" +
                $"And there is no commission.\n");
        }
    }

    public class CreditCardPayment : IReceipt, IPay
    {
        private double paymentAmount;
        private string customer;

        public CreditCardPayment(double paymentAmount, string customer)
        {
            this.paymentAmount = paymentAmount;
            this.customer = customer; 
            Console.WriteLine("CreditCard Payment method is ready to pay..........");
            Console.WriteLine("***************************************************");
        }

        public void Pay()
        {
            Console.WriteLine("The payment amount is received with credit card.");
            PrintReceipt(paymentAmount, customer);
        }

        public void PrintReceipt(double paymentAmount, string customer)
        {
            var commissionAmount = paymentAmount*5/100;
            Console.WriteLine("The receipt is preparing......\n");
            Console.WriteLine("THE RECEIPT__________________________________\n" +
                $"{customer} paid {paymentAmount + commissionAmount} TL with credit card.\n" +
                $"Payment Amount is {paymentAmount} TL.\n" +
                $"Commission Amount is : {commissionAmount} TL.\n");
        }
    }
}
