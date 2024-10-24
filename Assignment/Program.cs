


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



namespace Assignment
    
{
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

            #region Set Operators
            //1.Find the unique Category names from Product List
            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            //3.Create one sequence that contains the common first letter from both product and customer names.
            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            #endregion

            #region Partitioning Operators

            //1.Get the first 3 orders from customers in Washington
            //2.Get all but the first 2 orders from customers in Washington.
            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //5.Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            #endregion

            #region LINQ Quanitifiers
            //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //3.Return a grouped a list of products only for categories that have all of their products in stock.

            #endregion

            #region LINQ Grouping Operators



            #endregion
        }
        }
}
