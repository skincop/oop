using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Magazin
    {
        public string AuthorName { get; set; }
        public string MagazinName { get; set; }
        public int Data { get; set; }
        public int SheetNumb { get; set; }
        public int Price { get; set; }
        private Magazin() { }
        public Magazin (string magazinName,string authorName, int data, int sheetNumb, int price)
        {
            AuthorName = authorName;
            MagazinName = magazinName;
            Data = data;
            SheetNumb = sheetNumb;
            Price = price;
        }

        public override string ToString()
        {
            return $"{AuthorName} {Data} г {SheetNumb} стр {Price} руб";
        }
    }
}
