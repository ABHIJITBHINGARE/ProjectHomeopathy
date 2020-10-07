using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data .SqlClient ;
namespace homeopathyproject
{



    public partial class frmappointment : Form
    {
        Image img;
        byte[] arr;
        ImageConverter imgc = new ImageConverter();

        void showImageNewForm()
        {
            int appointid;
            if (gridTab.CurrentRow.Index != -1)
            {
                appointid= Int32.Parse(gridHistory.CurrentRow.Cells[0].Value.ToString());
            
                frm_ShowImage frmShow_o1 = new frm_ShowImage(appointid);

                frmShow_o1.Show();
                // MessageBox.Show(tabname.ToString());
            }
        }


        void showGridData()
        {
            try
            {
                DataTable dt = new DataTable();
                //            string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
                //            SqlConnection conn = new SqlConnection(mainconn);
                conn.Open();
                SqlCommand myCmd = new SqlCommand("[dbo].[showTabletData]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                //  myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                gridTab.DataSource = dt;
            }
            catch { }
            finally
            {

                conn.Close();
            }
        }

        void showGridDataLiquid()
        {
            try
            {
                DataTable dt = new DataTable();
                //            string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
                //            SqlConnection conn = new SqlConnection(mainconn);
                conn.Open();
                SqlCommand myCmd = new SqlCommand("[dbo].[showLiquidData]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                //  myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                gridLiquid.DataSource = dt;
            }
            catch { }
            finally
            {

                conn.Close();
            }
        }




        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
        int globalage;
        int patient_id;
        public void history(int Appointment_patient_Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[dbo].[procappointmenthistory]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Appointment_patient_Id", Appointment_patient_Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { }
            finally { conn.Close(); }
        }

        int globalpatientid;
        public frmappointment(string patientId, string name, string address, string gender, string mobileno, string age)
        {
            InitializeComponent();
            globalpatientid = Convert.ToInt32(patient_id);

            globalpatientid = Int32.Parse(patientId);

            txtname.Text = name;
            lblid.Text = patientId.ToString();
            txtaddress.Text = address;
            txtgender.Text = gender;
            txtmobileno.Text = mobileno;
            txtAge.Text = age.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showhistory()
        {

            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand myCmd = new SqlCommand("[dbo].[procappointmenthistory]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                gridHistory.DataSource = dt;
            }
            catch { }
            finally
            {
                conn.Close();
            }


        }
        void showhistorypatientappointment()
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                SqlCommand myCmd = new SqlCommand("select * from [dbo].[procappointmenthistory]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.Fill(dt);
                gridHistory.DataSource = dt;
            }
            catch { }
            finally
            {

                conn.Close();
            }
        }

        private void frmappointment_Load(object sender, EventArgs e)
        {
            showhistorypatientappointment();

            showGridData();
            showGridDataLiquid();
            showhistory();
            
            //  MessageBox.Show(globalpatientid.ToString());
            txtmedicine.Focus();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        string strmedicine = "";
        private void gridtab_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridliquid_DoubleClick(object sender, EventArgs e)
        {

        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Image img1 = pictureBox1.Image;
            byte[] arr1;
            arr = (byte[])imgc.ConvertTo(img1, typeof(byte[]));

           // ImageConverter imgcon = new ImageConverter();
        
            // MessageBox.Show(globalpatientid.ToString());
            try
            {
                DataTable dt = new DataTable();
                //    SqlConnection myConn = new SqlConnection("");
                SqlCommand myCmd = new SqlCommand("[dbo].[createappointment]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                myCmd.Parameters.AddWithValue("@Appointment_patient_medicine", txtmedicine.Text);
                myCmd.Parameters.AddWithValue("@description", txtdescription.Text);

                myCmd.Parameters.AddWithValue("@img", arr);
                myCmd.Parameters.Add("@aid", SqlDbType.Int).Direction = ParameterDirection.Output;
                
               // MessageBox.Show("img set");
                conn.Open();
                
                myCmd.ExecuteNonQuery();
            //    MessageBox.Show("saved");
                conn.Close();
                myCmd = new SqlCommand("[dbo].[updatepatientage]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@patient_id", globalpatientid);
                globalage = Convert.ToInt32(txtAge.Text);
                myCmd.Parameters.AddWithValue("@patient_name", txtname.Text);
                myCmd.Parameters.AddWithValue("@patient_address", txtaddress.Text);
                myCmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
                myCmd.Parameters.AddWithValue("@age", globalage);
                

                conn.Open();

                myCmd.ExecuteNonQuery();
                conn.Close();
                Home home_o1 = new Home();
                home_o1.refreshHome();
                // lblStatusok.Text = "saved success";
                label4.Text = "Save success.";
                showhistory();
                btnSubmit.Enabled = false;
            }
            catch { }
            finally
            {

                conn.Close();
            }





        }

        private void txtmedicine_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strmedicine = "";
            txtmedicine.Text = "";
        }

        private void txtdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                txtAge.Focus();
            }

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                btnSubmit.Focus();
            }
        }

        private void btnSubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridliquid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridhistory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtmedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                txtdescription.Focus();
            }

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridtab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridhistory_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridTab_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridTab.CurrentRow.Index != -1)
            {
                string tabname = gridTab.CurrentRow.Cells[1].Value.ToString();
                string tabsign = gridTab.CurrentRow.Cells[2].Value.ToString();
                string tabtotal = gridTab.CurrentRow.Cells[3].Value.ToString();
                txtmedicine.Text = txtmedicine.Text + " " + tabname + " " + tabsign + " " + tabtotal + "  \n";
            }

        }

        private void gridLiquid_DoubleClick_1(object sender, EventArgs e)
        {
            if (gridTab.CurrentRow.Index != -1)
            {
                string tabname = gridLiquid.CurrentRow.Cells[1].Value.ToString();
                string tabsign = gridLiquid.CurrentRow.Cells[2].Value.ToString();
                string tabtotal = gridLiquid.CurrentRow.Cells[3].Value.ToString();
                txtmedicine.Text = txtmedicine.Text + " " + tabname + " " + tabsign + " " + tabtotal + "  \n";
            }
        }
        int histotyappointmentpatientId;

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("[dbo].[deletehistorypatientappointment]", conn);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@deletehistorypatientappointment_id", histotyappointmentpatientId);
                conn.Open();
                myCmd.ExecuteNonQuery();
                conn.Close();
                lbldeletestatus.Text = "Delete Success.";
                showhistory();
                lblhistorydatetime.Text = "";
                txthistorydiseases.Text = "";
                txthistorymedicine.Text = "";
                button4.Enabled = false;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void txtdescription_Validating(object sender, CancelEventArgs e)
        {

        }

        private void gridHistory_Click(object sender, EventArgs e)
        {
            if (gridTab.CurrentRow.Index != -1)
            {
                histotyappointmentpatientId = Int32.Parse(gridHistory.CurrentRow.Cells[0].Value.ToString());
                lblhistorydatetime.Text = gridHistory.CurrentRow.Cells[2].Value.ToString();
                txthistorymedicine.Text = gridHistory.CurrentRow.Cells[3].Value.ToString();
                txthistorydiseases.Text = gridHistory.CurrentRow.Cells[4].Value.ToString();
                button4.Enabled = true;
                // MessageBox.Show(tabname.ToString());
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txthistorymedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txthistorydiseases_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridHistory_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar == (char)Keys.Escape))
            //{
            //    Close();
            //}
            //if (e.KeyChar == (char)Keys.)
            //{
            //    showImageNewForm();
            //}
             if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
           
        }

        private void gridTab_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridLiquid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtmedicine.Text = txthistorymedicine.Text;
        }

        private void txthistorydiseases_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            //histotyappointmentpatientId
           // MessageBox.Show(histotyappointmentpatientId.ToString()); 
         //   frm_CrystalReport frm_cry_o1 = new frm_CrystalReport();
            crstalForm f1 = new crstalForm();
            f1.getData(histotyappointmentpatientId);

            f1.Show();
            
        }
        
        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            string imgurl = null;
           try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                //  ofd.ShowDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgurl = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
                img = pictureBox1.Image;
                arr = (byte[])imgc.ConvertTo(img, typeof(byte[]));
            }
            catch { }
        }
    }

}
