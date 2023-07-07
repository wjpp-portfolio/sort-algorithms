using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class Negative_Value_Tests
{     
    List<int> numbers = new List<int> {4,23,1,-7,5,2,0};
    List<int> expected_result = new List<int> {-7,0,1,2,4,5,23};


    [TestMethod]
    public void Bubble_NegativeValue()
    {
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);
        CollectionAssert.AreEqual(expected_result, result);  
    }
    [TestMethod]
    public void Merge_NegativeValue()
    {
        var a = new Sorter();
        List<int> result = a.Merge(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Quick_NegativeValue()
    {
        var a = new Sorter();
        List<int> result = a.Quick(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Select_NegativeValue()
    {
        var a = new Sorter();
        List<int> result = a.Select(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
}