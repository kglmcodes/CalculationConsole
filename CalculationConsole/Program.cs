// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(Math.Abs(365 + 4645) % 360);
using System.Linq;

double first, second, thrid, fourth;
List<double> valuesFrom4Quad = new List<double>();
List<double> deltaValues = new List<double>
{
    +180.0,
    -180.0,
    360
};
first = 25;
second = first + 90;
thrid = second + 90;
fourth = thrid + 90;

valuesFrom4Quad.Add(first);
valuesFrom4Quad.Add(second);
valuesFrom4Quad.Add(thrid);
valuesFrom4Quad.Add(fourth);


double value = 0.0;
//while (true)
//{
//Console.Write(value % (2 * Math.PI));
//Console.Write("\t");
//Console.WriteLine(value % (2 * Math.PI) * (180 / Math.PI));
//value += 0.1;
foreach (var initial in valuesFrom4Quad)
{
    if (initial == first)
    {
        Console.Write("First Quad \t \t ");
        Console.Write($"Initial: {initial} \t");
        Console.WriteLine($"From :{Math.Abs(initial - 180) % 360} \t\t To:{(initial + 180) % 360}");
    }
    else if (initial == second)
    {
        Console.Write("Second Quad \t \t ");
        Console.Write($"Initial: {initial} \t");
        Console.WriteLine($"From :{Math.Abs(initial - 180) % 360} \t\t To:{(initial + 180) % 360}");
    }
    else if (initial == thrid)
    {
        Console.Write("Thrid Quad \t \t ");
        Console.Write($"Initial: {initial} \t");
        Console.WriteLine($"From :{Math.Abs(initial - 180) % 360} \t\t To:{(initial + 180) % 360}");
    }
    else if (initial == fourth)
    {
        Console.Write("Fourth Quad \t \t ");
        Console.Write($"Initial: {initial} \t");
        Console.WriteLine($"From :{Math.Abs(initial - 180) % 360} \t\t To:{(initial + 180) % 360}");
    }
    Console.WriteLine("\n");
    foreach (var delta in deltaValues)
    {
        double deg = 0;
        double targetDegree = (initial + delta) % 360;
        Console.WriteLine($"{initial} Going for ({delta})");
        //while (initial + deg != (initial + delta) % 360)
        while (!Enumerable.Range((int)(targetDegree - 5), (int)(targetDegree + 5)).Contains((int)(initial + deg) % 360))
        {
            Console.WriteLine($"{initial} + \t {deg} \t= {initial + deg} \t Target : {(targetDegree) % 360}");
            if (delta == -180)
                deg--;
            else
                deg++;
            await Task.Delay(20);
        }
    }
    await Task.Delay(100);
}
//}