namespace wk2ex2;
class Program
{
    // create public variables to store length and width
    public static double length, width;
    static void Main(string[] args)
    {
        // ask the user to type the length of the rectangle
        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());
        // ask the user to type the width of the rectangle
        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());
        // space before results so it looks nicer
        Console.WriteLine("\nResults:");
        // show the area in the console
        DisplayArea();
        // show the perimeter in the console
        DisplayPerimeter();
        // stop the console from closing right away
        Console.Read();
    }
    // this method calculates and prints the area
    public static void DisplayArea()
    {
        double area = length * width;
        Console.WriteLine("Area of the rectangle: " + area);
    }
    // this method calculates and prints the perimeter
    public static void DisplayPerimeter()
    {
        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}
