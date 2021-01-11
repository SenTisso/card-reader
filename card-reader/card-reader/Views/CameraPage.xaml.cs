using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace card_reader.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ZXingScannerPage
    {
        public CameraPage()
        {
            InitializeComponent();
        }

        public void Handle_OnScanResult(Result result)
        {
            Debug.WriteLine("FINISH");
            Debug.WriteLine(result.Text);
            // await Navigation.PushAsync(new CardDetailPage() { });
            
            // MessagingCenter.Send<CameraPage>(this, "Hi");
            
            // var bitmapMatrix = new MultiFormatWriter().encode(result.Text, result.BarcodeFormat, 800, 400);
            //
            // var width = bitmapMatrix.Width;
            // var height = bitmapMatrix.Height;
            // int[] pixelsImage = new int[width * height];
            // Bitmap bitmap = new Bitmap(800, 400, PixelFormat.Format32bppArgb);
            //
            // for (int i = 0; i < height; i++)
            // {
            //     for (int j = 0; j < width; j++)
            //     {
            //         if (bitmapMatrix[j, i])
            //             bitmap.SetPixel(i, j, Color.Black);
            //         else
            //             bitmap.SetPixel(i, j, Color.White);
            //
            //     }
            // }
            //
            // bitmap.Save(@"C:\code\test.png", ImageFormat.Png);

            // ZXingBarcodeImageView barcode = new ZXingBarcodeImageView() {
            //     BarcodeOptions =
            //     {
            //         Width = 800,
            //         Height = 400
            //     },
            //     BarcodeFormat = result.BarcodeFormat,
            //     BarcodeValue = result.Text
            // };

            // Bitmap bitmap = Bitmap.CreateBitmap(width, height, Bitmap.Config.Argb8888);
            // bitmap.SetPixels(pixelsImage, 0, width, 0, 0, width, height);
            //
            // var stream = new FileStream(path, FileMode.Create);
            // bitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, stream);
            // stream.Close();

            // Bitmap bitmap = writer.Write("");
            // Bitmap bitmap = writer.Write("");
            // bitmap.Save(HttpContext.Response.Body,System.Drawing.Imaging.ImageFormat.Png);
            // return; // there's no need to return a `FileContentResult` by `File(...);`
        }
    }
}
