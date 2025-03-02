using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Assignment02_LinQ.Data;
using static Assignment02_LinQ.ListGenerator;

namespace Assignment02_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ-Aggregate operators
            #region 1
            //var result = ProductsList.Where(P => P.UnitsInStock > 0).
            //            Select(P => P.UnitsInStock).Count();

            //Console.WriteLine(result); 

            #endregion

            #region 2

            //var result = from P in ProductsList
            //             group P by P.Category
            //             into C
            //             let cheapestPrice = C.Min(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = C.Key,
            //                 CheapestPrice = cheapestPrice
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3

            //var result = from P in ProductsList
            //             group P by P.Category
            //             into category
            //             let cheapestPrice = category.Min(P => P.UnitPrice)
            //             let cheapestProduct = category.First(P => P.UnitPrice == cheapestPrice)
            //             select new
            //             {
            //                 CategoryName = category.Key,
            //                 CheapestProduct = cheapestProduct
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 4
            //var result = from P in ProductsList
            //             group P by P.Category
            //             into category
            //             let expensivePrice = category.Max(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = category.Key,
            //                 ExpensivePice = expensivePrice
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5
            //var result = from P in ProductsList
            //             group P by P.Category
            //             into category
            //             let expensivePrice = category.Max(P => P.UnitPrice)
            //             let expensiveProduct = category.First(P => P.UnitPrice == expensivePrice)
            //             select new
            //             {
            //                 CategoryName = category.Key,
            //                 ExpensiveProduct = expensiveProduct

            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6

            //var result = from P in ProductsList
            //             group P by P.Category
            //             into category
            //             let averagePrice = category.Average(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = category.Key,
            //                 AveragePrice = averagePrice
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Set Operators
            #region 1
            //var result = ProductsList.Select(P => P.Category).Distinct();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2

            //var result = ProductsList.Select(P => P.ProductName[0]).
            //                         Concat(CustomersList.Select(C => C.CustomerName[0])).
            //                         Distinct().
            //                         OrderBy(letter => letter);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3
            //var result = ProductsList.Select(P => P.ProductName[0]).
            //                         Intersect(CustomersList.Select(C => C.CustomerName[0])).

            //                         OrderBy(letter => letter);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4
            //var result = ProductsList.Select(P => P.ProductName[0]).
            //                         Except(CustomersList.Select(C => C.CustomerName[0])).

            //                         OrderBy(letter => letter);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5
            //var lastThreeChars = ProductsList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName).
            //    Concat(CustomersList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName));

            //foreach (var item in lastThreeChars)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #endregion

            #region LINQ - Partitioning operators

            #region 1 


            //var result = CustomersList.Where(C => C.Region == "WA").
            //                           SelectMany(C => C.Orders.Take(3));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2 

            //var orders = CustomersList.Where(C => C.Region == "WA").
            //                SelectMany(C => C.Orders.Skip(2));

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}

            #endregion

            #region 3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num, Index) => num > Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile(num => num % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((num, Index) => num > Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Quantifiers
            #region 1
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Any(word => word.Contains("ei", StringComparison.OrdinalIgnoreCase));

            //if(result)
            //    Console.WriteLine("There is at least the word contain()");
            #endregion

            #region 2

            //var result = ProductsList.GroupBy(P => P.Category).
            //                         Where(P => P.Any(P => P.UnitsInStock == 0));
            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product}");
            //}

            #endregion

            #region 3

            //var result = ProductsList.GroupBy(P => P.Category).
            //                         Where(P => P.All(P => P.UnitsInStock > 0));

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product}");
            //}

            #endregion


            #endregion

            #region LINQ - Grouping operators
            #region 1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupByReminder = numbers.GroupBy(N => N % 5);

            //foreach (var num in groupByReminder)
            //{
            //    Console.WriteLine($"Numers with a reminder of {num.Key} when divided by 5:");


            //    foreach (var value in num)
            //    {

            //        Console.WriteLine($"{value}");
            //    }
            //}
            #endregion

            #region 2
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.OrderBy(word => word).GroupBy(word => word[0]);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Group: {item.Key}");

            //    foreach (var item1 in item)
            //        Console.WriteLine(item1);
            //}
            #endregion

            #region 3
            //String[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr.GroupBy(word => string.Concat(word.OrderBy(c => c)));

            //foreach (var item in result)
            //{
            //    foreach (var item1 in item)
            //        Console.WriteLine(item1);
            //    Console.WriteLine("....");
            //}

            #endregion
            #endregion
        }
    }
}