internal class Program
{
    private static void Main(string[] args)
    {
        /* int x;
         int y;
         int v;

         y = 20;
         x = 5;

         v = y * x;
         Console.WriteLine(v);
         Console.ReadLine(); */

        Console.WriteLine("What is your name?");
        Console.Write("Type first your name: ");
        string myFirstName;
        myFirstName = Console.ReadLine();

        string myLastName;
        Console.Write("Type your last name: ");
        myLastName = Console.ReadLine();

        Console.WriteLine("How old are you?");
        Console.Write("Type your age: ");
        string age;
        age = Console.ReadLine();

        Console.WriteLine("Hello " + myFirstName + " " + myLastName + " I am " + age + " years old" );
        Console.ReadLine();
    }
}