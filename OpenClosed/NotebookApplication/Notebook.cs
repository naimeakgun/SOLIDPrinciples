using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    /// <summary>
    /// Open-Closed prensibine uygun olarak yazılmış bir Notebook Uygulamasıdır.
    /// HP, ASUS ve MAC olmak üzere üç tip notebook bulunmakta ve bu notebook tipleri Notebook class'ından türetilmiştir.
    /// Prensibe uygun olarak her notebook için özel bilgiler dönülmesi amacıyla GetNotebookPrice ve GetColorsOfNotebook metotları override edilmiştir.
    /// </summary>
    public abstract class Notebook
    {
        protected double standartPrice = 10000;
        protected List<string> baseColors = new List<string>
        {
            "Gray",
            "White",
            "Black"
        };
        public abstract double GetNotebookPrice();
        public abstract List<string> GetColorsOfNotebook();
    }

    public class HP : Notebook
    {
        public override List<string> GetColorsOfNotebook()
        {
            return baseColors;
        }

        public override double GetNotebookPrice()
        {
            return (standartPrice*170)/100 + 350;
        }
    }

    public class ASUS : Notebook
    {
        public override List<string> GetColorsOfNotebook()
        {
            return baseColors;
        }

        public override double GetNotebookPrice()
        {
            return (standartPrice*180)/100 + 570;
        }
    }

    public class MAC : Notebook
    {
        public override List<string> GetColorsOfNotebook()
        {
            var addColorsList = new List<string>
            {
                "Red",
                "Yellow",
                "Pink",
                "Purple"
            };
            var newColorList = baseColors.Union(addColorsList);

            return newColorList.ToList();
        }
        public override double GetNotebookPrice()
        {
            return (standartPrice*210)/100 + 800;
        }
   }
}
