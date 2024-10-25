


using Demo.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using static Assignment.ListGenerator;
using System.Collections;
using System.Security.Cryptography;



namespace Assignment
    
{
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, true);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // 1.Find all products that are out of stock.
            //var result = ProductsList.Where(p => p.UnitsInStock == 0).ToList();

            // 2. Find all products that are in stock and cost more than 3.00 per unit.
            //result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();

            // 3. Returns digits whose name is shorter than their value.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr.Where((n, i) => n.Length < i).ToList();

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #region LINQ - Element Operators

            //1.Get first Product out of Stock
            //var Result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductsList.FirstOrDefault(p => p.UnitsInStock > 1000);

            //3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(X => X > 5).ElementAt(1);

            #endregion

            #region LINQ - Aggregate Operators

            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(N => N % 2 == 1);

            //2.Return a list of customers and how many orders each has.

            //var Result = CustomersList.Select(C => new { CustomerName = C.CustomerName, OrderCount = C.Orders.Count() });

            //3.Return a list of categories and how many products each has

            //var result = ProductsList.GroupBy(P => P.Category)
            //    .Select(P => new { CategoryName = P.Key, ProductCount = P.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName} Product Count: {item.ProductCount}");
            //}


            //4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int result = Arr.Sum();

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(w => w.Length);

            //Console.WriteLine(result);

            //6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var result = words.Min(w => w.Length);

            //7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var result = words.Max(w => w.Length);

            //8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var result = words.Average(w => w.Length);

            //9.Get the total units in stock for each product category.

            //var result = ProductsList.GroupBy(P => P.Category)
            //    .Select(P => new { CategoryName = P.Key, TotalUnitsInStock = P.Sum(P => P.UnitsInStock) }).ToList();

            //10.Get the cheapest price among each category's products

            //var result = ProductsList.GroupBy(p => p.Category)
            //    .Select(p => new { CategoryName = p.Key, CheapestPrice = p.Min(p => p.UnitPrice) }).ToList();

            //11.Get the products with the cheapest price in each category(Use Let)

            //var result = from p in ProductsList
            //             group p by p.Category
            //             into pc
            //             let minPrice = pc.Min(p => p.UnitPrice)
            //             select new { CategoryName = pc.Key, CheapestProducts = pc.Where(p => p.UnitPrice == minPrice) };


            //12.Get the most expensive price among each category's products.

            //var result = ProductsList.GroupBy(p => p.Category)
            //    .Select(p => new { Category = p.Key, MaxPrice = p.Max(p => p.UnitPrice) });

            //13.Get the products with the most expensive price in each category.

            //var result = from p in ProductsList
            //             group p by p.Category
            //             into pc
            //             let maxPrice = pc.Max(p => p.UnitPrice)
            //             select new { CategoryName = pc.Key, MostExpensiveProducts = pc.Where(p => p.UnitPrice == maxPrice) };


            //14.Get the average price of each category's products.

            //var result = ProductsList.GroupBy(p => p.Category)
            //    .Select(p => new { Category = p.Key, AveragePrice = p.Average(p => p.UnitPrice) });

            #endregion

            #region LINQ - Ordering Operators

            //1. Sort a list of products by name

            //var result = ProductsList.OrderBy(p => p.ProductName).ToList();

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(a => a, new CustomComparer()).ToList();

            //3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(x => x.Length).ThenBy(x => x).ToList();

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(x => x[1] == 'i').Reverse().ToList();

            #endregion

            #region LINQ – Transformation Operators

            //1.Return a sequence of just the names of a list of products.

            //var result = ProductsList.Select(p => p.ProductName);

            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            // 3. Produce a sequence containing some properties of Products, including
            // UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductsList.Select(p => new { p.ProductName, Price = p.UnitPrice });

            // 4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((n, i) =>  n == i).ToArray();

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine($"{Arr[i]}: {result[i]}");
            //}

            //5.Returns all pairs of numbers from both arrays such that the number from
            //numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(b => numbersB, (a, b) => new { a, b }).Where(p => p.a < p.b).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"A: {item.a} is less than B: {item.b}");
            //}

            //6.Select all orders where the order total is less than 500.00.

            //var result = CustomersList.SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.Total }).Where(o => o.Total < 500).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer ID: {item.CustomerID} Order ID: {item.OrderID} Total: {item.Total}");
            //}

            //7. Select all orders where the order was made in 1998 or later.

            //var result = CustomersList.SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.OrderDate }).Where(o => o.OrderDate.Year >= 1998).ToList();

            #endregion

            #region Set Operators
            //1.Find the unique Category names from Product List

            //var result = ProductsList.Select(p => p.Category).Distinct().ToList();

            //2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Distinct().Union(CustomersList.Select(c => c.CustomerName[0])).Distinct().ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0])).ToList();

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0])).ToList();

            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Union(CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3))).ToList();
            #endregion

            #region Partitioning Operators

            //1.Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

            //2.Get all but the first 2 orders from customers in Washington.

            //var Result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, i) => n > i).ToList();

            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0).ToList();

            //5.Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((n, i) => n > i).ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ Quanitifiers
            //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var result = File.ReadAllLines("dictionary_english.txt").Any(w => w.Contains("ei"));

            //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var result = ProductsList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock >= 1)).ToList();

            //3.Return a grouped a list of products only for categories that have all of their products in stock.

            //var result = ProductsList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock >= 1)).ToList();
            #endregion

            #region LINQ Grouping Operators



            #endregion
        }
    }
}
