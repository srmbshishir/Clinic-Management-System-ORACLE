
namespace ClinicManagement
{
    partial class AddForm
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
            this.lblAddForm = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHiredate = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddForm
            // 
            this.lblAddForm.AutoSize = true;
            this.lblAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddForm.Location = new System.Drawing.Point(155, 21);
            this.lblAddForm.Name = "lblAddForm";
            this.lblAddForm.Size = new System.Drawing.Size(234, 29);
            this.lblAddForm.TabIndex = 0;
            this.lblAddForm.Text = "Add Employee Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(116, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "NAME";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdress.Location = new System.Drawing.Point(78, 144);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(108, 25);
            this.lblAdress.TabIndex = 9;
            this.lblAdress.Text = "ADDRESS";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDepartment.Location = new System.Drawing.Point(42, 196);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(149, 25);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "DEPARTMENT";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalary.Location = new System.Drawing.Point(100, 245);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(91, 25);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "SALARY";
            // 
            // lblHiredate
            // 
            this.lblHiredate.AutoSize = true;
            this.lblHiredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHiredate.Location = new System.Drawing.Point(80, 294);
            this.lblHiredate.Name = "lblHiredate";
            this.lblHiredate.Size = new System.Drawing.Size(111, 25);
            this.lblHiredate.TabIndex = 12;
            this.lblHiredate.Text = "HIREDATE";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(61, 346);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 25);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(212, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(212, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 30);
            this.txtAddress.TabIndex = 16;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSalary.Location = new System.Drawing.Point(212, 242);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 30);
            this.txtSalary.TabIndex = 17;
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.cmbDept.Location = new System.Drawing.Point(212, 188);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(200, 33);
            this.cmbDept.TabIndex = 18;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPass.Location = new System.Drawing.Point(212, 343);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 30);
            this.txtPass.TabIndex = 20;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddEmployee.Location = new System.Drawing.Point(281, 428);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(131, 39);
            this.btnAddEmployee.TabIndex = 21;
            this.btnAddEmployee.Text = "INSERT";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDate.Location = new System.Drawing.Point(212, 291);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 30);
            this.txtDate.TabIndex = 22;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(555, 479);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblHiredate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddForm);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHiredate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtDate;
    }
}