
namespace ClinicManagement
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ClinicManagement.DataSet1();
            this.btnShow = new System.Windows.Forms.Button();
            this.eMPLOYEETableAdapter = new ClinicManagement.DataSet1TableAdapters.EMPLOYEETableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtHrdate = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblPas = new System.Windows.Forms.Label();
            this.lblHrdate = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblAdrs = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogoutAdmin.Location = new System.Drawing.Point(19, 279);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(108, 37);
            this.btnLogoutAdmin.TabIndex = 0;
            this.btnLogoutAdmin.Text = "Logout";
            this.btnLogoutAdmin.UseVisualStyleBackColor = true;
            this.btnLogoutAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 35);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Admin";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddEmployee.Location = new System.Drawing.Point(36, 139);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(91, 39);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEdit.Location = new System.Drawing.Point(183, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.department,
            this.address,
            this.salary,
            this.hiredate});
            this.dgvShow.Location = new System.Drawing.Point(555, 68);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(598, 393);
            this.dgvShow.TabIndex = 4;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvShow.DoubleClick += new System.EventHandler(this.dgvShow_DoubleClick);
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "DEPARTMENT";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "SALARY";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 125;
            // 
            // hiredate
            // 
            this.hiredate.DataPropertyName = "hiredate";
            this.hiredate.HeaderText = "HIREDATE";
            this.hiredate.MinimumWidth = 6;
            this.hiredate.Name = "hiredate";
            this.hiredate.ReadOnly = true;
            this.hiredate.Width = 125;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShow.Location = new System.Drawing.Point(555, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 37);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbDept);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPas);
            this.panel1.Controls.Add(this.txtSal);
            this.panel1.Controls.Add(this.txtHrdate);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.lblPas);
            this.panel1.Controls.Add(this.lblHrdate);
            this.panel1.Controls.Add(this.lblSal);
            this.panel1.Controls.Add(this.lblAdrs);
            this.panel1.Controls.Add(this.lblNam);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(183, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 393);
            this.panel1.TabIndex = 6;
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(152, 273);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(159, 33);
            this.cmbDept.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(152, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 30);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPas
            // 
            this.txtPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPas.Location = new System.Drawing.Point(152, 230);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(159, 30);
            this.txtPas.TabIndex = 17;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSal.Location = new System.Drawing.Point(152, 150);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(159, 30);
            this.txtSal.TabIndex = 16;
            // 
            // txtHrdate
            // 
            this.txtHrdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHrdate.Location = new System.Drawing.Point(152, 190);
            this.txtHrdate.Name = "txtHrdate";
            this.txtHrdate.Size = new System.Drawing.Size(159, 30);
            this.txtHrdate.TabIndex = 15;
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNam.Location = new System.Drawing.Point(152, 70);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(159, 30);
            this.txtNam.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.Location = new System.Drawing.Point(152, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 30);
            this.txtId.TabIndex = 13;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDept.Location = new System.Drawing.Point(10, 276);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(113, 25);
            this.lblDept.TabIndex = 12;
            this.lblDept.Text = "Department";
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPas.Location = new System.Drawing.Point(25, 235);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(98, 25);
            this.lblPas.TabIndex = 11;
            this.lblPas.Text = "Password";
            // 
            // lblHrdate
            // 
            this.lblHrdate.AutoSize = true;
            this.lblHrdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHrdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHrdate.Location = new System.Drawing.Point(38, 193);
            this.lblHrdate.Name = "lblHrdate";
            this.lblHrdate.Size = new System.Drawing.Size(85, 25);
            this.lblHrdate.TabIndex = 10;
            this.lblHrdate.Text = "Hiredate";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSal.Location = new System.Drawing.Point(55, 153);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(68, 25);
            this.lblSal.TabIndex = 9;
            this.lblSal.Text = "Salary";
            // 
            // lblAdrs
            // 
            this.lblAdrs.AutoSize = true;
            this.lblAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdrs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdrs.Location = new System.Drawing.Point(38, 109);
            this.lblAdrs.Name = "lblAdrs";
            this.lblAdrs.Size = new System.Drawing.Size(85, 25);
            this.lblAdrs.TabIndex = 8;
            this.lblAdrs.Text = "Address";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNam.Location = new System.Drawing.Point(59, 70);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(64, 25);
            this.lblNam.TabIndex = 7;
            this.lblNam.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblid.Location = new System.Drawing.Point(95, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 25);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDelete.Location = new System.Drawing.Point(30, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 41);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearch.Location = new System.Drawing.Point(1049, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 35);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(864, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 30);
            this.txtSearch.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(956, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search by id";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnShow;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private DataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtHrdate;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.Label lblHrdate;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblAdrs;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}