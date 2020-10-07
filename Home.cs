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
using System.Configuration;
namespace homeopathyproject
{
    public partial class Home : Form
    {
        void showpatientData()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("[dbo].[show_tblpatient]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridpatient.DataSource = dt;
                conn.Close();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }








        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);


        void filldatagridview()
        {

            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("[dbo].[SearchPatient]", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                string name = txtSearch.Text;
                sda.SelectCommand.Parameters.AddWithValue("@patient_name", name);//id is proc parameter geted value
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gridpatient.DataSource = dt;
                conn.Close();
            }
            catch { }
            finally
            {
                conn.Close();
            }


            // string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
            //   SqlConnection conn = new SqlConnection(mainconn);

        }

        public Home()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //  txtSearch.Focus();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            showpatientData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filldatagridview();
        }

        public void refreshHome()
        {
            Refresh();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1_o1 = new Form1();
            form1_o1.Show();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            //Home home_o1 = new Home();

            filldatagridview();
        }

     void openformappointment()
        {
            if (gridpatient.CurrentRow.Index != -1)
            {
                string tabname = gridpatient.CurrentRow.Cells[1].Value.ToString();
                string tabsign = gridpatient.CurrentRow.Cells[2].Value.ToString();
                string tabtotal = gridpatient.CurrentRow.Cells[3].Value.ToString();
                //string tabtotal = gridTab.CurrentRow.Cells[4].Value.ToString();
                // string noid = gridTab.CurrentRow.Cells[0].Value.ToString();
                //txtSelectedMedicine.Text = txtSelectedMedicine.Text + " " + tabname + " " + tabsign + " " + tabtotal + "  \n";

                // MessageBox.Show(noid);

                string patientId = (gridpatient.CurrentRow.Cells[0].Value).ToString();
                string name = gridpatient.CurrentRow.Cells[1].Value.ToString();
                string address = gridpatient.CurrentRow.Cells[2].Value.ToString();
                string gender = gridpatient.CurrentRow.Cells[3].Value.ToString();
                string mobileno = gridpatient.CurrentRow.Cells[4].Value.ToString();
                string age = gridpatient.CurrentRow.Cells[5].Value.ToString();

                frmappointment frmappointment_o1 = new frmappointment(patientId, name, address, gender, mobileno, age);
                frmappointment_o1.Show();



            }
        }
        private void gridpatient_DoubleClick(object sender, EventArgs e)
        {
            openformappointment();
        }

        private void gridpatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                openformappointment();

            }

        }
        int patient_id;
        private void gridpatient_Click(object sender, EventArgs e)
        {
            if (gridpatient.CurrentRow.Index != -1)
            {
                patient_id = Int32.Parse(gridpatient.CurrentRow.Cells[0].Value.ToString());
                lblName.Text = gridpatient.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = gridpatient.CurrentRow.Cells[2].Value.ToString();
                lblGender.Text = gridpatient.CurrentRow.Cells[3].Value.ToString();
                lblmobileno.Text = gridpatient.CurrentRow.Cells[4].Value.ToString();
                lblAge.Text = gridpatient.CurrentRow.Cells[5].Value.ToString();

                // string noid = gridTab.CurrentRow.Cells[0].Value.ToString();
                //txtSelectedMedicine.Text = txtSelectedMedicine.Text + " " + tabname + " " + tabsign + " " + tabtotal + "  \n";

                // MessageBox.Show(noid);



            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_deletePatient_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("[dbo].[patientdelete]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@patient_id", patient_id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                lbldeletestatus.Text = "Delete Success";
                filldatagridview();
                lblAge.Text = "";
                lblGender.Text = "";
                lblmobileno.Text = "";
                lblName.Text = "";
                txtAddress.Text = "";
                showpatientData();
            }
            catch { }
            finally { conn.Close(); }
        }

        
    }
}
