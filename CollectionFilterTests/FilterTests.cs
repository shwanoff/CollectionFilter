using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionFilter.Tests
{
    [TestClass()]
    public class FilterTests
    {
        [TestMethod()]
        public void GetCollectionTest()
        {
            // Arrange.
            var itemCount = 1000000;
            var nameLength = 5;
            var maxNumber = 1000;
            var maxAge = 100;
            var filter = new Filter();
            var collection = new List<Element>(itemCount * 2);
            var rnd = new Random();

            for(var i = 0; i < itemCount; i++)
            {
                var name = Guid.NewGuid().ToString().Substring(0, nameLength);
                var number = rnd.Next(maxNumber);
                var age = rnd.Next(maxAge);
                var element = new Element(number, name, age);
                collection.Add(element);
            }

            // Act.
            var result = filter.GetUniqueElementsByNumber(collection);

            // Assert.
            Assert.IsTrue(result.All(element => element.Age > 20));
            Assert.IsTrue(result.Count == result.Distinct().Count());
            Assert.IsTrue(result.Count == result.Select(element => element.Number).Distinct().Count());
        }
    }
}