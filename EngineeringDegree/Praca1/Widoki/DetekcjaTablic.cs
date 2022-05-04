using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.Util;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.CvEnum;
using System.Data.Sql;
using MySql.Data.MySqlClient;



namespace Praca1
{

    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            InitializeComponent();



        }

        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!panel1.Controls.Contains(DodajZdjecie.Instance))
            {
                panel1.Controls.Add(DodajZdjecie.Instance);
                DodajZdjecie.Instance.Dock = DockStyle.Fill;
                DodajZdjecie.Instance.BringToFront();
            }
            else DodajZdjecie.Instance.BringToFront();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Image<Bgr, byte> img = new Image<Bgr, byte>(dialog.FileName);
                if( DodajZdjecie.Instance._wyswietlanie(img)==1)
                {
                    await Task.Delay(5000);

                    panel1.Visible = true;
                    if (!panel1.Controls.Contains(PanelSms.Instance))
                    {
                        panel1.Controls.Add(PanelSms.Instance);
                        PanelSms.Instance.Dock = DockStyle.Fill;
                        PanelSms.Instance.BringToFront();
                    }
                    else PanelSms.Instance.BringToFront();
                }



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!panel1.Controls.Contains(PanelUzytkownika.Instance))
            {
                panel1.Controls.Add(PanelUzytkownika.Instance);
                PanelUzytkownika.Instance.Dock = DockStyle.Fill;
                PanelUzytkownika.Instance.BringToFront();
            }
            else PanelUzytkownika.Instance.BringToFront();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!panel1.Controls.Contains(PanelSms.Instance))
            {
                panel1.Controls.Add(PanelSms.Instance);
                PanelSms.Instance.Dock = DockStyle.Fill;
                PanelSms.Instance.BringToFront();
            }
            else PanelSms.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            panel1.Visible = true;
            if (!panel1.Controls.Contains(Widoki.Automatyczna_Detekcja.Instance))
            {
                panel1.Controls.Add(Widoki.Automatyczna_Detekcja.Instance);
                Widoki.Automatyczna_Detekcja.Instance.Dock = DockStyle.Fill;
                Widoki.Automatyczna_Detekcja.Instance.BringToFront();
            }
            else Widoki.Automatyczna_Detekcja.Instance.BringToFront();
            */
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy na pewno chcesz opuścić aplikację?","Informaja Systemowa",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }





















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

