using System;
/*

init randomised list of ints
display ints current state
display ints start state
sort ints

*/

public class Integers
{
    public int[] members = new int[] {1, 3, 5, 2, 4, 9, 8, 6, 7};

    public void Show()
    {
        Console.WriteLine(String.Join(" ", members));
    }
}
class Program
{
    static void Main()
    {
        Integers a = new Integers();
 
        a.Show();


    }
}
