namespace homeopathyproject
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addpatient = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridpatient = new System.Windows.Forms.DataGridView();
            this.tblPatientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbldeletestatus = new System.Windows.Forms.Label();
            this.btn_deletePatient = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmobileno = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientBindingSource3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_addpatient);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 786);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(18, 58);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(201, 55);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btn_addpatient
            // 
            this.btn_addpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addpatient.Location = new System.Drawing.Point(816, 18);
            this.btn_addpatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addpatient.Name = "btn_addpatient";
            this.btn_addpatient.Size = new System.Drawing.Size(201, 48);
            this.btn_addpatient.TabIndex = 2;
            this.btn_addpatient.Text = "Add Patient";
            this.btn_addpatient.UseVisualStyleBackColor = true;
            this.btn_addpatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(532, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridpatient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1485, 663);
            this.panel2.TabIndex = 0;
            // 
            // gridpatient
            // 
            this.gridpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridpatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridpatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridpatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridpatient.Location = new System.Drawing.Point(0, 0);
            this.gridpatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridpatient.Name = "gridpatient";
            this.gridpatient.ReadOnly = true;
            this.gridpatient.Size = new System.Drawing.Size(1485, 663);
            this.gridpatient.TabIndex = 0;
            this.gridpatient.Click += new System.EventHandler(this.gridpatient_Click);
            this.gridpatient.DoubleClick += new System.EventHandler(this.gridpatient_DoubleClick);
            this.gridpatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridpatient_KeyPress);
            // 
            // tblPatientBindingSource3
            // 
            this.tblPatientBindingSource3.DataMember = "tblPatient";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lbldeletestatus);
            this.panel3.Controls.Add(this.btn_deletePatient);
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblmobileno);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblGender);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 786);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1485, 234);
            this.panel3.TabIndex = 1;
            // 
            // lbldeletestatus
            // 
            this.lbldeletestatus.AutoSize = true;
            this.lbldeletestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeletestatus.Location = new System.Drawing.Point(893, 148);
            this.lbldeletestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldeletestatus.Name = "lbldeletestatus";
            this.lbldeletestatus.Size = new System.Drawing.Size(81, 30);
            this.lbldeletestatus.TabIndex = 15;
            this.lbldeletestatus.Text = "label5";
            // 
            // btn_deletePatient
            // 
            this.btn_deletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePatient.Location = new System.Drawing.Point(653, 136);
            this.btn_deletePatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deletePatient.Name = "btn_deletePatient";
            this.btn_deletePatient.Size = new System.Drawing.Size(232, 55);
            this.btn_deletePatient.TabIndex = 14;
            this.btn_deletePatient.Text = "Delete Patient";
            this.btn_deletePatient.UseVisualStyleBackColor = true;
            this.btn_deletePatient.Click += new System.EventHandler(this.btn_deletePatient_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(176, 136);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(81, 30);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = "lblage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Age";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblmobileno
            // 
            this.lblmobileno.AutoSize = true;
            this.lblmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobileno.Location = new System.Drawing.Point(176, 100);
            this.lblmobileno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmobileno.Name = "lblmobileno";
            this.lblmobileno.Size = new System.Drawing.Size(143, 30);
            this.lblmobileno.TabIndex = 11;
            this.lblmobileno.Text = "lblmobileno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobile No";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(176, 57);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(118, 30);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "lblgender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(176, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 30);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "lblname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(653, 20);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(350, 110);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1020);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientBindingSource3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addpatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblPatientBindingSource3;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView gridpatient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblmobileno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_deletePatient;
        private System.Windows.Forms.Label lbldeletestatus;
    }
}