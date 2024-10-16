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

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // 3. select *
            // 1. from Numbers N
            // 2. Where N % 2 == 1

            // must begin with FROM Keyword
            // Must end with SELECT or GROUPBY

            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //foreach (int item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //  2.1 Query Syntax is a set of keywords that are used to write queries
            //  2.2 Query Syntax is converted to Fluent Syntax by the compiler
            //  2.3 Query Syntax is more readable than Fluent Syntax  
            // 2.4 Query Syntax is not used in all LINQ operators



            #endregion

            #endregion

            #region LINQ Execution ways [Elements Operators, Casting Opators, Aggregate Operators]

            #region Deferred Execution latest version of data
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(N => N % 2 == 1);
            ////Where is executed with deferred execution

            //Numbers.AddRange(new List<int> { 11, 12, 13, 14, 15 });

            //foreach (int item in OddNumbers)
            //{
            //    Console.WriteLine(item); // 1, 3, 5, 7, 9, 11, 13, 15
            //} 
            #endregion

            #region Immediate Execution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(N => N % 2 == 1).ToList();
            //// Where is executed with deferred execution
            //// ToList is executed

            //Numbers.AddRange(new List<int> { 11, 12, 13, 14, 15 });

            //foreach (int item in OddNumbers)
            //{
            //    Console.WriteLine(item); // 1, 3, 5, 7, 9, 11, 13, 15
            //}

            #endregion

            #endregion

            #region Data SetUp

            //Console.WriteLine(ListGenerator.ProductsList[0]);

            //Console.WriteLine(ListGenerator.CustomersList[0]);


            #endregion

            #region Filteration Operator

            // get products that are out of stock
            //Fluent Syntax
            var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            // query syntax
            Result = from p in ListGenerator.ProductsList
                     where p.UnitsInStock == 0
                     select p;

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }


            // get products that are in stock
            // Fluent Syntax
            Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Polutry");

            // Query Syntax
            Result = from p in ListGenerator.ProductsList
                     where p.UnitsInStock > 0 && p.Category == "Meat/Polutry"
                     select p;


            // Indexed where
            // get products that are out of stock in the first 10 products

            Result = ListGenerator.ProductsList.Where((p, index) => p.UnitsInStock == 0 && index < 10);
            // indexed qhere valid only with fluent syntax and not query syntax
            #endregion
        }
    }
}
