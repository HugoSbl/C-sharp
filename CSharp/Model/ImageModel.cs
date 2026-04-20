using System;

namespace CSharp.Model
{
    public class ImageModel
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public ImageModel(string filePath)
        {
            FilePath = filePath;
            FileName = System.IO.Path.GetFileName(filePath).Split('.')[0];
        }
    }
}