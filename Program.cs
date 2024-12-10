using ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Triagls ba = new Triagls(2,3,4);
        ba.Proverka();
        double s = ba.FindS();
        Console.WriteLine($"Площадь треугольник равна: {s:F2}");
        Triagls ab = new Piramids(2,3,4,5);
        ab.Proverka();
        double spir = ab.FindS();
        Console.WriteLine($"Площадь пирамиды равна: {spir:F2}");
        Triagls ad = new Prizma(2,3,4,5);
        ab.Proverka();
        double sprizm = ad.FindS();
        Console.WriteLine($"Площадь пирамиды равна: {sprizm:F2}");
    }
}