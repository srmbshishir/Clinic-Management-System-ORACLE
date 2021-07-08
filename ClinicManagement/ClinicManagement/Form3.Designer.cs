
namespace ClinicManagement
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblReceptionist = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkupdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtOldpat = new System.Windows.Forms.TextBox();
            this.txtCheckdate = new System.Windows.Forms.TextBox();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblpaid = new System.Windows.Forms.Label();
            this.lbloldpat = new System.Windows.Forms.Label();
            this.lblchkdate = new System.Windows.Forms.Label();
            this.lblDocid = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblpid = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnSearchPat = new System.Windows.Forms.Button();
            this.txtSeachPat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thusrday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndoclist = new System.Windows.Forms.Button();
            this.txtdocavailable = new System.Windows.Forms.TextBox();
            this.btnsearchdoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceptionist
            // 
            this.lblReceptionist.AutoSize = true;
            this.lblReceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblReceptionist.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblReceptionist.Location = new System.Drawing.Point(12, 9);
            this.lblReceptionist.Name = "lblReceptionist";
            this.lblReceptionist.Size = new System.Drawing.Size(165, 31);
            this.lblReceptionist.TabIndex = 0;
            this.lblReceptionist.Text = "Receptionist";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(18, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Paitent";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.name,
            this.age,
            this.sex,
            this.checkupdate,
            this.oldpatient,
            this.paid,
            this.doctorid});
            this.dgvPatient.Location = new System.Drawing.Point(322, 158);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatient.Size = new System.Drawing.Size(498, 340);
            this.dgvPatient.TabIndex = 3;
            this.dgvPatient.DoubleClick += new System.EventHandler(this.dgvPatient_DoubleClick);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "Patient Id";
            this.pid.MinimumWidth = 6;
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Gender";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 125;
            // 
            // checkupdate
            // 
            this.checkupdate.DataPropertyName = "checkupdate";
            this.checkupdate.HeaderText = "Checkup Date";
            this.checkupdate.MinimumWidth = 6;
            this.checkupdate.Name = "checkupdate";
            this.checkupdate.ReadOnly = true;
            this.checkupdate.Width = 125;
            // 
            // oldpatient
            // 
            this.oldpatient.DataPropertyName = "oldpatient";
            this.oldpatient.HeaderText = "Old Patient";
            this.oldpatient.MinimumWidth = 6;
            this.oldpatient.Name = "oldpatient";
            this.oldpatient.ReadOnly = true;
            this.oldpatient.Width = 125;
            // 
            // paid
            // 
            this.paid.DataPropertyName = "paid";
            this.paid.HeaderText = "Paid";
            this.paid.MinimumWidth = 6;
            this.paid.Name = "paid";
            this.paid.ReadOnly = true;
            this.paid.Width = 125;
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor Id";
            this.doctorid.MinimumWidth = 6;
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Width = 125;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShow.Location = new System.Drawing.Point(677, 102);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(143, 34);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Patient List";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPaid);
            this.panel1.Controls.Add(this.txtOldpat);
            this.panel1.Controls.Add(this.txtCheckdate);
            this.panel1.Controls.Add(this.txtDocId);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblpaid);
            this.panel1.Controls.Add(this.lbloldpat);
            this.panel1.Controls.Add(this.lblchkdate);
            this.panel1.Controls.Add(this.lblDocid);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblpid);
            this.panel1.Location = new System.Drawing.Point(18, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 326);
            this.panel1.TabIndex = 6;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPaid.Location = new System.Drawing.Point(145, 286);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 26);
            this.txtPaid.TabIndex = 15;
            // 
            // txtOldpat
            // 
            this.txtOldpat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOldpat.Location = new System.Drawing.Point(145, 247);
            this.txtOldpat.Name = "txtOldpat";
            this.txtOldpat.Size = new System.Drawing.Size(100, 26);
            this.txtOldpat.TabIndex = 14;
            // 
            // txtCheckdate
            // 
            this.txtCheckdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCheckdate.Location = new System.Drawing.Point(145, 212);
            this.txtCheckdate.Name = "txtCheckdate";
            this.txtCheckdate.Size = new System.Drawing.Size(100, 26);
            this.txtCheckdate.TabIndex = 13;
            // 
            // txtDocId
            // 
            this.txtDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDocId.Location = new System.Drawing.Point(145, 174);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(100, 26);
            this.txtDocId.TabIndex = 12;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGender.Location = new System.Drawing.Point(145, 136);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 26);
            this.txtGender.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAge.Location = new System.Drawing.Point(145, 97);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(145, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtId.Location = new System.Drawing.Point(145, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 8;
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblpaid.Location = new System.Drawing.Point(78, 285);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(51, 25);
            this.lblpaid.TabIndex = 7;
            this.lblpaid.Text = "Paid";
            // 
            // lbloldpat
            // 
            this.lbloldpat.AutoSize = true;
            this.lbloldpat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbloldpat.Location = new System.Drawing.Point(21, 248);
            this.lbloldpat.Name = "lbloldpat";
            this.lbloldpat.Size = new System.Drawing.Size(108, 25);
            this.lbloldpat.TabIndex = 6;
            this.lbloldpat.Text = "Old Patient";
            // 
            // lblchkdate
            // 
            this.lblchkdate.AutoSize = true;
            this.lblchkdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblchkdate.Location = new System.Drawing.Point(3, 211);
            this.lblchkdate.Name = "lblchkdate";
            this.lblchkdate.Size = new System.Drawing.Size(132, 25);
            this.lblchkdate.TabIndex = 5;
            this.lblchkdate.Text = "CheckupDate";
            // 
            // lblDocid
            // 
            this.lblDocid.AutoSize = true;
            this.lblDocid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDocid.Location = new System.Drawing.Point(40, 173);
            this.lblDocid.Name = "lblDocid";
            this.lblDocid.Size = new System.Drawing.Size(89, 25);
            this.lblDocid.TabIndex = 4;
            this.lblDocid.Text = "Doctor id";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSex.Location = new System.Drawing.Point(52, 135);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(77, 25);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAge.Location = new System.Drawing.Point(78, 96);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 25);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(3, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Patient name";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblpid.Location = new System.Drawing.Point(34, 21);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(92, 25);
            this.lblpid.TabIndex = 0;
            this.lblpid.Text = "Patient id";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogout.Location = new System.Drawing.Point(1160, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 48);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEditPatient.Location = new System.Drawing.Point(18, 104);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(149, 48);
            this.btnEditPatient.TabIndex = 8;
            this.btnEditPatient.Text = "Edit Paitent";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click_1);
            // 
            // btnSearchPat
            // 
            this.btnSearchPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchPat.Location = new System.Drawing.Point(465, 104);
            this.btnSearchPat.Name = "btnSearchPat";
            this.btnSearchPat.Size = new System.Drawing.Size(114, 33);
            this.btnSearchPat.TabIndex = 9;
            this.btnSearchPat.Text = "Search";
            this.btnSearchPat.UseVisualStyleBackColor = true;
            this.btnSearchPat.Click += new System.EventHandler(this.btnSearchPat_Click);
            // 
            // txtSeachPat
            // 
            this.txtSeachPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSeachPat.Location = new System.Drawing.Point(322, 104);
            this.txtSeachPat.Name = "txtSeachPat";
            this.txtSeachPat.Size = new System.Drawing.Size(137, 30);
            this.txtSeachPat.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(354, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by id";
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.speciality,
            this.roomno,
            this.sunday,
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thusrday,
            this.friday,
            this.saturday});
            this.dgvDoctor.Location = new System.Drawing.Point(841, 158);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersWidth = 51;
            this.dgvDoctor.RowTemplate.Height = 24;
            this.dgvDoctor.Size = new System.Drawing.Size(428, 340);
            this.dgvDoctor.TabIndex = 18;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // speciality
            // 
            this.speciality.DataPropertyName = "speciality";
            this.speciality.HeaderText = "Speciality";
            this.speciality.MinimumWidth = 6;
            this.speciality.Name = "speciality";
            this.speciality.ReadOnly = true;
            this.speciality.Width = 125;
            // 
            // roomno
            // 
            this.roomno.DataPropertyName = "roomno";
            this.roomno.HeaderText = "Room No";
            this.roomno.MinimumWidth = 6;
            this.roomno.Name = "roomno";
            this.roomno.ReadOnly = true;
            this.roomno.Width = 125;
            // 
            // sunday
            // 
            this.sunday.DataPropertyName = "sunday";
            this.sunday.HeaderText = "Sunday";
            this.sunday.MinimumWidth = 6;
            this.sunday.Name = "sunday";
            this.sunday.ReadOnly = true;
            this.sunday.Width = 125;
            // 
            // monday
            // 
            this.monday.DataPropertyName = "monday";
            this.monday.HeaderText = "Monday";
            this.monday.MinimumWidth = 6;
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.Width = 125;
            // 
            // tuesday
            // 
            this.tuesday.DataPropertyName = "tuesday";
            this.tuesday.HeaderText = "Tuesday";
            this.tuesday.MinimumWidth = 6;
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.Width = 125;
            // 
            // wednesday
            // 
            this.wednesday.DataPropertyName = "wednesday";
            this.wednesday.HeaderText = "Wednesday";
            this.wednesday.MinimumWidth = 6;
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            this.wednesday.Width = 125;
            // 
            // thusrday
            // 
            this.thusrday.DataPropertyName = "thursday";
            this.thusrday.HeaderText = "Thursday";
            this.thusrday.MinimumWidth = 6;
            this.thusrday.Name = "thusrday";
            this.thusrday.ReadOnly = true;
            this.thusrday.Width = 125;
            // 
            // friday
            // 
            this.friday.DataPropertyName = "friday";
            this.friday.HeaderText = "Friday";
            this.friday.MinimumWidth = 6;
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            this.friday.Width = 125;
            // 
            // saturday
            // 
            this.saturday.DataPropertyName = "saturday";
            this.saturday.HeaderText = "Saturday";
            this.saturday.MinimumWidth = 6;
            this.saturday.Name = "saturday";
            this.saturday.ReadOnly = true;
            this.saturday.Width = 125;
            // 
            // btndoclist
            // 
            this.btndoclist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndoclist.Location = new System.Drawing.Point(1141, 102);
            this.btndoclist.Name = "btndoclist";
            this.btndoclist.Size = new System.Drawing.Size(128, 34);
            this.btndoclist.TabIndex = 19;
            this.btndoclist.Text = "Doctor List";
            this.btndoclist.UseVisualStyleBackColor = true;
            this.btndoclist.Click += new System.EventHandler(this.btndoclist_Click);
            // 
            // txtdocavailable
            // 
            this.txtdocavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdocavailable.Location = new System.Drawing.Point(3, 90);
            this.txtdocavailable.Name = "txtdocavailable";
            this.txtdocavailable.Size = new System.Drawing.Size(137, 30);
            this.txtdocavailable.TabIndex = 20;
            // 
            // btnsearchdoc
            // 
            this.btnsearchdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsearchdoc.Location = new System.Drawing.Point(170, 93);
            this.btnsearchdoc.Name = "btnsearchdoc";
            this.btnsearchdoc.Size = new System.Drawing.Size(114, 33);
            this.btnsearchdoc.TabIndex = 21;
            this.btnsearchdoc.Text = "Search";
            this.btnsearchdoc.UseVisualStyleBackColor = true;
            this.btnsearchdoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(69, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "type day";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSpeciality.Location = new System.Drawing.Point(3, 23);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(187, 30);
            this.txtSpeciality.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "type speciality in capital";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSpeciality);
            this.panel2.Controls.Add(this.btnsearchdoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtdocavailable);
            this.panel2.Location = new System.Drawing.Point(841, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 150);
            this.panel2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(155, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "enter both fields";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndoclist);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeachPat);
            this.Controls.Add(this.btnSearchPat);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReceptionist);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceptionist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtOldpat;
        private System.Windows.Forms.TextBox txtCheckdate;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label lbloldpat;
        private System.Windows.Forms.Label lblchkdate;
        private System.Windows.Forms.Label lblDocid;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnSearchPat;
        private System.Windows.Forms.TextBox txtSeachPat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Button btndoclist;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thusrday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.TextBox txtdocavailable;
        private System.Windows.Forms.Button btnsearchdoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpeciality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}