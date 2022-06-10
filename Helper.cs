using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ZXing;
using ZXing.QrCode;
using ZXing.Rendering;
using ZXing.Common;
using System.Runtime.InteropServices;

namespace Pro_code_editor
{
    class Helper
    {
        #region setSaveDialog_Options
        public static void setSaveDialogOptions(ref SaveFileDialog saveFile)
        {
            setSaveDialogParameters(ref saveFile);
            setSaveDialogStartFileName(ref saveFile);
        }
        private static void setSaveDialogParameters(ref SaveFileDialog saveFile)
        {
            saveFile.Title = "Сохранить картинку как...";
            saveFile.DefaultExt = ".png";
            saveFile.OverwritePrompt = true;//отображать ли предупреждение, если пользователь указывает имя уже существующего файла            
            saveFile.CheckPathExists = true;//отображать ли предупреждение, если пользователь указывает несуществующий путь
            saveFile.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            saveFile.ShowHelp = true;//отображается ли кнопка "Справка" в диалоговом окне
        }
        private static void setSaveDialogStartFileName(ref SaveFileDialog saveFile)
        {
            if (FileMenager.language == "en") saveFile.FileName = "Cipher image";
            else if (FileMenager.language == "ru") saveFile.FileName = "Шифр изображение";
            else saveFile.FileName = "Cipher image";
        }
        #endregion

        public static void saveImage(Image image, string path)
        {
            try
            {
                if (path != null)
                    image.Save(path, ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region QR_Options
        public static Image CreateQRCode(string text, int width, int height, BarcodeFormat selectionBarcodeFormatBCF)
        {
            try
            {
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = selectionBarcodeFormatBCF,
                    Options = new QrCodeEncodingOptions
                    {
                        Width = width,
                        Height = height,
                        CharacterSet = "UTF-8"
                    },
                    Renderer = new BitmapRenderer()
                };

                return writer.Write(text);
            }
            catch (Exception e)
            {

            }

            return null;
        }
        public static string[] BarcodeScan(Bitmap bmp, bool scanQRCodeOnly = false)
        {
            try
            {
                BarcodeReader barcodeReader = new BarcodeReader
                {
                    AutoRotate = true,
                    TryInverted = true,
                    Options = new DecodingOptions
                    {
                        TryHarder = true
                    }
                };

                if (scanQRCodeOnly)
                    barcodeReader.Options.PossibleFormats = new List<BarcodeFormat>() { BarcodeFormat.QR_CODE };

                Result[] results = barcodeReader.DecodeMultiple(bmp);

                if (results != null)
                    return results.Where(x => x != null && !string.IsNullOrEmpty(x.Text)).Select(x => x.Text).ToArray();
            }
            catch (Exception ex)
            {

            }

            return null;
        }
        public static string DecodeImage(Image img)
        {
            string outString = "";

            string[] results = BarcodeScan((Bitmap)img);

            if (results != null)
                outString = string.Join(Environment.NewLine + Environment.NewLine, results);

            return outString;
        }
        #endregion

        public static string getNewImageNameToGallery()
        {
            int index = Directory.GetFiles($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\GalleryCollection").Length;
            for (; ; )
            {
                if (!new FileInfo($@"{FileMenager.TotalRoot}\ProgramData\Pro_code_editor\GalleryCollection\").Exists)
                    return index.ToString();
                else
                    index++;
            }
            throw new Exception("");
        }
    }

    class ImageHelper
    {
        public static Bitmap getScreenImage()
        {
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            return printscreen;
        }
        public static Bitmap getCroppedImage(Image image, int x, int y, int width, int height)
        {
            Bitmap source = new Bitmap(image);
            return source.Clone(new Rectangle(x, y, width, height), source.PixelFormat);
        }
    }

    public class ScreenColorMenager
    {
        public static byte R(int x, int y)
        {
            IntPtr hDC = ScreenColorMenager.GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, x, y);
            ReleaseDC(IntPtr.Zero, hDC);
            return (byte)(pixel & 0x000000FF);
        }
        public static byte G(int x, int y)
        {
            IntPtr hDC = ScreenColorMenager.GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, x, y);
            ReleaseDC(IntPtr.Zero, hDC);
            return (byte)((pixel & 0x000000FF) >> 8);
        }
        public static byte B(int x, int y)
        {
            IntPtr hDC = ScreenColorMenager.GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, x, y);
            ReleaseDC(IntPtr.Zero, hDC);
            return (byte)((pixel & 0x000000FF) >> 16);
        }

        public static Color getColor(Point p)
        {
            IntPtr hDC = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hDC, p);
            ReleaseDC(IntPtr.Zero, hDC);
            Color color = Color.FromArgb((byte)(pixel & 0x000000FF), (byte)((pixel & 0x0000FF00) >> 8), (byte)((pixel & 0x00FF0000) >> 16));
            return color;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, Point loc);

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        public static extern int GetSystemMetrics(int abc);

        [DllImport("user32.dll", EntryPoint = "GetWindowDC")]
        public static extern IntPtr GetWindowDC(Int32 ptr);

    }
}
