using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using MySql.Data.MySqlClient;
using Emgu.CV.Util;
using Patagames.Ocr;


namespace Praca1.Widoki
{
    public partial class Automatyczna_Detekcja : UserControl
    {   /*
        int x, y, w, h;
        int r = 1;
    //string tablice; MySqlCommand cmd;
    //MySqlConnection connect;


        FilterInfoCollection fic;
        VideoCaptureDevice device;
        MotionDetector motion;

        Image<Bgr, byte> img;
        Bitmap temp;
        Bitmap video;
        float f;



        public Automatyczna_Detekcja()
        {
            InitializeComponent();

        }

        private static Automatyczna_Detekcja _instance;
        public static Automatyczna_Detekcja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Automatyczna_Detekcja();
                }
                return _instance;
            }
        }

        public void _wyswietlanie(Image<Bgr, byte> _gimg)
        {
            try
            {

                Image<Gray, byte> sobel = _gimg.Convert<Gray, byte>().Sobel(1, 0, 5).AbsDiff(new Gray(0.0)).Convert<Gray, byte>().ThresholdBinary(new Gray(75), new Gray(255));

                Mat SE = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(10, 5), new System.Drawing.Point(-1, -1));
                sobel = sobel.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Dilate, SE, new System.Drawing.Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(255));
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();
                CvInvoke.FindContours(sobel, contours, m, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                List<Rectangle> list = new List<Rectangle>();

                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle brect = CvInvoke.BoundingRectangle(contours[i]);

                    double ar = brect.Width / brect.Height;
                    if (ar > 2 && brect.Width > 30 && brect.Height > 20 && brect.Height < 500)
                    {
                        list.Add(brect);

                    }
                }

                Image<Bgr, byte> _gimgout = _gimg.CopyBlank();

                foreach (var r in list)
                {
                    CvInvoke.Rectangle(_gimg, r, new MCvScalar(0, 255, 255), 2); //obramówka
                    x = r.X;
                    w = r.Width;
                    h = r.Height;
                    y = r.Y;
                }

                pictureBox2.Image = _gimg.Bitmap;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                
                    Rectangle asd = new Rectangle(x, y, w, h);
                    Bitmap temp = _gimg.Bitmap;
                    Bitmap plate = (Bitmap)temp.Clone(asd, temp.PixelFormat);
                    pictureBox2.Image = plate;
                    Image<Gray, Byte> plate1 = new Image<Gray, Byte>(plate);
                    using (var objocr = OcrApi.Create())
                    {
                        objocr.Init(Patagames.Ocr.Enums.Languages.English);
                        tablice = objocr.GetTextFromImage(plate1.Bitmap);
                        tablice = tablice.Replace("\n", "");
                        label1.Text = tablice;

                    }
                }
                catch(Exception)
                {
                return;
                     
                }
            return;
               
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Automatyczna_Detekcja_Load(object sender, EventArgs e)
        {
            motion = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice(fic[0].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private async void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                f = motion.ProcessFrame(video);
                pictureBox1.Image = video;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                if (f > 0.05)
                {
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    device.Stop();
                    temp = (Bitmap)video.Clone();
                    img = new Image<Bgr, byte>(temp);
                    _wyswietlanie(img);
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    device.Start();

                }
            }
            catch(Exception)
            {

            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        */
    }
    
}
