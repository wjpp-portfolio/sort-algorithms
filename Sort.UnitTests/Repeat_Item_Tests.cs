using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class Repeat_Item_Tests
{     
    List<int> numbers = new List<int> {5,2,6,1,3,4,7,8,6,6,9};
    List<int> expected_result = new List<int> {1,2,3,4,5,6,6,6,7,8,9};


    [TestMethod]
    public void Bubble_RepeatItem()
    {
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);
        CollectionAssert.AreEqual(expected_result, result);  
    }
    [TestMethod]
    public void Merge_RepeatItem()
    {
        var a = new Sorter();
        List<int> result = a.Merge(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Quick_RepeatItem()
    {
        var a = new Sorter();
        List<int> result = a.Quick(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Select_RepeatItem()
    {
        var a = new Sorter();
        List<int> result = a.Select(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
}