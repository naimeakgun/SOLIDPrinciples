namespace LiskovSubstitution.PaymentMethodApplication
{
    /// <summary>
    /// Bu örnekte Liskov Substitution prensibini uygulamadan IPayment interface'ten türeyen 
    ///     ödeme çeşitleri oluşturulmaya çalışılmıştır.
    /// Görüldüğü üzere IPayment base class içerisinde 2 metot imzası yer almakta. 
    /// Bu metotlar IPayment interface'ten türeyen her yeni ödeme türünün para üstü ve makbuz verdiğini göstermektedir.
    /// Ancak Cash ve CreditCard aynı anda bu iki özelliği gerçekleştiremez. 
    /// CreditCard pos üzerindne ödeme aldığı için para üstü gibi bir durum söz konusu değildir.
    ///     Bu durumda GetRemainderOfMoney() metodu için exception fırlatmak durumunda kalmaktayız.
    /// Bu yüzden Liskov'u burada etkili bir şekilde uygulayabilir ve 
    ///     Not Implemented halde bırakmayacağımız şekilde metotlar yazabiliriz.
    /// </summary>
    public interface IPayment
    {
        double GetRemainderOfMoney(double cash, double paymentAmount);
        void PrintReceipt(double paymentAmount, double paidAmount, string customer);
    }

    public class CreditCardPayment : IPayment
    {
        public double GetRemainderOfMoney(double cash, double paymentAmount)
        {
            //there is no money back because the credit card payment amount can received completely
            throw new NotImplementedException();
        }

        public void PrintReceipt(double paymentAmount, double paidAmount, string customer)
        {
            Console.WriteLine($"{customer} paid {paidAmount} TL with credit card\n" +
                $"Payment Amount is {paymentAmount}" +
                $"Commission Amount is : {paidAmount - paymentAmount} TL");
        }
    }


    public class CashPayment : IPayment
    {
        public double GetRemainderOfMoney(double cash, double paymentAmount)
        {
            if(cash > paymentAmount)
            {
                return cash - paymentAmount;
            }
            else
            {
                throw new Exception("The cash is not enought to pay.");
            }
        }

        public void PrintReceipt(double paymentAmount, double paidAmount, string customer)
        {
            Console.WriteLine($"{customer} paid {paidAmount} TL with cash." +
                $"Payment Amount is {paymentAmount}" +
                $"And there is no commission.");
        }
    }
}
