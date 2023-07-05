using System;

class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> {8,3,2,9,4,6,5,7,1};

        var a = new Sorter();

        Display(numbers);
        var result = a.Merge(numbers);
        Display(result);
    
    }
    private static void Display(List<int> listOfInts)
    { 
        foreach (var item in listOfInts)
        {
            Console.Write(item);
        }
        Console.WriteLine("");
    }
}

class Sorter
{
    public List<int> Bubble(List<int> working_list)
    {
        int counter = 0;
        bool changes;

        do
        {
            changes = false;
            for (int index = 0; index < working_list.Count - counter; index++)
            {             
                try
                {
                    if (working_list[index] > working_list[index + 1])
                    {
                        (working_list[index], working_list[index + 1]) = (working_list[index + 1], working_list[index]);
                        changes = true;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    //Console.WriteLine("---Index Out Of Range");
                }               
            }

            counter++;
 
        } while (changes != false);

        return working_list;
    }
    public List<int> Merge(List<int> working_list)
    {
        if (working_list.Count <= 1) 
        {
            return working_list;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int index = 0; index <= working_list.Count - 1; index++)
        {
            if (index < (working_list.Count / 2))
            {
                left.Add(working_list[index]);
            }
            else
            {
                right.Add(working_list[index]);
            }
        }
        left = Merge(left);
        right = Merge(right);

        return Merge_Sublists(left, right);
    }
    private List<int> Merge_Sublists(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 & right.Count > 0)
        {
            if (left[0] <= right[0])
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        while (left.Count > 0)
        {
            result.Add(left[0]);
            left.RemoveAt(0);
        }
        while (right.Count > 0)
        {
            result.Add(right[0]);
            right.RemoveAt(0);
        }

        return result;
    }
}