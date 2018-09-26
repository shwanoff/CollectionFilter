using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionFilter
{
    /// <summary>
    /// Get subcollection.
    /// In case of ambiguity, put in target collection any of input elements.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Unique by Number elements.
        /// </summary>
        public ICollection<Element> GetUniqueElementsByNumber(ICollection<Element> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException(nameof(elements), "Collection of elements can't be Null");
            }

            var result = elements.Where(element => element.Age > 20)
                                 .Distinct()
                                 .GroupBy(element => element.Number)
                                 .Select(element => element.FirstOrDefault());

            return result.ToArray();

        }
    }
}
