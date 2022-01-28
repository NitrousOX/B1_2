using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B1_2
{
   
    public partial class Prijava : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B1_2;Integrated Security=True");
        public Prijava()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B1_2;Integrated Security=True");
            SqlCommand pas = new SqlCommand("select PasID, Ime from Pas order by PasID",conn);
            SqlCommand kategorija = new SqlCommand("select KategorijaID, Naziv from Kategorija order by KategorijaID", conn);
            SqlCommand izlozba = new SqlCommand("select IzlozbaID, Mesto from Izlozba order by Mesto", conn);
            string tmp;
            conn.Open();
            SqlDataReader pasrd = pas.ExecuteReader();
            while (pasrd.Read())
            {
                tmp = Convert.ToString(pasrd.GetInt32(0)) + "-"+ pasrd.GetString(1);
                comboBox1.Items.Add(tmp);
            }
            conn.Close();

            conn.Open();
            SqlDataReader katrd = kategorija.ExecuteReader();
            while (katrd.Read())
            {
                tmp = Convert.ToString(katrd.GetInt32(0)) + "-" + katrd.GetString(1);
                comboBox3.Items.Add(tmp);
            }
            conn.Close();

            conn.Open();
            SqlDataReader izlrd = izlozba.ExecuteReader();
            while (izlrd.Read())
            {
                tmp = izlrd.GetString(0) + "-" + izlrd.GetString(1);
                comboBox2.Items.Add(tmp);
            }
            conn.Close();
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Brisanje_btn.Enabled = false;

            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            Upisi_btn.Enabled = true;
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Brisanje_btn.Enabled = true;

            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            Upisi_btn.Enabled = false;
        }

        private void Upisi_btn_Click(object sender, EventArgs e)
        {
 
            SqlCommand insert = new SqlCommand("Insert into Rezultat (IzlozbaID,KategorijaID,PasID) values (@p1,@p2,@p3)", conn);

            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox1.Text))
                    throw new Exception("Ne sme biti prazno nijedno polje");
                if (!comboBox1.Text.Contains('-') || !comboBox2.Text.Contains('-') || !comboBox3.Text.Contains('-'))
                    throw new Exception("Pogresan format");
                string[] pas = comboBox1.Text.Split('-');
                string[] izl = comboBox2.Text.Split('-');
                string[] kat = comboBox3.Text.Split('-');

                insert.Parameters.AddWithValue("@p1", izl[0]);
                insert.Parameters.AddWithValue("@p2", Convert.ToInt32(kat[0]));
                insert.Parameters.AddWithValue("@p3", Convert.ToInt32(pas[0]));
                conn.Open();
                insert.ExecuteNonQuery();

                MessageBox.Show("Uspesno ste uneli u bazu!!!");
            }

            catch (FormatException)
            {
                MessageBox.Show("Podaci nisu uneti u dobrom formatu!!!");
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Ovaj pas je vec prijavljen!!!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void Brisanje_btn_Click(object sender, EventArgs e)
        {
            SqlCommand Brisanje = new SqlCommand("delete from Rezultat where PasID=@p1", conn);

            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text))
                    throw new Exception("Niste uneli sifru");
                string[] pas = comboBox1.Text.Split('-');
                Brisanje.Parameters.AddWithValue("@p1", Convert.ToInt32(pas[0]));
                conn.Open();
                MessageBox.Show("Uspesno ste obrisali podatke o psu iz baze!!!");
            }
            catch (FormatException) { MessageBox.Show("Unesli ste u pogrsnom formatu"); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            


        }
    }

}
