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
using System.Data;

namespace ConnectedMimari_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Server=Serverİsmi; Initial Catalog=VeritabanıAdı; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Update TabloAdo set Kolon1='"+textBox1.Text+"', Kolon2='"+textBox2.Text+"' where Koşul...");
            cmd.Connection = con;
            con.Open();
            int etk = cmd.ExecuteNonQuery();
            if (etk>0)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            con.Close();


            //Serverİsmi: VeriTabanımıza bağlandığımız ServerName kısmı yazılacak.
            //Database:Veritabanı İsmi(Hangi veritabanı ile çalışacaksak o veritabanı yazılacak.)
            //Integrated Security=SQL'e WindowsAuthentication ile bağlandıysak bağlantı güvenilir diye belirtmek için yazılacak.
            //Tabloİsmi: Veritabanında hangi tablo ile işlem yapmak istiyorsak o tabloyu Tabloİsmi diye belirttiğim yere yazılacak.
            //Kolon1-Kolon2:Hangi kolonlara ekleme yapacakak o kolonları yazıyoruz.Textbox1 Kolon1'e - TextBox2 Kolon2'ye yazılacak.
            //ExecuteNonQuery: Ekleme işleminin gerçekleşmesi için yazılacak.


        }
        
    }
}
