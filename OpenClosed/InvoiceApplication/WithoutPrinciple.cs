namespace OpenClosed.InvoiceApplication
{
    /// <summary>
    /// Bu örnekte Open-Closed prensibini uygulamadan fatura tiplerine göre indirim miktarlarını döndüren bir metot yazılması amaçlanmıştır.
    /// Görüldüğü üzere yeni bir fatura tipi ekleneceği zaman öncelikle InvoiceTypes enum'ının değiştirilmesi, 
    ///     ardından GetInvoiceDiscount metoduna yeni bir if kontrolü eklenmesi gerekmektedir. 
    ///     Bu da bizden sonra değişiklik yapılması gerekeceği durumlarda izlenmesi gereken etkili bir yol değildir.
    /// </summary>
    public class WithoutPrinciple
    {
        public double GetInvoiceDiscount(double amount, InvoiceTypes invoiceType)
        {
            if (invoiceType == InvoiceTypes.FinalInvoice)
            {
                return amount - 100;
            }
            else if (invoiceType == InvoiceTypes.ProposedInvoice)
            {
                return amount - 50;
            }

            return amount - 10;
        }
    }

    public enum InvoiceTypes
    {
        FinalInvoice,
        ProposedInvoice
    }
}
