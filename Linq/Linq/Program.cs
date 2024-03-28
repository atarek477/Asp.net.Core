
using Linq;
using Linq.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Delegate
        Func<int,int> func = Delegate1.M3;
        Delegate1.M4(func,3);
        Predicate<int> predicate = Delegate1.M5;
        Delegate1.M6(predicate, 6);


        //query data
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var test = numbers.Where(x => x > 5);
        foreach (var x in test) { Console.WriteLine(x); }

        
         List<string> fields = new() { "here", "we", "are" };

         //projection method syntex
         var method = fields.Select(x => x.ToUpper());
         Console.WriteLine("method syntex");
         foreach(var x in method) {  Console.WriteLine(x); }

        //projection query syntex
        var query = from x in fields
                    select x.ToUpper();
        Console.WriteLine("query syntex");
        foreach(var x in query) {  Console.WriteLine(x); };


        // projection in employee data
        var listEmployee = Repository.LoadEmployees();
        var result = listEmployee.Select(x => {
            return new EmployeeDto
            {
                Name = x.FirstName + " " + x.LastName,
                Salary = x.Salary
            };
        }) ;

        foreach(var x in result) { Console.WriteLine(x); }


    }
}