using ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Triagls ba = new Triagls(2,3,4);
        ba.Proverka();
        double s = ba.FindS();
        Console.WriteLine($"Площадь треугольник примерно равна: {Math.Round(s)}");
    }
}