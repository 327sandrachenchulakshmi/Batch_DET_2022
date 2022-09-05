using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    public class LINQ
    {
         public static void Main()
         {
            //Sample_TakeWhile();
            //static void Sample_OrderBy();
            //Sample_Aggregate();
            //Sample_Average();
            //Sample_Count();
            //Sample_Max();
            //Sample_Min();
            //Sample_Sum();
            //Sample_ElementAt();
            //Sample_Count();
            //Sample_Max();
            //Sample_Allexe();
            //Sample_Maxexe();
            //Sample_words();
            //Sample_Reverseexe();
            String_Groupby();



        }
        //private static void SampleIntList()
        //{
        //    List<int> numbers = new List<int>();
        //    numbers.Add(110);
        //    numbers.Add(100);
        //    numbers.Add(105);
        //    numbers.Add(102);


        //    //var numQuery = from num in numbers
        //    //               select num;

        //    var numQuery = numbers.Where(x => x>102);


        //    foreach (int num in numQuery)
        //    {
        //        Console.WriteLine("{0}",num);

        //    }
        //    Console.ReadLine();



        //}

        //static void Sample_OrderBy()
        //{
        //    int[] numbers = { 15,2,20 };

        //    var result = numbers.OrderBy(n => n);

        //    Console.WriteLine("Ordered list of numbers:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}

        //static void SampleOrderByDescending()
        //{
        //    string[] names = { "keerthi", "nani", "chandu" };

        //    var result = names.OrderByDescending(n => n);

        //    Console.WriteLine("Descending ordered list of names:");
        //    foreach (string name in result)
        //        Console.WriteLine(name);
        //}



        //static void SampleReverse()
        //{
        //    char[] characters = { 'm', 's', 'a', 'n', 'b', 'c' };

        //    var result = characters.Reverse();

        //    Console..WriteLine("Characters in reverse order:");
        //    foreach (char character in result)
        //       Console..WriteLine(character);
        //}



        //static void  SampleThenBy()
        //{

        //    string[] capitals = { "sandra", "harshi", "Madrid", "Tokyo", "London",
        //                  "Athens", "Beijing", "Seoul" };

        //    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

        //    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //    foreach (string capital in result)
        //        Console..WriteLine(capital);
        //}


        //    static void SamplehenByDescending()
        //    {
        //        var dates = new DateTime[] {
        //    new DateTime(2015, 3, 1),
        //    new DateTime(2014, 7, 1),
        //    new DateTime(2013, 5, 1),
        //    new DateTime(2015, 1, 1),
        //    new DateTime(2015, 7, 1)
        //};

        //        var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

        //        Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
        //        foreach (DateTime dt in result)
        //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        // }


        //static void Sample_Skip()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.Skip(4);

        //    Console.WriteLine("Skips the first 4 words:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}



        //static void Sample_SkipWhile()
        //{
        //    string[] words = { "one", "two", "three", "four", "five", "six" };

        //    var result = words.SkipWhile(w => w.Length == 3);

        //    Console.WriteLine("Skips words while the condition is met:");
        //    foreach (string word in result)
        //        Console.WriteLine(word);
        //}



        //static void Sample_Take()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.Take(5);

        //    Console.WriteLine("Takes the first 5 numbers only:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}



        //static void Sample_TakeWhile()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    var result = numbers.TakeWhile(n => n < 5);

        //    Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //    foreach (int number in result)
        //        Console.WriteLine(number);
        //}



        //private static void Sample_Aggregate()
        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("Aggregated numbers by multiplication:");
        //    Console.WriteLine(result);
        //}


        //static void Sample_Average()
        //{
        //    int[] numbers = { 10, 10, 11, 11 };

        //    var result = numbers.Average();

        //    Console.WriteLine("Average is:");
        //    Console.WriteLine(result);
        //}


        //static void Sample_Count()
        //{
        //    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

        //    var result = names.Count();

        //    Console.WriteLine("Counting names gives:");
        //    Console.WriteLine(result);
        //}


        //static void Sample_Max()
        //{
        //    int[] numbers = { 2, 8, 5, 6, 1,80 };

        //    var result = numbers.Max();

        //    Console.WriteLine("Highest number is:");
        //    Console.WriteLine(result);
        //}


        //        static void Sample_Min()
        //        {
        //            int[] numbers = { 6, 9, 3, 7, 5 };

        //            var result = numbers.Min();

        //            Console.WriteLine("Lowest number is:");
        //            Console.WriteLine(result);
        //        }


        //        static void Sample_Sum()
        //        {
        //            int[] numbers = { 2, 5, 10 };

        //            var result = numbers.Sum();

        //            Console.WriteLine("Summing the numbers yields:");
        //            Console.WriteLine(result);
        //        }


        //        static void Sample_ElementAt()
        //        {
        //            string[] words = { "One", "Two", "Three" };

        //            var result = words.ElementAt(1);

        //            Console.WriteLine("Element at index 1 in the array is:");
        //            Console.WriteLine(result);
        //        }



        //        static void Sample_ElementAtOrDefault()
        //        {
        //            string[] colors = { "Red", "Green", "Blue" };

        //            var resultIndex1 = colors.ElementAtOrDefault(1);

        //            var resultIndex10 = colors.ElementAtOrDefault(10);

        //            Console.WriteLine("Element at index 1 in the array contains:");
        //            Console.WriteLine(resultIndex1);

        //            Console.WriteLine("Element at index 10 in the array does not exist:");
        //            Console.WriteLine(resultIndex10 == null);
        //        }



        //        static void Sample_First()
        //        {
        //            string[] fruits = { "Banana", "Apple", "Orange" };

        //            var result = fruits.First();

        //            Console.WriteLine("First element in the array is:");
        //            Console.WriteLine(result);

        //        }


        //        static void Sample_First_Lambda()
        //        {
        //            string[] countries = { "Denmark", "Sweden", "Norway" };

        //            var result = countries.First(c => c.Length == 6);

        //                        .WriteLine(result);
        //            Console.WriteLine("First element with a length of 6 characters:");
        //            Console.WriteLine(result);
        //        }


        //        static void Sample_Last()
        //        {
        //            int[] numbers = { 7, 3, 5 };

        //            var result = numbers.Last();

        //            Console.WriteLine("Last number in array is:");
        //            Console.WriteLine(result);
        //        }



        //        static void Sample_LastOrDefault)
        //        {
        //            string[] words = { "one", "two", "three" };
        //            string[] empty = { };

        //            var result = words.LastOrDefault();

        //            var resultEmpty = empty.LastOrDefault();

        //            Console.WriteLine("Last element in the words array contains:");
        //            Console.WriteLine(result);
        //            Console.WriteLine("Last element in the empty array does not exist:");
        //            Console.WriteLine(resultEmpty == null);
        //        }


        //        static void Sample_LastOrDefault()
        //        {
        //            string[] words = { "one", "two", "three" };

        //            var result = words.LastOrDefault(w => w.Length == 3);

        //            var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

        //            Console.WriteLine("Last element in the words array having a length of 3:");
        //            Console.WriteLine(result);

        //            Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
        //            Console.WriteLine(resultNoMatch == null);
        //        }


        //        static void Sample_Single()
        //        {
        //            string[] names1 = { "Peter" };
        //            string[] names3 = { "Peter", "Joe", "Wilma" };
        //            string[] empty = { };

        //            var result1 = names1.Single();

        //            Console.WriteLine("The only name in the array is:");
        //            Console.WriteLine(result1);

        //            try
        //            {
        //                // This will throw an exception because array contains no elements
        //                var resultEmpty = empty.Single();
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //            }

        //            try
        //            {
        //                // This will throw an exception as well because array contains more than one element
        //                var result3 = names3.Single();
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //            }
        //        }


        //        static void Sample_SingleOrDefault()
        //        {
        //            string[] names1 = { "Peter" };
        //            string[] names3 = { "Peter", "Joe", "Wilma" };
        //            string[] empty = { };

        //            var result1 = names1.SingleOrDefault();

        //            var resultEmpty = empty.SingleOrDefault();

        //            Console.WriteLine("The only name in the array is:");
        //            Console.WriteLine(result1);

        //            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
        //            Console.WriteLine(resultEmpty == null);

        //            try
        //            {
        //                // This will throw an exception as well because array contains more than one element
        //                var result3 = names3.SingleOrDefault();
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //            }
        //        }


        //        static void Sample_All()
        //        {
        //            string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //            var result = names.All(n => n.StartsWith("B"));

        //            Console.WriteLine("Does all of the names start with the letter 'B':");
        //            Console.WriteLine(result);
        //        }

        //        static void Sample_Any()
        //        {
        //            string[] names = { "Bob", "Ned", "Amy", "Bill" };

        //            var result = names.Any(n => n.StartsWith("B"));

        //            Console.WriteLine("Does any of the names start with the letter 'B':");
        //            Console.WriteLine(result);
        //        }


        //        static void Sample_Contains()
        //        {
        //            int[] numbers = { 1, 3, 5, 7, 9 };

        //            var result = numbers.Contains(5);

        //            Console.WriteLine(result);
        //        }

        //        static void Sample_Distinct()
        //        {
        //            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

        //            var result = numbers.Distinct();

        //            Console.WriteLine("Distinct removes duplicate elements:");
        //            foreach (int number in result)
        //                Console.WriteLine(number);
        //        }

        //        static void Sample_Except()
        //        {
        //            int[] numbers1 = { 1, 2, 3 };
        //            int[] numbers2 = { 3, 4, 5 };

        //            var result = numbers1.Except(numbers2);

        //            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
        //            foreach (int number in result)
        //                Console.WriteLine(number);
        //        }


        //        static void Sample_Intersect()
        //        {
        //            int[] numbers1 = { 1, 2, 3 };
        //            int[] numbers2 = { 3, 4, 5 };

        //            var result = numbers1.Intersect(numbers2);

        //            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
        //            foreach (int number in result)
        //                Console.WriteLine(number);
        //        }

        //        static void Sample_Union()
        //        {
        //            int[] numbers1 = { 1, 2, 3 };
        //            int[] numbers2 = { 3, 4, 5 };

        //            var result = numbers1.Union(numbers2);

        //            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
        //            foreach (int number in result)
        //               Console.WriteLine(number);

        //        }



        //static void Sample_Allexe()
        //{
        //    string[] names = { "jhon", "Peter", "Jacob", "Harry", "jackson" };

        //    var result = names.Where(word => word.Contains('o'));
        //    foreach (var word in result)
        //    {
        //        Console.WriteLine(word);
        //    }
        //}

        //static void Sample_Maxexe()
        //{
        //    string[] names = { "jhon", "Peter", "Jacob", "Harry", "jackson" };

        //    var result = names.Max();
        //    var name = result.Where(x => x.c.Length == 2);

        //    Console.WriteLine("Highest name is:");
        //    Console.WriteLine(result);
        //}


        //static void Sample_words()
        //{
        //    string[] words1 = { "believe", "relief", "receipt", "field" };
        //    if words = 7
        //    {
        //        return belive and receipt;
        //    }
        //    if else words =6
        //          {
        //        return relife;
        //          }



        //static void Sample_Reverseexe()
        //{
        //    string[] names= { "blueberry", "blackberry", "abacus" };

        //    var result = names.Reverse();

        //    Console.WriteLine("string in reverse order:");
        //    foreach (string name in result)
        //        Console.WriteLine(names);
        //}


        public static void String_Groupby()
        {
            List<string> words = new List<string> { "basket", "apple", "bat", "rat", "amma", "bobby" };
            var wordGroups = words.GroupBy(X => X[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });
        
            foreach (var item in wordGroups)
            {
              Console.WriteLine("words that strats with the" +
              "letter '{0}';",
              item.FirstLetter);
                foreach (var W in item.Words)
                {
                    Console.WriteLine('W');
                }
            }
            Console.ReadLine();
         }
     }
}

            
            

            
        

    

   



