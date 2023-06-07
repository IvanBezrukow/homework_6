string Coord(double k, double b, double m, double l)
{
    string result = String.Empty;
    double x = 0;
    double y = 0;
    x = (l - b) / (k - m);
    y = k * x + b;
    return result + $"x = {x}, y = {y}";
}




try
{
    Console.WriteLine("Insert the necessary coefficients of the equation y = kx + b");
    Console.Write("k = ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Insert the necessary coefficients of the equation y = mx + l");
    Console.Write("m = ");
    double num3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("l = ");
    double num4 = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
    if (num1 != num3)
    {
        Console.WriteLine(Coord(num1, num2, num3, num4));
    }
    else Console.WriteLine("These are parallel lines");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}