using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    /// <summary>
    /// Open-Closed prensibine uygun olarak yazılmış bir Invoice Uygulamasıdır.
    /// Final ve Proposed olmak üzere iki tip fatura bulunmakta ve bu fatura tipleri Invoice class'ından türetilmiştir.
    /// Prensibe uygun olarak her fatura için özel bilgi dönülmesi amacıyla GetInvoiceDiscount metodu override edilmiştir.
    /// </summary>
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 70;
        }
    }

    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
