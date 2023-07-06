using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class Sort_Tests
{     

    [TestMethod]
    public void Bubble_EmptyList()
    {
        List<int> numbers = new List<int> {};
        List<int> expected_result = new List<int> {};
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);

        CollectionAssert.AreEqual(expected_result, result);
       
    }
}