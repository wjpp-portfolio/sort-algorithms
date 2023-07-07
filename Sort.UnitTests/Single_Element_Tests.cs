using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class Single_Element_Tests
{     
    List<int> numbers = new List<int> {5};
    List<int> expected_result = new List<int> {5};


    [TestMethod]
    public void Bubble_Single_Element()
    {
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);
        CollectionAssert.AreEqual(expected_result, result);  
    }
    [TestMethod]
    public void Merge_Single_Element()
    {
        var a = new Sorter();
        List<int> result = a.Merge(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Quick_Single_Element()
    {
        var a = new Sorter();
        List<int> result = a.Quick(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Select_Single_Element()
    {
        var a = new Sorter();
        List<int> result = a.Select(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
}