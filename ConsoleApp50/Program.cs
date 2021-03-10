using System;
using System.Collections.Generic;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            var mydictionary = new MyDictionary[]
            {
                new MyDictionary{LanguageType = "C#", State = MyDictionaryState.CurrentlyExplore},
                new MyDictionary{LanguageType = "PHP", State = MyDictionaryState.FinnishedCourse},
                new MyDictionary{LanguageType = "GoLang", State = MyDictionaryState.CurrentlyExplore},
                new MyDictionary{LanguageType = "JavaScript", State = MyDictionaryState.NewLanguage}
            };
            foreach (var item in mydictionary)
            {
                if (item.State == MyDictionaryState.CurrentlyExplore)
                {
                    Console.WriteLine($"{item.LanguageType} - {item.State}");
                }
                if (item.State == MyDictionaryState.FinnishedCourse)
                {
                    Console.WriteLine($"{item.LanguageType} - {item.State}");
                }
                if (item.State == MyDictionaryState.NewLanguage)
                {
                    Console.WriteLine($"{item.LanguageType} - {item.State}");
                }
            }
        }



            
        class MyDictionary
        {
            public string LanguageType { get; set; }
            public MyDictionaryState State { get; set; }
        }
        enum MyDictionaryState
        {
            NewLanguage,
            CurrentlyExplore,
            FinnishedCourse,

        }

    }

}
