using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Patagames.Ocr;


namespace Praca1
{
    public partial class DodajZdjecie : UserControl
    {

        string tablice;
        int r = 1;
        int x, y, w, h;
        //MySqlCommand cmd;
        //MySqlConnection connect;


        public DodajZdjecie()
        {
            
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

        }


        private static DodajZdjecie _instance;
        public static DodajZdjecie Instance
        {
            get
            {
                if(_instance ==null)
                {
                    _instance = new DodajZdjecie();
                }
                return _instance;         
            }
        }


        private void DetectText(Image<Bgr, byte> _gimg)
        {


        }

        public int _wyswietlanie(Image<Bgr,byte> _gimg)
        {
            //try
           // {
                r = 1;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";



                Image<Gray, byte> sobel = _gimg.Convert<Gray, byte>().Sobel(1, 0, 5).AbsDiff(new Gray(0.0)).Convert<Gray, byte>().ThresholdBinary(new Gray(75), new Gray(255));
            
                Mat SE = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(10, 5), new Point(-1, -1));
                sobel = sobel.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Dilate, SE, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(255));
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

                pictureBox1.Image = _gimg.Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


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
                label2.Text = tablice;

            }
            /*

            if(tablice!="")
            {
               
                connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {   

                    cmd.CommandText = "SELECT Imie,Nazwisko,Telefon,Mail from tablicerejestracyjne WHERE Tablica1='" + tablice + "'or  Tablica2='" + tablice + "'" +
                                      "or  Tablica3='" + tablice + "'or  Tablica4='" + tablice + "'or  Tablica5='" + tablice + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                MessageBox.Show("Wystąpił błąd podczas ");

                }


        MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    reader.Read();
                    label3.Text = reader["Imie"].ToString();
                    label4.Text = reader["Nazwisko"].ToString();
                    label5.Text = reader["Telefon"].ToString();
                    label6.Text = reader["Mail"].ToString();
                    r = 2;
                }
            }
            reader.Close();
            connect.Close();



            }
            //}
           // catch (Exception)
            //{
           //     MessageBox.Show("Wystąpił błąd podczas wyszukiwania tablic rejestracyjnych!");
            //}
            */
            return r;
            
        }
        
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Box1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DodajZdjecie_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DodajZdjecie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



