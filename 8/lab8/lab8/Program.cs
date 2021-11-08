using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var collectionString = new CollectionType<string> { };

                collectionString.Add("Яп");
                collectionString.Add("ООП");
                collectionString.Add("Матем");
                collectionString.Show();

                collectionString.RemoveAt(2);

                Console.WriteLine(new string('-',50));
                collectionString.Show();
                Console.WriteLine();

                var collectionAuthor = new CollectionType<Author> { };

                collectionAuthor.Add(new Author("Stephen", "King", 6));
                collectionAuthor.Add(new Author("Vasiliy", "Bik", 4));

                collectionAuthor.Print();

                var collectionObj = new CollectionType<object> { };

                collectionObj.Add(12);
                collectionObj.Add(16);
                collectionObj.Add(18);

                collectionObj.Show();

                Console.WriteLine(new string('-',50));

                collectionObj.Insert(2, 20);
                collectionObj.Show();

                collectionAuthor.SerializeAndSave();

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("\n\nEnd.");
            }
        }
    }
}