using AlbumsManager.Models;
using SkiaSharp;

namespace AlbumsManager.ImageProcessors
{
    public class TextWatermarkImageProcessor : IImageProcessor
    {
        private const string WatermarkText = "ДЛЯ ДОКУМЕНТОВ";
        public void Process(AlbumItem image)
        {
            if (image.OriginalBytes is null) 
            {
                return;
            }
            image.ProcessedBytes = image.OriginalBytes;
            //var skbm = SKBitmap.Decode(image.OriginalBytes);
            //var sksurface = SKSurface.Create(new SKImageInfo(skbm.Width, skbm.Height));
            //var canvas = sksurface.Canvas;

            //var skPaintWatermark = new SKPaint();

            //skPaintWatermark.Color = new SKColor(255, 255, 255, 75);
            //skPaintWatermark.TextSize = 40f;
            //skPaintWatermark.Typeface = SKTypeface.FromFamilyName("Arial");
            //skPaintWatermark.IsAntialias = true;
            //skPaintWatermark.TextAlign = SKTextAlign.Center;

            //var skrect = new SKRect();
            //var textWidth = skPaintWatermark.MeasureText(WatermarkText, ref skrect);
            //skPaintWatermark.TextSize = 0.9f * skbm.Width * skPaintWatermark.TextSize / textWidth;

            //canvas.DrawBitmap(skbm, 0, 0);
            //canvas.DrawText(WatermarkText, (int)skbm.Width / 2, (int)skbm.Height / 2 + skrect.MidY, skPaintWatermark);

            //var skBitmapProcessing = SKBitmap.FromImage(sksurface.Snapshot());
            //var skData = skBitmapProcessing.Encode(SKEncodedImageFormat.Png, 100);

            //image.ProcessedBytes = skData.ToArray();

            //skData.Dispose();
            //skBitmapProcessing.Dispose();
            //skPaintWatermark.Dispose();
            //skbm.Dispose();
            //sksurface.Dispose();
            //canvas.Dispose();

        }
    }
}
