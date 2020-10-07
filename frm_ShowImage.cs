using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeopathyproject
{
    public partial class frm_ShowImage : Form
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
     
        private int appointid;

        public frm_ShowImage()
        {
            InitializeComponent();
        }

        public frm_ShowImage(int appointid)
        {
            // TODO: Complete member initialization
            this.appointid = appointid;
           
            try
            {
                conn.Open();
                string query4 = "select (img) from [dbo].[tblAppointment] where id=" + appointid;
                SqlCommand cmd = new SqlCommand(query4, conn);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adpt.Fill(dataSet, "img");
                DataRow Row;
                Row = dataSet.Tables["img"].Rows[0];
                byte[] MyImg = (byte[])Row[0];
                MemoryStream ms = new MemoryStream(MyImg);
                ms.Position = 0;

                Image img2 = Image.FromStream(ms); //error 

                pictureBox1.Image = img2;
            }
            catch { }
            finally { conn.Close(); }
        

        }


        private void frm_ShowImage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
