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
using System.Net;

namespace THEplantAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=ALFY\\SQLEXPRESS;Initial Catalog=PlantDB;Integrated Security=True");
            connect.Open();

            SqlCommand command1 = new SqlCommand("SELECT Plant_SunlightNeeded, Plant_Type FROM [dbo].[PlantKey] WHERE Plant_Name =@plantNameTextBox", connect);
            command1.Parameters.AddWithValue("@plantNameTextBox", string.Copy(plantNameTextBox.Text));
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                sunTextBox.Text = reader.GetValue(0).ToString();
                plantTypeTextBox.Text = reader.GetValue(1).ToString();
            }


            if (plantNameTextBox.Text == "Lavender")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/lavandula_sweet_romance_apj18_10.jpg");
            }
            if (plantNameTextBox.Text == "Golden Rod")
            {
                webBrowser1.Navigate("https://www2.ic.edu/prairie/goldenrod%209.jpg");
            }
            if (plantNameTextBox.Text == "Rose")
            {
                webBrowser1.Navigate("https://www.gardeningknowhow.com/wp-content/uploads/2019/11/red-rose-400x265.jpg");
            }
            if (plantNameTextBox.Text == "Basil")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/6804_ocimumgreenbasil_100207.jpg");
            }
            if (plantNameTextBox.Text == "Salvia")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/6804_ocimumgreenbasil_100207.jpg");
            }
            if (plantNameTextBox.Text == "Asters")
            {
                webBrowser1.Navigate("https://www.almanac.com/sites/default/files/styles/primary_image_in_article/public/image_nodes/aster-flowers.jpg?itok=3bl-Stkz");
            }
            if (plantNameTextBox.Text == "Cilantro")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/66954.jpg");
            }
            if (plantNameTextBox.Text == "Sage")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/55636.jpg");
            }
            if (plantNameTextBox.Text == "Sunflowers")
            {
                webBrowser1.Navigate("https://www.provenwinners.com/sites/provenwinners.com/files/imagecache/500x500/ifa_upload/helianthus_suncredible_suncredible_yellow.jpg");
            }
            if (plantNameTextBox.Text == "Tulips")
            {
                webBrowser1.Navigate("https://s3.eu-west-2.amazonaws.com/growinginteractive/plants/TUL.jpg");
            }
            if (plantNameTextBox.Text == "Oak Tree")
            {
                webBrowser1.Navigate("https://cdn.shopify.com/s/files/1/0059/8835/2052/products/Shumard_Oak_600x600_f28082d9-6726-4ad7-9de2-eb3aefc65ceb_grande.jpg?v=1612444334");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=ALFY\\SQLEXPRESS;Initial Catalog=PlantDB;Integrated Security=True");
            connect.Open();

            SqlCommand command1 = new SqlCommand("SELECT Plant_Hardiness FROM [dbo].[PlantKey] WHERE Plant_Name =@plantNameTextBox", connect);
            command1.Parameters.AddWithValue("@plantNameTextBox", string.Copy(plantNameTextBox.Text));
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                textBoxResult.Text = reader.GetValue(0).ToString();
            }


        }
    }
}
