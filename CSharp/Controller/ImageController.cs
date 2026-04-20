using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp;
using CSharp.Model;

namespace CSharp.Controller
{
    public class ImageController
    {
        private List<Size> _listOfSize = new List<Size>
        {
            new Size(1080, 1080),
            new Size(720, 720),
            new Size(480, 480)
        };

        public List<ImageModel> GetImagesInDirectory(string directoryPath)
        {
            var images = new List<ImageModel>();
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                if (Path.GetExtension(file) == ".jpg" || Path.GetExtension(file) == ".png")
                    images.Add(new ImageModel(file));
            }

            return images;
        }

        public void ConvertImage(ImageModel image)
        {
            foreach (var size in _listOfSize)
            {

                    var imageLoaded = Image.Load(image.FilePath);
                    imageLoaded.Mutate(x => x.Resize(size.Width, size.Height));
                    imageLoaded.SaveAsWebp("/Users/hugo/RiderProjects/CSharp/CSharp/converted/" + image.FileName + '_' +
                                           size.Width + ".webp");
            }
        }

        public async Task OptimizedConvertImage(ImageModel image)
        {
            foreach (var size in _listOfSize)
            {
                using var imageLoaded = await Image.LoadAsync(image.FilePath);
                imageLoaded.Mutate(x => x.Resize(size.Width, size.Height));
                await imageLoaded.SaveAsWebpAsync($"/Users/hugo/RiderProjects/CSharp/CSharp/converted/{image.FileName}_{size.Width}_opti.webp");
            }
        }
        
    }
}