//abhi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace homeopathyproject
{
    public partial class homeopathy : Form
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);


        public homeopathy()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtuserid.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        //    string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(mainconn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [dbo].[tblLogIn] WHERE login='" + txtuserid.Text + "' AND password='" + txtpassword.Text + "'", conn);
                //SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */

                    Home home_o1 = new Home();
                    home_o1.Show();
                    this.Hide();
                }
                else
                {
                    lblerrormsg.Text = "Enter proper id and password...";
                }
            }
            catch { }
            finally { conn.Close(); }


           

        }

        private void txtuserid_KeyDown(object sender, KeyEventArgs e)
        {
    
        }

        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                txtpassword.Focus();
            }
           
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                btnlogin .Focus();
            }
            if ((e.KeyChar == (char)Keys.Up))
            {
                txtuserid.Focus();
            }
        }

        private void btnlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar == (char)Keys.Up))
            {
                txtpassword.Focus();
            }
        }

        private void homeopathy_Load(object sender, EventArgs e)
        {

        }
    }
}
