using System.Drawing;

namespace SingleResponsibility.EmployeeApplication
{
    // <summary>
    /// Bu örnekte Single Responsibility prensibi uygulanmadan bir Employee uygulaması oluşturulmuştur.
    /// Employee Class içerisinde Register metoduyla Employee kaydı gerçekleştirilmektedir.
    /// Ancak Employee içerisinde Company için gerekli bir işlem metodu da yer almakta ve Register metodu içerisinde 
    ///     id-card oluşturma işlemleri de yapılmaktadır.
    /// Bu durumda Employee işlemi olmayan; company üzerinde kayıt ve id-card oluşturma işlemleri, Employee için
    ///     ekstra bir yükümlülük oluşturmuş olup Single Responsibility prensibine uyum sağlamamaktadır diyebiliriz.
    /// </summary>
    public class Employee
    {
        public void Register()
        {
            //Create employee profile

            //Send employee profile to company
            RegisterToCompany();


            //creating id-card process to create 
            Size keyCardSize = new Size(1004, 638);
            float Dpi = 150f;
            //.................
        }

        public void RegisterToCompany()
        {
            //Send employee information to company
        }
    }
}
