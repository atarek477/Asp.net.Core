
using Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Func<int,int> func = Delegate1.M3;
        Delegate1.M4(func,3);
        Predicate<int> predicate = Delegate1.M5;
        Delegate1.M6(predicate, 6);


        //Linq where 
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var evenNumbers = numbers.Where(x => x % 2 == 0);
        IEnumerable<int> evenNumbers =
            numbers.Where(x => x % 2 == 0); // construction (lazy loading)

        numbers.Add(10);
        numbers.Add(12);
        numbers.Remove(4);

        // [1]  ===>   2, 4, 6, 8
        // [2]  ===>   2, 6, 8, 10, 12
        foreach (var n in evenNumbers) // enumeration (immediate execution)
        {
            Console.Write($" {n}");
        }

        Console.ReadKey();



    }
}