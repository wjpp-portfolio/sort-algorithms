using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class Empty_List_tests
{     
    List<int> numbers = new List<int> {};
    List<int> expected_result = new List<int> {};


    [TestMethod]
    public void Bubble_EmptyList()
    {
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);
        CollectionAssert.AreEqual(expected_result, result);  
    }
    [TestMethod]
    public void Merge_EmptyList()
    {
        var a = new Sorter();
        List<int> result = a.Merge(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Quick_EmptyList()
    {
        var a = new Sorter();
        List<int> result = a.Quick(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Select_EmptyList()
    {
        var a = new Sorter();
        List<int> result = a.Select(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
}