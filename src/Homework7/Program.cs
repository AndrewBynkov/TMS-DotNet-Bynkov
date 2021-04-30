using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Transactions;

namespace Homework7
{
    partial class Program
    {
        public static Action ConversionAggrigation;
        public static Action Element;
        public static Action Generation;
        public static Action Grouping;
        public static Action Other;
        public static Action Partitionong;
        public static Action Restriction;
        public static Action Quantifiers;

        static void Main(string[] args)
        {
            AddToDelegate();
            ConversionAggrigation();
            Element();
            Generation();
            Grouping();
            Other();
            Partitionong();
            Restriction();
            Quantifiers();

            IEnumerable<int> arr = new int[] { 1, 3, 4, 5, 5 };
            arr.ToList();
            Console.WriteLine(arr.GetType());
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.Last());
            Console.WriteLine(arr.First());
            Console.WriteLine($"Last or def - {arr.LastOrDefault()}");
            Console.WriteLine($"Single or def {arr.SingleOrDefault()}");
            Console.WriteLine($"DefEmpty - {arr.DefaultIfEmpty()}");
            var result44 = Enumerable.Repeat("Andrew", 5 );
            var result55 = Enumerable.Range(1, 101);

        }

        private static void ToList()
        {
            IEnumerable<int> arr = new int[] { 1, 3, 4, 5};
            arr.ToList();
            Console.WriteLine(arr.GetType());
        }

        /// <summary>
        /// My variant
        /// </summary>
        private static void Sample_All_Lambda()
        #region
        {
            string[] names = { "Andrew@mail.ru", "Ann@gmail.ru", "Kristina", "Bill" };

            var result = names.Any(boolValue => boolValue.Contains("@"));

            Console.Write("Have char - '@': ");
            Console.WriteLine(result);
        }
        #endregion

        /// <summary>
        /// My variant aggregate
        /// </summary>
        private static void StringAggregate()
        #region
        {
            string[] arrayString = new string[] { "John", "Andrew", "Bob", "Jameson" };

            var result = arrayString.Aggregate((current, next) =>
            {
                if (next == "Bob")
                {
                    next =  next.Replace(next, "Abraham");
                }
                return current + " "+ next;
            });

            Console.WriteLine(result);
            Console.WriteLine();
        }
        #endregion

        static void Sample_Where_Lambda_Objects()
        #region
        {
            //выбираем элементы соответствующие нашим условиям
            Person[] persons =
            {
                new Person { Name = "Mike", Age = 25 },
                new Person { Name = "Joe", Age = 43 },
                new Person { Name = "Nadia", Age = 31 }
            };

            var result = persons.Where(p => p.Age <= 30);

            Console.WriteLine("Finding persons who are 30 years old or older:");
            foreach (Person person in result)
                Console.WriteLine(String.Format("{0}: {1} years old", person.Name, person.Age));
            Console.WriteLine();
        }
        #endregion

        static void Sample_SkipWhile_Lambda()
        #region
        {
            //скипает элементы указанной длинны, но еслт позже попадется элемент такой же длинны то больше не скипнет.
            string[] words = {"a", "one", "two", "three", "four", "five", "six" };

            var result = words.SkipWhile(w => w.Length == 3 || w.Length <= 1);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
            Console.WriteLine();
        }
        #endregion

        static void Sample_SequenceEqual_Lambda()
        #region
        {
            //Слияние коллекций, если коллекции одинаковые то true если нет то false
            string[] words = { "one", "two", "three" };
            string[] wordsSame = { "one", "two", "three" };
            string[] wordsOrder = { "two", "three", "one" };
            string[] wordsCase = { "one", "TWO", "three" };

            var resultSame = words.SequenceEqual(wordsSame);
            var resultOrder = words.SequenceEqual(wordsOrder);
            var resultCase = words.SequenceEqual(wordsCase);
            var resultCaseIgnored = words.SequenceEqual(wordsCase, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("SequenceEqual on two identical arrays:");
            Console.WriteLine(resultSame);

            Console.WriteLine("SequenceEqual on two differently ordered but otherwise identical arrays:");
            Console.WriteLine(resultOrder);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays:");
            Console.WriteLine(resultCase);

            Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays, where case is ignored:");
            Console.WriteLine(resultCaseIgnored);
            Console.WriteLine();
        }
        #endregion

        static void Sample_GroupBy_Lambda()
        #region
        {
            //поочередно берем каждый элемент и смотрим на остаток от деления на 10. Key это true or false
            int[] numbers = { 10, 15, 20, 25, 30, 35 };

            var result = numbers.GroupBy(n => (n % 10 == 0));

            Console.WriteLine("GroupBy has created two groups:");
            foreach (IGrouping<bool, int> group in result)
            {
                if (group.Key == true)
                    Console.WriteLine("Divisible by 10");
                else
                    Console.WriteLine("Not Divisible by 10");

                foreach (int number in group)
                    Console.WriteLine(number);
            }
            Console.WriteLine();
        }
        #endregion

        static void Sample_Empty_Lambda()
        #region
        {
            //количество элементов в коллекции
            var empty = Enumerable.Empty<string>();
            // To make sequence into an array use empty.ToArray()

            Console.Write("Sequence is empty: ");
            Console.WriteLine(empty.Count() == 0);
        }
        #endregion

        private static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
        #region
        {
            //Если коллекция пуста, возвращается ее значение по умолчанию. Выставляем значение по умолчанию 5.
            int[] empty = { };

            var result = empty.DefaultIfEmpty(6);

            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_DefaultIfEmpty_Lambda_Simple()
        #region
        {
            //проверяем коллекции
            string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };

            var resultStr = emptyStr.DefaultIfEmpty(); // Default is null for string

            var resultInt = emptyInt.DefaultIfEmpty(); // Default is 0 for int

            var resultWords = words.DefaultIfEmpty(); // Not empty, so words array is just copied

            Console.Write("resultStr has one element with a value of null: ");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.Write("resultInt has one element with a value of 0: ");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.Write("resultWords has same content as words array: ");
            Console.WriteLine(resultWords.SequenceEqual(words));
            Console.WriteLine();
        }
        #endregion

        private static void Sample_SingleOrDefault_Lambda()
        #region
        {
            //Проверка на единственный элемент. Если больше - null, если меньше - тоже null, если один, то выводится элемент.
            string[] names1 = { "Peter" };
            string[] names3 = { "Peter", "Joe", "Wilma" };
            string[] empty = { };

            var result1 = names1.SingleOrDefault();

            var resultEmpty = empty.SingleOrDefault();

            Console.WriteLine("The only name in the array is:");
            Console.WriteLine(result1);

            Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            Console.WriteLine(resultEmpty == null);

            try
            {
                // This will throw an exception as well because array contains more than one element
                var result3 = names3.SingleOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
        #endregion

        private static void Sample_ElementAtOrDefault_Lambda()
        #region
        {
            string[] colors = { "Red", "Green", "Blue" };

            var resultIndex1 = colors.ElementAtOrDefault(1);

            var resultIndex10 = colors.ElementAtOrDefault(10);

            Console.WriteLine("Element at index 1 in the array contains:");
            Console.WriteLine(resultIndex1);

            Console.WriteLine("Element at index 10 in the array does not exist:");
            Console.WriteLine(resultIndex10 == null);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_ElementAt_Lambda()
        #region
        {
            // достаем элемент из коллекции по индексу
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.Write("Element at index 1 in the array is: ");
            Console.WriteLine(result);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_ToLookup_Lambda()
        #region
        {
            //в этом случае сортировка по длинне строк. В цикле for выставляем длинну строки и проверяем строки из массива w = "one".Lenght = 3, и т.д.
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                {
                    Console.WriteLine(word);
                }
            }
            Console.WriteLine();
        }
        #endregion

        private static void Sample_ToDictionary_Lambda_Conditional()
        #region
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Debug.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_ToDictionary_Lambda_Simple()
        #region
        {
            //Создали экземпляр english2German, инициализировали, создали словарь где (k - key, v - value)
            English2German[] english2German =
            {
                new English2German { EnglishSalute = "Good morning", GermanSalute = "Guten Morgen" },
                new English2German { EnglishSalute = "Good day", GermanSalute = "Guten Tag" },
                new English2German { EnglishSalute = "Good evening", GermanSalute = "Guten Abend" },
            };

            var result = english2German.ToDictionary(k => k.EnglishSalute, v => v.GermanSalute);

            Console.WriteLine("Values inserted into dictionary:");
            foreach (KeyValuePair<string, string> dic in result)
                Console.WriteLine(String.Format("English salute {0} is {1} in German", dic.Key, dic.Value));
            Console.WriteLine();
        }
        #endregion

        private static void Sample_OfType_Lambda()
        #region
        {
            //Фильтр элементов коллекции (ищет элементы заданного типа)
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = objects.OfType<string>();

            Debug.WriteLine("Objects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_Cast_Lambda()
        #region
        {
            //Приводит коллекцию к указанному типу. В этом случае "string"
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = vegetables.Cast<string>();

            Debug.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
            Console.WriteLine();
        }
        #endregion

        private static void Sample_AsEnumerable_Lambda()
        #region
        {
            //Переводит Коллекция в Enumerable типа коллекции (того же)
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Debug.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
            Console.WriteLine();
        }
        #endregion

        private static void LinqAgregateSeed()
        #region
        {
            //Прибавление к заданному числу элементов коллекции, массива по очереди
            var numbers = new int[] { 1, 2, 3 };

            var result = numbers.Aggregate(100, (a, b) => a + b);

            Debug.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Debug.WriteLine(result);
            Console.WriteLine(result);
            Console.WriteLine();
        }
        #endregion

        private static void LinqAgregateSimple()
        #region
        {
            //Умножене a*=b
            var numbers = new int[] { 2, 2, 4 };

            var result = numbers.Aggregate((a, b) => a * b);

            Debug.WriteLine("Aggregated numbers by multiplication:");
            Debug.WriteLine(result);
            Console.WriteLine(result);
            Console.WriteLine();
        }
        #endregion

        private static void AddToDelegate()
        #region
        {
            ConversionAggrigation = LinqAgregateSimple;
            ConversionAggrigation += LinqAgregateSeed;
            ConversionAggrigation += Sample_AsEnumerable_Lambda;
            ConversionAggrigation += Sample_Cast_Lambda;
            ConversionAggrigation += Sample_OfType_Lambda;
            ConversionAggrigation += Sample_ToDictionary_Lambda_Simple;
            ConversionAggrigation += Sample_ToDictionary_Lambda_Conditional;
            ConversionAggrigation += Sample_ToLookup_Lambda;
            Element = Sample_ElementAt_Lambda;
            Element += Sample_ElementAtOrDefault_Lambda;
            Element += Sample_SingleOrDefault_Lambda;
            Generation = Sample_DefaultIfEmpty_Lambda_Simple;
            Generation += Sample_DefaultIfEmpty_Lambda_DefaultValue;
            Generation += Sample_Empty_Lambda;
            Grouping += Sample_GroupBy_Lambda;
            Other = Sample_SequenceEqual_Lambda;
            Partitionong = Sample_SkipWhile_Lambda;
            Restriction = Sample_Where_Lambda_Objects;
            Restriction = StringAggregate;
            Quantifiers = Sample_All_Lambda;
        }
        #endregion
    }
}