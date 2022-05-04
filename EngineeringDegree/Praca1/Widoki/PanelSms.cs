using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;

using System.Net.Mail;
using System.Net;
using System.IO;

namespace Praca1
{
    public partial class PanelSms : UserControl
    {

        MySqlCommand cmd;
        MySqlConnection connect;

        public PanelSms()
        {
            InitializeComponent();
            label1.Visible = true;
            textBox1.Visible = true;
            button12.Visible = true;

            label2.Visible = false;
            textkod.Visible = false;
            button14.Visible = false;

        }

        private static PanelSms _instance;
        public static PanelSms Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PanelSms();
                }
                return _instance;
            }
        }


        public string GeneratorLiczb(string _numer)
        {
            int _min = 1000;
            int _max = 9999;
            int temp = int.Parse(_numer);
            Random _rdm = new Random();
            int kod =_rdm.Next(_min, _max);
            connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tablicerejestracyjne SET Kod='"+kod+"' WHERE Telefon='"+temp+"'";
            cmd.ExecuteNonQuery();
            connect.Close();
            string c = kod.ToString();
            return c;
        }

        public void CzyszczenieKodu(string _numer)
        {
            int temp = int.Parse(_numer);
            connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tablicerejestracyjne SET Kod='"+0+"' WHERE Telefon='" + temp + "'";
            cmd.ExecuteNonQuery();
            connect.Close();

            label1.Visible = true;
            textBox1.Visible = true;
            button12.Visible = true;

            label2.Visible = false;
            textkod.Visible = false;
            button14.Visible = false;
        }


        private void PanelSms_Load(object sender, EventArgs e)
        {

        }


        //Button 1 
        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button1.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button1.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 2 
        private void button2_Click(object sender, EventArgs e)
        {
   


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button2.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!","Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button2.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 3 
        private void button3_Click(object sender, EventArgs e)
        {
            


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button3.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button3.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 4 
        private void button4_Click(object sender, EventArgs e)
        {
            


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button4.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button4.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 5 
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button5.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button5.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 6 
        private void button6_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button6.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button6.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }

        }

        //Button 7 
        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button7.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button7.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 8
        private void button8_Click(object sender, EventArgs e)
        {
            


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button8.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button8.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }
        //Button 9
        private void button9_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button9.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button9.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }


        //Button 0 
        private void button10_Click(object sender, EventArgs e)
        {
            


            if (textBox1.Visible == true)
            {
                if (textBox1.TextLength < 9)
                    textBox1.Text += "" + button10.Text + "";
                else
                {
                    MessageBox.Show("Numer Telefonu jest zbyt długi!", "Informacja systemowa");
                }
            }
            else if (textkod.Visible == true)
            {
                if (textkod.TextLength < 4)
                    textkod.Text += "" + button10.Text + "";
                else
                {
                    MessageBox.Show("Kod dostępu jest zbyt długi!", "Informacja systemowa");
                }
            }
        }

        //Button Undo do usuwania poprzedniego znaku
        private void button11_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string sk = textkod.Text;
            if(textBox1.Visible == true) {
                if( s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "";
                }
                textBox1.Text = s;
            }
            else if(textkod.Visible == true)
            {
                if (sk.Length > 1)
                {
                    sk = sk.Substring(0, sk.Length - 1);
                }
                else
                {
                    sk = "";
                }
                textkod.Text = sk;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {


        }

        //Button Clear do czyszczenia pola tekstowego
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
                textBox1.Text = "";
            else if (textkod.Visible == true)
                textkod.Text = "";
        }

        private string _code;
        private string s;
    
        //Button Accept dla numeru telefonu
        public async void button12_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            if (s.Length!=9)
            {
                MessageBox.Show("Numer Telefonu jest zbyt krótki!","Informacja systemowa");
            }
            else
            {
                try
                {
                    connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                    connect.Open();
                    MySqlCommand cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Telefon FROM tablicerejestracyjne WHERE Telefon='"+s+"'";
                    cmd.ExecuteNonQuery();
                    string temp = cmd.ExecuteScalar() as string;
                    connect.Close();
                    try
                    {
                        s.Equals(temp);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Podany numer jest błędny lub nie występuje w bazie danych!", "Informacja systemowa");
                    }

                    
                    WebClient client = new WebClient();
                    _code = GeneratorLiczb(s);
                    Stream x = client.OpenRead("https://platform.clickatell.com/messages/http/send?apiKey=9NkIQahOTWaf_DU-6WhU9w==&to=48"+s+"&content=Kod dostępu: "+_code+"");
                    StreamReader reader = new StreamReader(x);
                    string wynik = reader.ReadToEnd();
                    
                   


                    label1.Visible = false;
                    textBox1.Visible = false;
                    button12.Visible = false;
                    label2.Visible = true;
                    textkod.Visible = true;
                    button14.Visible = true;
                    await Task.Delay(TimeSpan.FromSeconds(30));
                    CzyszczenieKodu(s);
                }
                catch (Exception) { MessageBox.Show("Wystąpił błąd podczas łączenia z bazą danych!", "Informacja systemowa"); }
                



            }
        }


        //Button Accept dla kodu dostępu
        private void button14_Click(object sender, EventArgs e)
        {

            connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Kod FROM tablicerejestracyjne WHERE Telefon = '"+s+"'";
            cmd.ExecuteNonQuery();
            string temp1 = cmd.ExecuteScalar() as string;
            connect.Close();
            if(textkod.Text.Equals(temp1))
            {
                MessageBox.Show("Podany kod jest prawidłowy! Brama zaraz się otworzy", "Informacja systemowa");
                CzyszczenieKodu(s);
                


            }
            else
            {
                MessageBox.Show("Podany kod jest błędny lub wygasł", "Informacja systemowa");
            }

        }
    }
}
