using Assignment_Lec_2_LINQ.DataSources;

namespace Assignment_Lec_2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1)

            //var result = Source.ProductList.OrderByDescending(P => P.UnitPrice)
            //                               .Take(3);

            #endregion

            #region Q2)

            //int PageSize = 5;
            //int Page = 3;

            //var result = Source.ProductList.Skip((Page - 1) * PageSize)
            //                            .Take(PageSize);

            #endregion

            #region Q3)

            //var result = Source.ProductList.Where(P => P.UnitPrice < 25)
            //                               .OrderBy(P => P.UnitPrice);

            #endregion

            #region Q4)

            //var result = Source.ProductList.Where(P => P.Category == "Seafood")
            //                               .All(P => P.UnitsInStock > 0);
            //Console.WriteLine(result);

            #endregion

            #region Q5)

            //int[] ids = { 3, 9, 13, 18 };

            //Console.WriteLine(ids.Contains(9));

            #endregion

            #region Q6)

            //var result = Source.ProductList.GroupBy(P => P.Category)
            //                               .Select(g => new { Key = g.Key, Value = g.Count() }); ;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value);
            //}

            #endregion

            #region Q7)

            //var result = Source.ProductList.GroupBy(P => P.Category)
            //                               .Select(g => new
            //                                {
            //                                    Category = g.Key,
            //                                    ProductNames = g.Select(p => p.ProductName)
            //                                });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach (var name in group.ProductNames)
            //    {
            //        Console.WriteLine("    " + name);
            //    }
            //}

            #endregion

            #region Q8)

            //var result = Source.ProductList.GroupBy(P => P.Category)
            //                                .Where(G => G.Count() > 3);
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine("    " + product.ProductName);
            //    }
            //}
            #endregion

            #region Q9)

            //var result =from c in Source.CustomerList
            //            group c by c.Country into g
            //            select new
            //            {
            //                Country = g.Key,
            //                Count = g.Count(),
            //                TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //            };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Country}: {item.Count} customers, total order value = {item.TotalOrderValue}");
            //}

            #endregion

            #region Q10)

            //var result = Source.ProductList.Sum(P => P.UnitsInStock);

            //Console.WriteLine(result);

            #endregion

            #region Q11)

            //var result = Source.ProductList.MinBy(P => P.UnitPrice);

            //var result = Source.ProductList.MaxBy(P => P.UnitPrice);


            //Console.WriteLine(result);
            #endregion

            #region Q12)

            //var result =Source.ProductList.Select(P => P.Category).Distinct();

            #endregion

            #region Q13)

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };

            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            #endregion

            #region Q14)

            //string[] List1 = { "Germany", "France", "UK", "Spain" };

            //string[] List2 = { "france", "SPAIN", "Italy" };

            //var result = List1.Except(List2);

            #endregion

            #region Q15)
            //var result = Source.ProductList.ToDictionary(p => p.ProductID);

            //Console.WriteLine(result[18]);
            #endregion

            #region Q16)

            //var result = Source.ProductList.First(P => P.UnitPrice > 50);

            //Console.WriteLine(result);

            #endregion

            #region Q17)

            //var result = Source.ProductList.FirstOrDefault(P => P.UnitPrice > 500);

            //Console.WriteLine(result);

            #endregion

            #region Q18)

            //var result = Enumerable.Range(1, 12)
            //                    .Select(i => $"7 x {i} = {7 * i}");

            #endregion

            #region Q19)

            //var result = Enumerable.Range(1, 30).Where(n => n % 2 == 0);


            #endregion

            #region Q20)

            //var result1 = Source.ProductList.Select(P => P.ProductName).Take(3);

            //var result2 = Source.CustomerList.Select(C => C.CustomerName).Take(3);

            //var result = result1.Concat(result2);

            #endregion

            #region Q21)

            //var result1 = Source.ProductList.Select(P => P.ProductName);

            //var result2 = Source.CustomerList.Select(C => C.CustomerName);

            //var result = result1.Zip(result2, (p, c) => $"{p} - {c}");

            #endregion

            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}
        }
    }
}
