namespace PatternFacade.Pattern
{
    public class ImageConverter
    {
        public string GetMimeType(string imagePath)
        {
            var extension = Path.GetExtension(imagePath);
            switch (extension)
            {
                case ".jpg":
                    return new ImageJpeg().MimeType;
                case ".svg":
                    return new ImageSvg().MimeType;
                case ".tiff":
                    return new ImageTiff().MimeType;
                case ".png":
                    return new ImagePng().MimeType;
                case ".ico":
                    return new ImageIco().MimeType;
                case ".gif":
                    return new ImageGif().MimeType;
                default:
                    return "unknown";
            }
        }
    }
}
