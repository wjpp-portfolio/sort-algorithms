﻿using System;
namespace Sort.Services;



class Program
{
    public static void Main()
    //Demonstrating ability to sort for each algorithm
    {
        
        List<int> numbers = new List<int> {8,0,-5,1,2,3,4,5,6,7};

        var sorter = new Sorter();

        Console.Write("Unsorted ints: ");
        Display(numbers);

        Console.Write("Bubble sort: ");
        Display(sorter.Bubble(numbers));

        Console.Write("Merge sort: ");
        Display(sorter.Merge(numbers));

        Console.Write("Quick sort: ");
        Display(sorter.Quick(numbers));

        Console.Write("Select sort: ");
        Display(sorter.Select(numbers));
    
    }
    private static void Display(List<int> listOfInts)
    //sequentially prints out each List item
    { 
        foreach (var item in listOfInts)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("");
    }
}


public class Sorter
{
    public List<int> Bubble(List<int> working_list)
    //Bubble sort coded as my own interpretation of requirement
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
                   // Console.WriteLine($"---Index {index} Out Of Range. List length: {working_list.Count}");
                }               
            }

            counter++;
 
        } while (changes != false);

        return working_list;
    }
    public List<int> Merge(List<int> working_list)
    //Merge sort written from psudocode, not my own implementation
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
    public List<int> Quick(List<int> working_list)
    //coded from psudocode
    {
        return Quicksort(working_list, 0, working_list.Count - 1);
    }
    private List<int> Quicksort(List<int> working_list, int lo, int hi)
    {
        if (lo >= 0 & hi >= 0 & lo < hi)
        {
            var p = Quicksort_Partition(working_list, lo, hi);
            Quicksort(working_list, lo, p);
            Quicksort(working_list, p + 1, hi);
        }
        return working_list;
    }
    private int Quicksort_Partition(List<int> working_list, int lo, int hi)
    {
        double x = ((hi - lo) / 2) + lo;
        var y = (int) Math.Floor(x);
        var pivot = working_list[y];
        var i = lo - 1;
        var j = hi + 1;

        while (true)
        {
            do 
            {
                i++;
            } while (working_list[i] < pivot);

            do
            {
                j--;
            } while (working_list[j] > pivot);

            if (i >= j)
            {
                return j;
            }
            (working_list[i], working_list[j]) = (working_list[j], working_list[i]);
        }
    }
    public List<int> Select(List<int> working_list)
    //my own interpretation based on written description
    {
        if (working_list.Count < 1) 
        {
            return working_list;
        }
        List<int> result = new List<int>();
        int smallest;
        int smallest_index;
        do {
            smallest = working_list[0];
            smallest_index = 0;

            for(int index = 0; index < working_list.Count; index++)
            {
                if (working_list[index] < smallest) 
                {
                    smallest = working_list[index];
                    smallest_index = index;
                }
            }
            result.Add(working_list[smallest_index]);
            working_list.RemoveAt(smallest_index);
        } while (working_list.Count > 0);

        return result;
    }
}
