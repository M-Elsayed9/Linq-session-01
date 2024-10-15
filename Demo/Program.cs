using System.Net.Http.Headers;

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


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //numbers.Where(num => num % 2 != 0).ToList().ForEach(Console.WriteLine);

            // you can use linq operator" Against the data stored in sequence 
            // regardless of the data store [SQL server, MySQL, etc..]

            // Sequence => An object from a class that implments the built in interface IEnumerable
            // 1. Local -> Static [LINQ2Object, XML File L2XMl 
            // 2. Remote -> LINQ2EF


            #endregion

            #region LINQ Syntax [Fluent - Query]

            #region Fluent Syntax
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// 1. Fluent Syntax

            ////  1.1 Call "LINQ Operators" As a static method

            //List<int> oddNumbers = Enumerable.Where(numbers, num => num % 2 != 0).ToList();

            ////  1.2 Call "LINQ Operators" As an Extension method [Recommended]
            //oddNumbers = numbers.Where(num => num % 2 != 0).ToList(); 
            #endregion

            #region Query Syntax

            // 2. Query Syntax 

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // 3. select *
            // 1. from Numbers N
            // 2. Where N % 2 == 1

            // must begin with FROM Keyword
            // Must end with SELECT or GROUPBY

            var OddNumbers = from N in Numbers
                             where N % 2 == 1
                             select N;

            foreach (int item in OddNumbers)
            {
                Console.WriteLine(item);
            }
            //  2.1 Query Syntax is a set of keywords that are used to write queries
            //  2.2 Query Syntax is converted to Fluent Syntax by the compiler
            //  2.3 Query Syntax is more readable than Fluent Syntax  
            // 2.4 Query Syntax is not used in all LINQ operators



            #endregion

            #endregion

        }
    }
}
