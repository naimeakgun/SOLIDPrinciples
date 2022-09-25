//InoviceApplication için bazı test çağırımları:
using OpenClosed;

Invoice invoice = new Invoice();
var invoiceDiscount = invoice.GetInvoiceDiscount(100);

Invoice finalInvoice = new FinalInvoice();
var finalInvoinceDiscount = finalInvoice.GetInvoiceDiscount(100);

Invoice proposedInvoice = new ProposedInvoice();
var proposedInvoiceDiscount = proposedInvoice.GetInvoiceDiscount(100);

Console.WriteLine("Invoice Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------");
Console.WriteLine("Invoice Discount \t\t:{0} TL", invoiceDiscount);
Console.WriteLine("Final Invoice Discount \t\t:{0} TL", finalInvoinceDiscount);
Console.WriteLine("Proposed Invoice Discount \t:{0} TL", proposedInvoiceDiscount);
Console.WriteLine("\n\n\n");






//NotebookApplication için bazı test çağırımları:
var hpNotebook  = new HP();
var asusNotebook = new ASUS();
var macNotebook = new MAC();

Console.WriteLine("Notebook Application Informations");
Console.WriteLine("--------------------------------------------------------------------------------------");

Console.WriteLine("HP Notebook Price: {0} TL ", hpNotebook.GetNotebookPrice());
Console.WriteLine("HP Notebook Colors: {0}", String.Join(", ", hpNotebook.GetColorsOfNotebook().ToArray()));
Console.WriteLine("\n");
Console.WriteLine("ASUS Notebook Price: {0} TL", asusNotebook.GetNotebookPrice());
Console.WriteLine("HP Notebook Colors: {0}", String.Join(", ", asusNotebook.GetColorsOfNotebook().ToArray()));
Console.WriteLine("\n");
Console.WriteLine("MAC Notebook Price: {0} TL", macNotebook.GetNotebookPrice());
Console.WriteLine("HP Notebook Colors: {0}", String.Join(", ", macNotebook.GetColorsOfNotebook().ToArray()));
Console.WriteLine("\n");