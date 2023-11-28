namespace OpenClosed.NotebookApplication
{
    /// <summary>
    /// Bu örnekte Open-Closed prensibini uygulamadan notebook tiplerine göre fiyat ve renk bilgilerini döndüren iki adet metot yazılması amaçlanmıştır.
    /// Görüldüğü üzere yeni bir notebook tipi ekleneceği zaman öncelikle iki metodun da içerisinde yer alan if-else bloklarının düzenlenmesi gerekmektedir.
    ///     Bu da bizden sonra değişiklik yapılması gerekeceği durumlarda izlenmesi gereken etkili bir yol değildir.
    /// </summary>
    public class WithoutPrinciple
    {
        private double standartPrice = 10000;
        public double GetNotebookPrice(string notebookBrand)
        {
            if(notebookBrand == "HP")
            {
                return (standartPrice*170)/100 + 350;
            }
            else if(notebookBrand == "ASUS")
            {
                return (standartPrice*180)/100 + 570;
            }
            else if(notebookBrand == "MAC")
            {
                return (standartPrice*210)/100 + 800;
            }
            else
            {
                throw new Exception($"There is no available price for notebookBrand: {notebookBrand}");
            }
        }

        public List<string> GetColorOfNotebooks(string notebookBrand)
        {
            if (notebookBrand == "HP" || notebookBrand == "ASUS")
            {
                return new List<string>
                {
                    "gray",
                    "white",
                    "black"
                };
            }
            else if (notebookBrand == "MAC")
            {
                return new List<string>
                {
                    "gray",
                    "white",
                    "black",
                    "red",
                    "yellow",
                    "pink",
                    "purple"
                };
            }
            else
            {
                throw new Exception($"There is no available colors for notebookBrand: {notebookBrand}");
            }
        }
    }
}
