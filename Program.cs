namespace Part_11___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Input value 'a' of the right angle triangle: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Input value 'b' of the right angle triangle: ");
            double.TryParse(Console.ReadLine(), out b);
            
            Console.WriteLine(MyMethods.GetHypotenuse(a, b));
        }
    }
}