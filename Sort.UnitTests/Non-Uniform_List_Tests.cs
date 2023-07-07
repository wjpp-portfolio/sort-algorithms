using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort.Services;

namespace Sort.UnitTests;

[TestClass]
public class NonUniform_List_Tests
{     
    List<int> numbers = new List<int> {55,923,111,9,48,0,482293,13,2};
    List<int> expected_result = new List<int> {0,2,9,13,48,55,111,923,482293};


    [TestMethod]
    public void Bubble_NonUniformList()
    {
        var a = new Sorter();
        List<int> result = a.Bubble(numbers);
        CollectionAssert.AreEqual(expected_result, result);  
    }
    [TestMethod]
    public void Merge_NonUniformList()
    {
        var a = new Sorter();
        List<int> result = a.Merge(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Quick_NonUniformList()
    {
        var a = new Sorter();
        List<int> result = a.Quick(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
    [TestMethod]
    public void Select_NonUniformList()
    {
        var a = new Sorter();
        List<int> result = a.Select(numbers);
        CollectionAssert.AreEqual(expected_result, result);
    }
}