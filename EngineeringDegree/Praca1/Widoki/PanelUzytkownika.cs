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

namespace Praca1
{
    public partial class PanelUzytkownika : UserControl
    {
       


        public PanelUzytkownika()
        {
            InitializeComponent();
            Dodawanie.Visible = false;
            

        }
        

        private static PanelUzytkownika _instance;
        public static PanelUzytkownika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PanelUzytkownika();
                }
                return _instance;
            }
        }

        MySqlCommand cmd;
        MySqlConnection connect;
        MySqlDataAdapter ada;

        public void wyswietl_dane()
        {
            connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from tablicerejestracyjne";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter ada= new MySqlDataAdapter(cmd);
            ada.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

        }
        public void czyszczenie()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dodawanie.Visible = true;
            dataGridView1.Visible = false;
            button5.Location = new Point (230, 204);
            button5.Visible = true;
            button6.Visible = false;
            button9.Visible = false;
            button7.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;

            comboBox1.Visible = true;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dodawanie.Visible = false;
            dataGridView1.Visible = true;
            label5.Visible = false;
            textBox5.Visible = false;
            wyswietl_dane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button7.Location = new Point(230, 204);

            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button9.Visible = false;

            Dodawanie.Visible = true;
            dataGridView1.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;

            comboBox1.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
        }

        private void PanelUzytkownika_Load(object sender, EventArgs e)
        {
            wyswietl_dane();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Location = new Point(230, 204);
            Dodawanie.Visible = true;
            dataGridView1.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = true;
            button9.Visible = false;

            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            comboBox1.Visible = false;

            label5.Visible = true;
            textBox5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           try
           {
                connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                connect.Open();
                if (textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "") cmd = new MySqlCommand("" +
                    "INSERT INTO tablicerejestracyjne (Imie,Nazwisko,Telefon,Mail,Tablica1) VALUES (@Imie,@Nazwisko,@Telefon,@Mail,@Tablica1)", connect);
                
                else if (textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox4.Text != textBox7.Text) cmd = new MySqlCommand("" +
                    "INSERT INTO tablicerejestracyjne (Imie,Nazwisko,Telefon,Mail,Tablica1,Tablica2) VALUES (@Imie,@Nazwisko,@Telefon,@Mail,@Tablica1,@Tablica2)", connect);
                
                else if (textBox9.Text == "" && textBox10.Text == "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text) cmd = new MySqlCommand("" +
                    "INSERT INTO tablicerejestracyjne (Imie,Nazwisko,Telefon,Mail,Tablica1,Tablica2,Tablica3) VALUES (@Imie,@Nazwisko,@Telefon,@Mail,@Tablica1,@Tablica2,@Tablica3)", connect);
                
                else if (textBox10.Text == "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text && textBox4.Text != textBox9.Text) cmd = new MySqlCommand("" +
                    "INSERT INTO tablicerejestracyjne (Imie,Nazwisko,Telefon,Mail,Tablica1,Tablica2,Tablica3,Tablica4) VALUES (@Imie,@Nazwisko,@Telefon,@Mail,@Tablica1,@Tablica2,@Tablica3,@Tablica4)", connect);
                
                else if (textBox4.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text && textBox4.Text != textBox9.Text && textBox4.Text != textBox10.Text) cmd = new MySqlCommand("" +
                    "INSERT INTO tablicerejestracyjne (Imie,Nazwisko,Telefon,Mail,Tablica1,Tablica2,Tablica3,Tablica4,Tablica5) VALUES (@Imie,@Nazwisko,@Telefon,@Mail,@Tablica1,@Tablica2,@Tablica3,@Tablica4,@Tablica5)", connect);
                
                cmd.Parameters.AddWithValue("@Imie", textBox1.Text);
                cmd.Parameters.AddWithValue("@Nazwisko", textBox2.Text);
                cmd.Parameters.AddWithValue("@Telefon", textBox6.Text);        
                cmd.Parameters.AddWithValue("@Mail", textBox3.Text);
                cmd.Parameters.AddWithValue("@Tablica1", textBox4.Text);
                cmd.Parameters.AddWithValue("@Tablica2", textBox7.Text);
                cmd.Parameters.AddWithValue("@Tablica3", textBox8.Text);
                cmd.Parameters.AddWithValue("@Tablica4", textBox9.Text);
                cmd.Parameters.AddWithValue("@Tablica5", textBox10.Text);
                cmd.ExecuteNonQuery();           
                connect.Close();
                czyszczenie();
                MessageBox.Show("Dane dodano pomyślnie!!");
           }
           catch(Exception)
           {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych!");
           }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            
           try
           { 
                connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tablicerejestracyjne where Id='"+textBox5.Text+ "'or Mail='" + textBox3.Text + "'or Telefon='" + textBox6.Text + "' " +
                                  "or Tablica1='" + textBox4.Text + "' or Tablica2='" + textBox4.Text + "'or Tablica3='" + textBox4.Text + "'or Tablica4='" + textBox4.Text + "'" +
                                  "or Tablica5='" + textBox4.Text + "'or Imie='" + textBox1.Text + "' and Nazwisko='" + textBox2.Text + "' and Mail='" + textBox3.Text + "' " +
                                  "and Telefon='" + textBox6.Text + "' and Tablica1='" + textBox4.Text + "'";

                cmd.ExecuteNonQuery();
                czyszczenie();
                MessageBox.Show("Dane usunięto pomyślnie!!");
           }
           catch (Exception)
           {
               MessageBox.Show("Wystąpił błąd podczas usuwania rekordu '" + textBox5.Text + "'");
           }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tablicerejestracyjne where Imie='" + textBox1.Text + "' or Nazwisko='" + textBox2.Text + "' or " +
                                   "Mail='" + textBox3.Text + "' or Telefon='" + textBox6.Text + "' or Tablica1='" + textBox4.Text + "' or Tablica2='" + textBox4.Text + "' or " +
                                   "Tablica3='" + textBox4.Text + "'or Tablica4='" + textBox4.Text + "'or Tablica5='" + textBox4.Text + "'  or Imie='" + textBox1.Text + "'" +
                                   " and Nazwisko='" + textBox2.Text + "'or Imie='" + textBox1.Text + "' and Nazwisko='" + textBox2.Text + "' and Mail='" + textBox3.Text + "'" +
                                   "and Telefon='" + textBox6.Text + "' and Tablica1='" + textBox4.Text + "'";
                cmd.ExecuteNonQuery();
                czyszczenie();
                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;


                Dodawanie.Visible = false;
                dataGridView1.Visible = true;
                connect.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas wyświetlania!");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button9.Location = new Point(230, 204);
            Dodawanie.Visible = true;
            dataGridView1.Visible = false;            
            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            label5.Visible = true;
            textBox5.Visible = true;

            comboBox1.Visible = true;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           try
           {
                connect = new MySqlConnection("server=localhost;user id=root;database=tablicerejestracyjne");
                connect.Open();
                MySqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "") cmd.CommandText = "UPDATE tablicerejestracyjne " +
                        "SET Imie='" + textBox1.Text + "', Nazwisko='" + textBox2.Text + "', Mail='" + textBox3.Text + "', Tablica1='" + textBox4.Text + "' WHERE Id='" + textBox5.Text + "'";
                else if (textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox4.Text != textBox7.Text) cmd.CommandText = "" +
                        "UPDATE tablicerejestracyjne SET Imie='" + textBox1.Text + "', Nazwisko='" + textBox2.Text + "', Mail='" + textBox3.Text + "', " +
                        "Tablica1='" + textBox4.Text + "', Tablica2='" + textBox7.Text + "'WHERE Id='" + textBox5.Text + "'";
                else if (textBox9.Text == "" && textBox10.Text == "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text) cmd.CommandText = "" +
                        "UPDATE tablicerejestracyjne SET Imie='" + textBox1.Text + "', Nazwisko='" + textBox2.Text + "', Mail='" + textBox3.Text + "', " +
                        "Tablica1='" + textBox4.Text + "', Tablica2='" + textBox7.Text + "', Tablica3='" + textBox8.Text + "'WHERE Id='" + textBox5.Text + "'";
                else if (textBox10.Text == "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text && textBox4.Text != textBox9.Text) cmd.CommandText = "" +
                        "UPDATE tablicerejestracyjne SET Imie='" + textBox1.Text + "', Nazwisko='" + textBox2.Text + "', Mail='" + textBox3.Text + "', " +
                        "Tablica1='" + textBox4.Text + ",' Tablica2='" + textBox7.Text + "', Tablica3='" + textBox8.Text + "', Tablica4='" + textBox9.Text + "'" +
                        "WHERE Id='" + textBox5.Text + "'";
                else if (textBox4.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox4.Text != textBox7.Text && textBox4.Text != textBox8.Text && textBox4.Text != textBox9.Text && textBox4.Text != textBox10.Text) cmd.CommandText = "" +
                        "UPDATE tablicerejestracyjne SET Imie='" + textBox1.Text + "', Nazwisko='" + textBox2.Text + "', Mail='" + textBox3.Text + "', " +
                        "Tablica1='" + textBox4.Text + "', Tablica2='" + textBox7.Text + "', Tablica3='" + textBox8.Text + "', Tablica4='" + textBox9.Text + "', " +
                        "Tablica5='" + textBox10.Text + "'WHERE Id='" + textBox5.Text + "'";
                cmd.ExecuteNonQuery();
                czyszczenie();
                MessageBox.Show("Dane edytowano pomyślnie!");
           }
           catch(Exception)
           {
           MessageBox.Show("Wystąpił błąd podczas edycji rekordu!");
           }
        }

        private void Dodawanie_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int x = int.Parse(comboBox1.Text);
            if ( x == 5)
            {
                button5.Location = new Point(34, 268);
                button7.Location = new Point(34, 268);
                button9.Location = new Point(34, 268);
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
            }
            if (x == 4)
            {
                button5.Location = new Point(230, 300);
                button7.Location = new Point(230, 300);
                button9.Location = new Point(230, 300);
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = false;
            }
            if (x == 3)
            {
                button5.Location = new Point(230, 268);
                button7.Location = new Point(230, 268);
                button9.Location = new Point(230, 268);
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = false;
                textBox10.Visible = false;
            }
            if (x == 2)
            {
                button5.Location = new Point(230, 236);
                button7.Location = new Point(230, 236);
                button9.Location = new Point(230, 236);
                textBox7.Visible = true;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
            }
            if (x == 1)
            {
                button5.Location = new Point(230, 204);
                button7.Location = new Point(230, 204);
                button9.Location = new Point(230, 204);
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}



 