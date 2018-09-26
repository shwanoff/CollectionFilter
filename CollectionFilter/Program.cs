using System;
using System.Collections.Generic;

namespace CollectionFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Element>
            {
                new Element(1, "John", 21),
                new Element(1, "Mat", 22),
                new Element(2, "Marry", 23),
                new Element(3, "Vadim", 27),
                new Element(3, "Sam", 27),
                new Element(4, "John", 21)
            };

            var filter = new Filter();
            var result = filter.GetUniqueElementsByNumber(collection);

            foreach(var element in result)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
