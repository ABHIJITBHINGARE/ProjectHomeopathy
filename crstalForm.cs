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

namespace homeopathyproject
{
    public partial class crstalForm : Form
    {
        public crstalForm()
        {
            InitializeComponent();
        }
        int i;
        public void getData(int j)
        {
            i = j;
        }
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
     
        private void crstalForm_Load(object sender, EventArgs e)
        {
        //    MessageBox.Show(i.ToString());
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("[dbo].[proc_crystal_report_tblAppointment]", conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@appointment_id",i);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            conn.Close();
            folderCrystalReport.CrystalReport1 cr1 = new folderCrystalReport.CrystalReport1();
            cr1.Database.Tables["DataTable1"].SetDataSource(dt);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr1;

        
        }
    }
}
