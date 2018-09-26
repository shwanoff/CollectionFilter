using System;

namespace CollectionFilter
{
    public class Element
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Element(int number, string name, int age)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number can't be less than 0.", nameof(number));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name can't be Null, Empty or contains only Whitespaces.");
            }

            if (age < 0)
            {
                throw new ArgumentException("Age can't be less than 0.", nameof(age));
            }

            Number = number;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Number}: {Name}[{Age}]";
        }
    }
}
