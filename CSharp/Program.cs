using System.Diagnostics;
Console.WriteLine("Calcul de performance.");

Parallel.For(0, 100, b =>
{
    Console.WriteLine($"tache {b}");
    var sw = Stopwatch.StartNew();
// on éxécute 50 millions de calculs
    double sum = 1;
    for (int i = 0; i < 500_000_00; i++)
    {
//cosinus
        sum += Math.Sin(i) + Math.Cos(i);
//Racine carrée
        sum += Math.Sqrt(i);
// Exp + Log
        sum += Math.Exp(i % 10) + Math.Log(i+1);
//Puissances
        sum += Math.Pow(i % 100, 3);
//Multiplication rule
        sum *= 1.0000001;
    }

    sw.Stop();
    Console.WriteLine($"Temps de calcul {b}: {sw.ElapsedMilliseconds} ms");
});

