using Demo.Data;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using static Demo.ListGenerator;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 01
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
            //var Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            // query syntax
            //Result = from p in ListGenerator.ProductsList
            //         where p.UnitsInStock == 0
            //         select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            // get products that are in stock
            // Fluent Syntax
            //Result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Polutry");

            // Query Syntax
            //Result = from p in ListGenerator.ProductsList
            //         where p.UnitsInStock > 0 && p.Category == "Meat/Polutry"
            //         select p;


            // Indexed where
            // get products that are out of stock in the first 10 products

            //Result = ListGenerator.ProductsList.Where((p, index) => p.UnitsInStock == 0 && index < 10);
            // indexed qhere valid only with fluent syntax and not query syntax
            #endregion

            #region Transformation [Projection] Operator [Select, SelectMany]

            // FLuent Syntax
            //select product name 

            //var Result = ListGenerator.ProductsList.Select(p => p.ProductName);

            // foreach(var item in Result)
            // {
            //    Console.WriteLine(item);
            // }

            // Query Syntax
            //Result = from p in ListGenerator.ProductsList
            //select p.ProductName;

            // select customer name 
            // Fluent Syntax
            //Result = ListGenerator.CustomersList.Select(c => c.ContactName);

            // Query Syntax
            //Result = from c in ListGenerator.CustomersList
            //select c.CustomerName;

            // select custoemr orders 
            // Fluent Syntax
            //var Result = ListGenerator.CustomersList.SelectMany(c => c.Orders);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //// Query Syntax
            //Result = from c in ListGenerator.CustomersList
            //         from o in c.Orders
            //         select o;


            //select product id and product name
            // Fluent Syntax with annonymous type

            //var result = ListGenerator.ProductsList.Select(p => new { p.ProductID, p.ProductName });
            //// CLR will create class in runtime and override tostring

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Query Syntax
            //result = from p in ListGenerator.ProductsList
            //         select new { p.ProductID, p.ProductName };

            // select product in stock and apply 10% discount on its price
            // Fluent Syntax

            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0)
            //.Select(p => new { ID = p.ProductID, Name = p.ProductName, OldPrice = p.UnitPrice, DiscountedPrice = p.UnitPrice * 0.9m });

            // query syntax
            //result = from p in ListGenerator.ProductsList
            //where p.UnitsInStock > 0
            //select new { ID = p.ProductID, Name = p.ProductName, OldPrice = p.UnitPrice, DiscountedPrice = p.UnitPrice * 0.9m };

            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0).Select((P, I) => new {Index = I, Name = P.ProductName});
            // indexed select valid only with fluent syntax and not query syntax
            #endregion

            #region Ordering Operators [Ascending, Descending, reverse, ThenBy, ThenByDescending

            // Order products by price asc

            // Fluent Syntax
            //var result = ListGenerator.ProductsList.OrderBy(p => p.UnitPrice);

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}

            //// Query Syntax
            //result = from p in ListGenerator.ProductsList
            //         orderby p.UnitPrice
            //         select p;



            // Order products by price desc
            // Fluent Syntax

            //result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Query Syntax
            //result = from p in ListGenerator.ProductsList
            //         orderby p.UnitPrice descending
            //         select p;

            // Order by price asc and number of items in stocl

            // Fluent Syntax
            //result = ListGenerator.ProductsList.OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock);
            // result = ListGenerator.ProductsList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Query Syntax

            //result = from p in ListGenerator.ProductsList
            //         orderby p.UnitPrice, p.UnitsInStock
            //         select p;

            // reverse the order of products
            // Fluent Syntax
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0).Reverse();

            #endregion

            #region ELements Operator - Immediate Execution [valid only with Fluent Syntax]

            //var result = ListGenerator.ProductsList.First(p => p.Category == "Meat/Polutry"); // get the first element from the sequence

            //result = ListGenerator.ProductsList.Last(p => p.Category == "Meat/Polutry"); // get the last element from the sequence

            //Console.WriteLine(result?.ProductName ?? "Not Found");

            //List<Product> products = new List<Product>();

            //var result = products.First(); // throw exception if the sequence is empty

            //result = products.Last(); // throw exception if the sequence is empty

            //result = products.FirstOrDefault(); // return null if the sequence is empty

            //result = products.LastOrDefault(); // return null if the sequence is empty

            //var result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0); // get the first element from the sequence

            //result = ListGenerator.ProductsList.Last(p => p.UnitsInStock == 0); // get the last element from the sequence

            //result = products.FirstOrDefault(p => p.UnitsInStock == 0); // return null if the sequence is empty

            //result = products.LastOrDefault(p => p.UnitsInStock == 0); // return null if the sequence is empty

            //Console.WriteLine(result?.ProductName ?? "Not Found");


            //var result = ListGenerator.ProductsList.ElementAt(77); // get the element at the specified index
            // throws exception if the index is out of range

            //var result = ListGenerator.ProductsList.ElementAtOrDefault(77); // return null if the index is out of range

            //Console.WriteLine(result?.ProductName ?? "Not Found");

            //result = ListGenerator.ProductsList.Single(p => p.ProductID == 1); // get the element that satisfies the condition
            // throws exception if the sequence contains more than one element that satisfies the condition


            #endregion

            #region Aggregation Operators [Count, Sum, Average, Min, Max] // immediate execution
            //var result = ListGenerator.ProductsList.Count(); // get the number of elements in the sequence
            // LINQ operator
            //result = ListGenerator.ProductsList.Count; // List property

            //var result = ListGenerator.ProductsList.Max(); // Product must implment Icomparable  
            //result = ListGenerator.ProductsList.Min(); // Product must implment Icomparable

            //var result = ListGenerator.ProductsList.Max(P => P.UnitPrice); // get the maximum value of the specified property

            //var MinLength = ListGenerator.ProductsList.Min(P => P.ProductName.Length);
            //Console.WriteLine(MinLength);
            //var result = (from p in ListGenerator.ProductsList
            //              where p.ProductName.Length == MinLength
            //              select p).FirstOrDefault();

            //var result = ListGenerator.ProductsList.Sum(P => P.UnitPrice); // get the sum of the specified property

            //var result = ListGenerator.ProductsList.Average(P => P.UnitPrice); // get the average of the specified property

            //Console.WriteLine(result);

            //string[] Names = { "Aya", "Omar", "Amr", "Mohamed" };

            //var result = Names.Aggregate((a, b) => $"{a}, {b}"); // get the aggregate of the sequence


            //Console.WriteLine(result);


            #endregion

            #endregion

            #region Session 02

            #region Casting Operators - Immediate execution
            //List<Product> result = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[] products1 = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> products2 = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);

            //foreach(var item in products2)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //Dictionary<long, string> products3 = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID, p => p.ProductName);


            //HashSet<Product> products4 = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();

            //ArrayList Result = new ArrayList()
            //{
            //    "Omar",
            //    "Ahmed",
            //    "Ali",
            //    "Mohamed",
            //    1,2,3
            //};


            //var result = Result.OfType<string>();

            //foreach (string item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Generation Operators - Deffered Execution 

            // valid only with fluent syntax
            // the only way to call them is as static methods from class enumerable

            //var Result = Enumerable.Range(1, 10);

            //Result = Enumerable.Repeat(2, 100);

            //var Result = Enumerable.Repeat(new Product(), 10);

            //var arrayProducts = Enumerable.Empty<Product>().ToArray(); // empty array

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Set Operators [Union Family] - Deffered Execution

            var Seq01 = Enumerable.Range(0, 100); // from 0 to 99

            var Seq02 = Enumerable.Range(50, 100); // from 50 to 149

            var Result = Seq01.Union(Seq02); // get the union of the two sequences
            // remove the duplicates

            //var Result = Seq01.Concat(Seq02); // get the concatenation of the two sequences
            foreach (var item in Seq01) {
                Console.WriteLine(item);
            }

            foreach (var item in Seq02)
            {
                Console.WriteLine(item);
            }

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Result = Result.Distinct(); // get the distinct elements from the sequence

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Result = Seq01.Intersect(Seq02); // get the intersection of the two sequences

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            Result = Seq01.Except(Seq02); // get the difference between the two sequences
            
            
            
            #endregion

            #endregion
        }
    }
}
