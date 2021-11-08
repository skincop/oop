namespace Lab11
{
    class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Data { get; set; }
        public int SheetNumb{ get; set; }
        public int Price { get; set; }

        private Book() { }
        public Book(string bookName,string authorName,int data,int sheetNumb,int price)
        {
            BookName = bookName;
            AuthorName = authorName;
            Data = data;
            SheetNumb = sheetNumb;
            Price = price;
        }

        public override string ToString()
        {
            return $"{BookName} {AuthorName} {Data} г {SheetNumb} стр {Price} руб";
        }

    }
}
