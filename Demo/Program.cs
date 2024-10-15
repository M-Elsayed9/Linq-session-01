namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ًWhat is LINQ
            // Language Integrated Query
            // LINQ +40 extension methods
            // LINQ is a set of methods to query data from different data sources
            // LINQ is used to query collections, databases, XML, ADO.NET DataSet, Web Services
            // LINQ has extension methods forall collections that implement IEnumerable<T> interface
            // Named as LINQ operators
            // Categorized into 13 Category


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers.Where(num => num % 2 != 0).ToList().ForEach(Console.WriteLine);

            // you can use linq operator" Against the data stored in sequence 
            // regardless of the data store [SQL server, MySQL, etc..]

            // Sequence => An object from a class that implments the built in interface IEnumerable
            // 1. Local -> Static [LINQ2Object, XML File L2XMl 
            // 2. Remote -> LINQ2EF
            #endregion

        }
    }
}
