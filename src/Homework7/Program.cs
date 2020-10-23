using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Homework7
{
    partial class Program
    {
        public static Action ConversionAggrigation;
        public static Action Element;
        public static Action Generation;

        static void Main(string[] args)
        {
            AddToDelegate();
            ConversionAggrigation();
            Element();
            Generation();
        }

        private static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
        {
            //Если коллекция пуста, возвращается ее значение по умолчанию. Выставляем значение по умолчанию 5.
            int[] empty = { };

            var result = empty.DefaultIfEmpty(6);

            Console.WriteLine("result contains one element with a value of 5:");
            Console.WriteLine(result.Count() == 1 && result.First() == 5);
            Console.WriteLine();
        }

        private static void Sample_DefaultIfEmpty_Lambda_Simple()
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

        private static void Sample_SingleOrDefault_Lambda()
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

        private static void Sample_ElementAtOrDefault_Lambda()
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

        private static void Sample_ElementAt_Lambda()
        {
            // достаем элемент из коллекции по индексу
            string[] words = { "One", "Two", "Three" };

            var result = words.ElementAt(1);

            Console.Write("Element at index 1 in the array is: ");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void Sample_ToLookup_Lambda()
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

        private static void Sample_ToDictionary_Lambda_Conditional()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Debug.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
            Console.WriteLine();
        }

        private static void Sample_ToDictionary_Lambda_Simple()
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

        private static void Sample_OfType_Lambda()
        {
            //Фильтр элементов коллекции (ищет элементы заданного типа)
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = objects.OfType<string>();

            Debug.WriteLine("Objects being of type string have the values:");
            foreach (string str in result)
                Console.WriteLine(str);
            Console.WriteLine();
        }

        private static void Sample_Cast_Lambda()
        {
            //Приводит коллекцию к указанному типу. В этом случае "string"
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = vegetables.Cast<string>();

            Debug.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
            Console.WriteLine();
        }

        private static void Sample_AsEnumerable_Lambda()
        {
            //Переводит Коллекция в Enumerable типа коллекции (того же)
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Debug.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
            Console.WriteLine();
        }

        private static void LinqAgregateSeed()
        {
            //Прибавление к заданному числу элементов коллекции, массива по очереди
            var numbers = new int[] { 1, 2, 3 };

            var result = numbers.Aggregate(100, (a, b) => a + b);

            Debug.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Debug.WriteLine(result);
            Console.WriteLine(result);
            Console.WriteLine();
        }

        private static void LinqAgregateSimple()
        {
            //Умножене a*=b
            var numbers = new int[] { 2, 2, 4 };

            var result = numbers.Aggregate((a, b) => a * b);

            Debug.WriteLine("Aggregated numbers by multiplication:");
            Debug.WriteLine(result);
            Console.WriteLine(result);
            Console.WriteLine();
        }

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
        }
        #endregion
    }
}