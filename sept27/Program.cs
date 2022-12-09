using System;
using System.Linq;                  //data select, etc
using System.Collections.Generic;   //lists, delegates, etc

//Linq usage:        www.tutorialride.com/csharp/linq-in-c-sharp.htm
//C# – LINQ Select Examples:
//                   //csharp.academy/linq-select/

//C# - Generics:     //www.tutorialspoint.com/csharp/csharp_generics.htm

//delagate, lambda:  //docs.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1?view=net-6.0

//DbFunctions Class: //docs.microsoft.com/en-us/dotnet/api/system.data.entity.dbfunctions?view=entity-framework-6.2.0 

//How to make inline functions in C#:
//                   //stackoverflow.com/questions/4900069/how-to-make-inline-functions-in-c-sharp

//C# List Tutorial: //www.c-sharpcorner.com/article/c-sharp-list/
//C# - List<T>:     //www.tutorialsteacher.com/csharp/csharp-list
//C# List Examples: //www.tutorialspanel.com/c-list-examples/index.htm
namespace liq_samples
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // // // // // // // // // // // // 
            // samples for Linq usage  // // //
            // // // // // // // // // // // //

            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            // numQuery2 List<int>
            List<int> numQuery2 =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToList();

            foreach (int num in numQuery2)
            {
                Console.Write("\n" + num);
            }

            // numQuery3 is still an int[]
            var numQuery3 =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToArray();

            foreach (int num in numQuery3)
            {
                Console.Write("\n" + num);
            }

            // Aggregates
            // numQuery is an IEnumerable<int>
            Console.WriteLine("\n" + "Total count = " + numbers.Count());
            Console.WriteLine("Average     = " + numbers.Average());
            Console.WriteLine("Summation   = " + numbers.Sum());
            Console.WriteLine("Max value   = " + numbers.Max());
            Console.WriteLine("Min Value   = " + numbers.Min());

            List<Employee> empList = new List<Employee>()
            {
            new Employee() { EmployeeID = 1, EmpName = "Raj",    Age = 28 } ,
            new Employee() { EmployeeID = 2, EmpName = "Rajesh", Age = 16 } ,
            new Employee() { EmployeeID = 3, EmpName = "Sunder", Age = 35 } ,
            new Employee() { EmployeeID = 4, EmpName = "Ram" ,   Age = 20 } ,
            new Employee() { EmployeeID = 5, EmpName = "Ronin" , Age = 38 },
            new Employee() { EmployeeID = 5, EmpName = "Ronit" , Age = 38 }
            };

            var empResult = from s in empList
                            where s.Age > 12 && s.Age < 30 && s.EmpName.StartsWith("R") &&
                            s.EmpName.EndsWith("j")
                            select s.EmpName;
            foreach (var emp in empResult)
            {
                Console.WriteLine(emp);
            }

            // order by usage
            var empResult2 = from s in empList
                             orderby s.EmpName descending
                             select s;

            foreach (var emp2 in empResult2)
            {
                Console.WriteLine(emp2.EmpName);
            }

            // group by usage
            var empResult3 = from s in empList group s by s.Age;
            foreach (var emp3 in empResult3)
            {
                Console.WriteLine("Employee Age Group = " + emp3.Key);
                foreach (Employee e in emp3)
                    Console.WriteLine("Student Name: {0}", e.EmpName);
            }

            /*
                LINQ SET OPERATORS
                Linq provides standard set operators such as Except, Intersect, Union, and Distinct.
                These operators behave in same way as in DBMS.

                Union operator
                This operator requires two collections of items. After applying union operator, you will get a new collection. It removes the duplicate entries.

                Intersect operator
                This operator provides the common elements in both lists.

                Except operator
                Except operator provides the element only from first list. The new list does not contain common elements. 
             * */

            string[] List1 = { "One", "Two", "three", "Four", "Six" };
            string[] List2 = { "Two", "THREE", "Four", "Five" };
            Console.WriteLine("Unique elements in both list\n");
            var result = List1.Union(List2);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\n Common elements in both list\n\n");
            var IntResult = List1.Intersect(List2);
            foreach (string str in IntResult)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\n Element in list1 after minus from list2 \n");
            var ExceptResult = List1.Except(List2);
            foreach (string str in ExceptResult)
            {
                Console.WriteLine(str);
            }

            /*
                Partitioning Operators
                The following are the partitioning operators in Linq.

                    Skip
                    SkipWhile
                    Take
                    TakeWhile

                The Skip & SkipWhile operator is not supported in C# query syntax.
                The Skip() method ignore or bypass the specified number of element starting from first element and returns the remaining elements.
                SkipWhile() method works on a condition. It checks the condition from first element, if condition not met it skips the first element and so on. For example, suppose that there are 10 elements in a list and any condition is also applied on the elements, then it checks the elements from starting. Suppose that condition met on fifth element, then it will skip the first four element and return the remaining element.
                The inverse of Skip() is Take() method. The Take() method returns the elements from starting according to given value.             * 
             * */

            List<int> intList = new List<int> { 10, 20, 30, 40, 50, 60 };
            List<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six" };

            Console.WriteLine("Skips the first three elemts from integer list");
            var firstList = intList.Skip(3);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("SkipsWhile method (Length < 4) by string list");
            var secondList = strList.SkipWhile(s => s.Length < 4);
            foreach (string str in secondList)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Takes the first three elements from integer list");
            var thirdList = intList.Take(3);
            foreach (var item in thirdList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("TakeWhile method (Length < 4) by string list");
            var fourthList = strList.TakeWhile(s => s.Length < 4);
            foreach (string str in fourthList)
            {
                Console.WriteLine(str);
            }

            /*
                Quantifier Operators
                Following are the Quantifier Operators in Linq:

                    All
                    Any
                    Contain

                “All” operator checks whether all elements in the list is satisfies the specified condition or not. It returns true if all the elements satisfy a condition otherwise it returns false.
                “Any” operator checks whether any element in the list satisfy given condition or not. It returns true if any element satisfy the given condition.
                As it name indicates “Contains” operator checks whether a particular element exists in the collection or not. It also returns true or false. It returns true if any element available in the given list.* 
             * */

            Console.WriteLine("Does All employee satisfies the condition. Age > 12 && Age < 20");
            bool Allemp = empList.All(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(Allemp);
            Console.WriteLine("Does Any employee satisfies the condition Age > 12 && Age < 20");
            bool anyEmp = empList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(anyEmp);

            //You can use Contains operator as given below.
            List<int> intList2 = new List<int>() { 10, 20, 30, 40, 50 };
            bool result2 = intList2.Contains(10);  // returns true
            Console.WriteLine("Contains: " + result2);

            /*
                Element Operators (Methods)
                Following are the Element Operators (Methods) in Linq:

                    ElementAt
                    First
                    Last
                    Single
                    ElementAtOrDefault
                    FirstOrDefault
                    LastOrDefault
                    SingleOrDefault

                The ElementAt() method returns an element according to given index from a collection. If the given index is out of the range of a collection then it will throw an Index out of range exception. In the given below example, intList.ElementAtOrDefault(11) returns 0 (default value of int) because intList does not include 12th element.
                First() method returns the first element of a collection. First() method will throw an exception if a collection does not include any element.
                The Last() method returns the last element from a collection. It can also check some condition using lambda expression or Func delegate.            * 
             * */

            List<int> intList3 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            List<string> strList3 = new List<string>() { "One", "Two", "Three", null, "Five" };
            Console.WriteLine("1st Element in intList: {0}", intList3.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList3.ElementAt(0));
            Console.WriteLine("4th Element in intList: {0}", intList3.ElementAtOrDefault(3));
            Console.WriteLine("4th Element in strList: {0}", strList3.ElementAtOrDefault(3));
            Console.WriteLine("11th Element in intList: {0}  :  default int value",
                            intList.ElementAtOrDefault(11));
            Console.WriteLine("11th Element in strList: {0}  : default string value is (null)",
                             strList.ElementAtOrDefault(11));
            Console.WriteLine("First Even Element in intList: {0}", intList3.First(i => i % 2 == 0));
            Console.WriteLine("First Element in strList: {0}", strList3.First());
            Console.WriteLine("Last Element in intList: {0}", intList3.Last());
            Console.WriteLine("Last Element in strList: {0}", strList3.Last());

            Console.ReadKey();
        }
    }
}