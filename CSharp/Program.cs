using System.Diagnostics;
using CSharp.Controller;

var filePath = "/Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest";
Console.WriteLine($"Récupération des images de {filePath}");

ImageController  imageController = new ImageController();
var images = imageController.GetImagesInDirectory(filePath);
Console.WriteLine($"Nombre d'images trouvées : {images.Count}");

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
Console.WriteLine("Version non opti");
foreach (var image in images)
{
    
    Console.WriteLine($"Image : {image.FileName}, Path : {image.FilePath}");
    imageController.ConvertImage(image);
    Console.WriteLine($"Image {image.FileName} convertie.");
}
stopwatch.Stop();
Console.WriteLine($"VERSION NON OPTI : {stopwatch.ElapsedMilliseconds} ms.");

Console.WriteLine("Démarrage version optimisée");
stopwatch = new Stopwatch();
stopwatch.Start();

var tasks = images.Select(image =>
{
    Console.WriteLine($"Image : {image.FileName}, Path : {image.FilePath}");
    return imageController.OptimizedConvertImage(image);
});
await Task.WhenAll(tasks);

stopwatch.Stop();
Console.WriteLine($"VERSION OPTI : {stopwatch.ElapsedMilliseconds} ms.");