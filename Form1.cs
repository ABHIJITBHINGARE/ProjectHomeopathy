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
    public partial class Form1 : Form
    {
        void showGridData()
        {
            try
            {
                DataTable dt = new DataTable();
                //            string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
                //            SqlConnection conn = new SqlConnection(mainconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[showTabletData]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //  myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridTab .DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("[dbo].[showLiquidData]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //  myCmd.Parameters.AddWithValue("@Appointment_patient_Id", globalpatientid);
                SqlDataAdapter da = new SqlDataAdapter(cmd );
                da.Fill(dt);
                gridliquid .DataSource = dt;
            }
            catch { }
            finally
            {

                conn.Close();
            }
        }



        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);

        string strTabLiquid = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHomeopathyDataSet5.medicine_Liquid' table. You can move, or remove it, as needed.
           // TODO: This line of code loads data into the 'dbHomeopathyDataSet2.medicine_Tab' table. You can move, or remove it, as needed.
           // TODO: This line of code loads data into the 'dbHomeoDataSet1.mediineLiquid' table. You can move, or remove it, as needed.
           // this.mediineLiquidTableAdapter.Fill(this.dbHomeoDataSet1.mediineLiquid);
            // TODO: This line of code loads data into the 'dbHomeoDataSet.mediineTab' table. You can move, or remove it, as needed.
          //  this.mediineTabTableAdapter.Fill(this.dbHomeoDataSet.mediineTab);
            txtPatietName.Focus();
            showGridData();
            showGridDataLiquid();


        }
        int appointPidcryreport;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string patient_name = txtPatietName.Text;
                string patient_address = txtPatientAddress.Text;
                string patient_gender = cmbGender.Text;
                //int Appointment_patient_Id;
                string Appointment_patient_medicine = txtSelectedMedicine.Text;
                string mobileno = txtmobileno.Text;
                int age = Convert.ToInt32(txtAge.Text); 
                //conn.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[insertPatient]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@patient_name", patient_name);
                cmd.Parameters.AddWithValue("@patient_address", patient_address);
                cmd.Parameters.AddWithValue("@patient_gender", patient_gender);
                cmd.Parameters.AddWithValue("@mobileno", mobileno);
                cmd.Parameters.AddWithValue("@age", age);
            
                cmd.Parameters.Add("@pid", SqlDbType.Int).Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                int Appointment_patient_Id = Convert.ToInt32(cmd.Parameters["@pid"].Value);
              //  MessageBox.Show("patient Id="+Appointment_patient_Id.ToString());
           //     appointPidcryreport = Appointment_patient_Id;
                Image img = pictureBox1.Image;
                byte[] arr;
                ImageConverter imgcon = new ImageConverter();
                arr = (byte[])imgcon.ConvertTo(img, typeof(byte[]));
            
                cmd = new SqlCommand("[dbo].[createappointment]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Appointment_patient_Id", Appointment_patient_Id);
                cmd.Parameters.AddWithValue("@Appointment_patient_medicine", Appointment_patient_medicine);
                cmd.Parameters.AddWithValue("@description", richTextBox1.Text );
                cmd.Parameters.AddWithValue("@img", arr);
                cmd.Parameters.Add("@aid", SqlDbType.Int).Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                appointPidcryreport = Convert.ToInt32(cmd.Parameters["@aid"].Value);
            //    MessageBox.Show("Result return" + appointPidcryreport.ToString());
            
                lblstatusform.Text = "save success";
               // MessageBox.Show(appointPidcryreport.ToString());
             //   MessageBox.Show("img save");
                btnSubmit.Enabled = false;
                Home Home_o1 = new Home();
                Home_o1.Close();
                Home_o1.Show();

                Home_o1.Refresh();
                //    MessageBox.Show("dbo].[createappointment]");
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
         //   string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(mainconn);
           


        }

        private void gridTab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
//            string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
//            SqlConnection conn = new SqlConnection(mainconn);
//            conn.Open();
//            if (gridTab.CurrentRow.Index != -1)
//            {
//              //  txtSelectedMedicine.Text = gridTab.CurrentRow.Cells[1].Value.ToString();
//                txtSelectedMedicine.Text = gridTab.CurrentRow.Cells[2].Value.ToString();
//            //    txtSelectedMedicine.Text = gridTab.CurrentRow.Cells[3].Value.ToString();
//            //    txtSelectedMedicine.Text = gridTab.CurrentRow.Cells[4].Value.ToString();
////                string noid = gridTab.CurrentRow.Cells[0].Value.ToString();
////                MessageBox.Show(noid);
//            }
        }

        private void gridTab_Click(object sender, EventArgs e)
        {

        }

        private void gridTab_DoubleClick(object sender, EventArgs e)
        {


            try
            {
                conn.Open();

               
            }
            catch { }
            finally { conn.Close(); }





    //        string mainconn = @"Data Source=COM135\SQLEXPRESS;Initial Catalog=dbHomeopathy;Integrated Security=True";
   //         SqlConnection conn = new SqlConnection(mainconn);
         
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSelectedMedicine.Text = "";
            strTabLiquid = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPatietName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                txtPatientAddress .Focus();
            }
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtPatientAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                cmbGender .Focus();
            }
        
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                txtAge .Focus();
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
                txtmobileno .Focus();
            }
            
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                btnSubmit .Focus();
            }
            

        }

        private void txtmobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }

            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
              //  txtSelectedMedicine .Focus();
            }
        }

        private void gridTab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void gridLiquid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtPatientAddress_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSelectedMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Down) || (e.KeyChar == (char)Keys.Enter))
            {
                richTextBox1.Focus();
            }
            
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape))
            {
                Close();
            }
        }

        private void txtPatientAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientAddress.Text))
            {
                e.Cancel = true;
              
                errorProvider1.SetError(txtPatientAddress, "Enter Address");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPatientAddress, null);
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                e.Cancel = true;
              
                errorProvider1.SetError(txtAge, "Enter Age");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAge, null);
            }
        }

        private void gridTab_DoubleClick_1(object sender, EventArgs e)
        {
            btnSubmit.Enabled=true;
            if (gridTab.CurrentRow.Index != -1)
            {
                string tabname = gridTab.CurrentRow.Cells[1].Value.ToString();
                string tabsign = gridTab.CurrentRow.Cells[2].Value.ToString();
                string tabtotal = gridTab.CurrentRow.Cells[3].Value.ToString();
                //string tabtotal = gridTab.CurrentRow.Cells[4].Value.ToString();
               // string noid = gridTab.CurrentRow.Cells[0].Value.ToString();
                txtSelectedMedicine.Text = txtSelectedMedicine.Text+" "+tabname+" "+tabsign+" "+tabtotal+"  \n";
                
               // MessageBox.Show(noid);
            }

        }

        private void txtmobileno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtmobileno.Text))
            {
                e.Cancel = true;
               
                errorProvider1.SetError(txtmobileno, "Enter Mobile No.");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmobileno, null);
            }
        }

        private void gridliquid_DoubleClick(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            if (gridTab.CurrentRow.Index != -1)
            {
                string tabname = gridliquid.CurrentRow.Cells[1].Value.ToString();
                string tabsign = gridliquid.CurrentRow.Cells[2].Value.ToString();
                string tabtotal = gridliquid.CurrentRow.Cells[3].Value.ToString();
                //string tabtotal = gridTab.CurrentRow.Cells[4].Value.ToString();
                // string noid = gridTab.CurrentRow.Cells[0].Value.ToString();
                txtSelectedMedicine.Text = txtSelectedMedicine.Text + " " + tabname + " " + tabsign + " " + tabtotal + "  \n";

                // MessageBox.Show(noid);
            }

        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGender.Text))
            {
                e.Cancel = true;
                
                errorProvider1.SetError(cmbGender, "Enter Gender");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbGender, null);
            }
        }

        private void txtSelectedMedicine_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectedMedicine.Text))
            {
                e.Cancel = true;
             
                errorProvider1.SetError(txtSelectedMedicine, "Select Medicine");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSelectedMedicine, null);
            }
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                e.Cancel = true;
               
                errorProvider1.SetError(richTextBox1, "Enter Disease");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox1, null);
            }
        }

        private void gridliquid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
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

        private void lblstatusform_Click(object sender, EventArgs e)
        {

        }

        private void Form1btnCreateReport_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(appointPidcryreport.ToString());
               
            crstalForm f1 = new crstalForm();
            f1.getData(appointPidcryreport);

            f1.Show();
        }

        private void Form1_btn_browseImg_Click(object sender, EventArgs e)
        {
            ImageConverter imgcon1 = new ImageConverter();
            byte[] arr1;
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

                Image img1;
                img1 = pictureBox1.Image;
                arr1 = (byte[])imgcon1.ConvertTo(imgcon1, typeof(byte[]));
                label7.Text = "Image upload success.";
            }
            catch { }
        }
    }
}
