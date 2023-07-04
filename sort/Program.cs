using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main()
    {
        int[] numbers = new int[] {7,6,5,4,3,2,1};

        var a = new Sorter(numbers);
        a.ShowUnSorted();
        a.Bubble();
    
    }
}

class Sorter
{
    public int[] Sorted {get; }
    public int[] UnSorted {get; set; }

    public Sorter(int[] unsorted)
    {
        this.UnSorted = unsorted;
    }
    public void ShowSorted()
    {
        Display(Sorted);
    }
    public void ShowUnSorted()
    {
        Display(UnSorted);
    }
    private void Display(int[] listOfInts)
    { 
        foreach (var item in listOfInts)
        {
            Console.Write(item);
        }
        Console.WriteLine("");
    }
    public int[] Bubble()
    {
        int[] i = this.UnSorted;
        int counter = 0;
        bool changes;

        do
        {
            changes = false;
            for (int index = 0; index < i.Length - counter; index++)
            {             
                try
                {
                    if (i[index] > i[index + 1])
                    {
                        (i[index], i[index + 1]) = (i[index + 1], i[index]);
                        changes = true;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    //Console.WriteLine("---Index Out Of Range");
                }               
            }

            counter++;
 
        } while (changes != false);

        Display(i);  
        return i;     
    }
}