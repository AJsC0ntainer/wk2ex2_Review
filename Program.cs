namespace wk2ex2;
class Program
{
    public static double length, width;

    static void Main(string[] args)
    {
        

        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nResults:");

        DisplayArea();
        DisplayPerimeter();

        Console.Read();


    }
    public static void DisplayArea()
    {
        double area = length * width;
        Console.WriteLine("Area of the rectangle: " + area);
    }
    public static void DisplayPerimeter()
    {
        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}

