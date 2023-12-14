namespace SingleResponsibility.ShoppingApplication
{
    // <summary>
    /// Bu örnekte Single Responsibility Prensibi uygulanmadan bir Shopping uygulaması oluşturulmuştur.
    /// Shopping class içerisinde yer alması gereken AddCart ve CreateOrder işlemleri dışında ayrıca loglamalar yapılmış
    ///      ve mail gönderim işlemi de yapılmıştır.
    /// Bu durumda Shopping işlemi olmayan loglama ve mail gönderim işlemleri, Shopping için ekstra bir yükümlülük oluşturmuş
    ///     olup Single Responsibility Prensibi'ne uyum sağlamamaktadır diyebiliriz.
    /// </summary>
    public class Shopping
    {
        public void AddCart()
        {
            try
            {
                //Adding product to cart
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void CreateOrder()
        {
            try
            {
                //Creating order
                //Sending email to customer
                SendOrderSummaryEmail();
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendOrderSummaryEmail()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
