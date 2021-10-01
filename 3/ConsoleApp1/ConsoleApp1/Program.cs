using System;

namespace ConsoleApp1
{
    partial class Product
    {
        private readonly int id;
        private static int sum;
        public static int _id = 1;
        private string name = "";
        private int upc;
        private string manuf = "";
        private int price;
        private string data = "";
        private int quanity;
        const string city = "Minsk";
        public int Upc
        {
            set
            {
                upc = value;
            }
            get
            {
                return upc;
            }
        }
        public int Price
        {
            set
            {
                if (value > 0 && value < 1000)
                    price = value;
            }
            get
            {
                return price;
            }
        }
        public string Name
        {
            set
            {
                if (value != null && value != "")
                    name = value;
            }
            get
            {
                return name;
            }
        }
        public string Manuf
        {
            set
            {
                if (value != null && value != "")
                    manuf = value;
            }
            get
            {
                return manuf;
            }
        }
        public string Data
        {
            set
            {
                if (value != null && value != "")
                    data = value;
            }
            get
            {
                return data;
            }
        }
        public int Quanity
        {
            set
            {
                if (value != 0 && value < 1000)
                    quanity = value;
            }
            get
            {
                return quanity;
            }
        }
        public Product(string _name = "unknown", int _upc = -1, string _manuf = "noname", int _price = 999999, string _data = "00.00.0000", int _quanity = -1)
        {
            id++;
            this.id = _id;
            if (_name != "" && _name != null)
                this.name = _name;
            else this.name = "unknown";
            if (_upc != 0)
                this.upc = _upc;
            else this.upc = -1;
            if (_manuf != "" && _manuf != null)
                this.manuf = _manuf;
            else this.manuf = "noname";
            if (_price != 0)
                this.price = _price;
            else this.price = 999999;
            if (_data != "" && _data != null)
                this.data = _data;
            else this.data = "00.00.0000";
            if (_quanity > 0)
                this.quanity = _quanity;
            else this.quanity = 0;



        }
        public Product(string _name)
        {

        }
        //public Product()
        //{

        //}
        static Product()
        {

        }
        private Product()
        {
            Console.WriteLine(new string('!', 20));
        }


        public void Getinfo()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(this.id + "\n" + this.name + "\n" + this.upc + "\n" + this.manuf + "\n" + this.price + "\n" + this.data + "\n" + this.quanity);
            Console.WriteLine(new string('-', 50));

        }
        public void Usless()
        {
        }
        public static int Yan= 10000234;
        static void InfoClass()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(Yan);
            Console.WriteLine(_id);
            Console.WriteLine("-------------------------");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Product m = obj as Product;
            if (m as Product == null)
                return false;

            return m.id == this.id && m.name == this.name && m.upc == this.upc && m.quanity == this.quanity;
        }
        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return "Id: " + this.id + "name: " + this.name;
        }




    }


    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[6];
            products[0] = new Product("pen",1111,"maped",10,"26.06.2013",25);
            products[1] = new Product("pencil",2222,"erich",15,"01.11.2013",25);
            products[2] = new Product("rubber",3333,"maped",30,"26.09.2015",10);
            products[3] = new Product("pen",4444,"erich",30,"16.10.2019",10);
            products[4] = new Product("rubber",5555,"maped",100,"16.10.2019",3);
            products[5] = new Product("book",6666,"ozzz",200,"10.16.2021",100);
            products[0].Getinfo();
            products[0].Usless();
            void Findname ()
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Type a name of product");
                string find = Console.ReadLine();
                for (int i = 0; i < products.Length; i++)
                {
                    string name = products[i].Name;
                    if (find == name)
                        products[i].Getinfo();
                }
            }
            void Findprice()
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Type a name of product");
                string find = Console.ReadLine();
                Console.WriteLine("Type price of product");
                int price = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < products.Length; i++)
                {
                    if (find == products[i].Name && price >= products[i].Price)
                        products[i].Getinfo();
                }
            }
            Findname();
            Findprice();
            var ruler = new { name="ruler",price=10,manuf="ozzz", quanity=5 };
            Console.WriteLine(ruler.manuf);






        }
    }
}
