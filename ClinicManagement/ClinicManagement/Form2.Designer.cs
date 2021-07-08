
namespace ClinicManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDocForm = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowPatient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor";
            // 
            // dgvDocForm
            // 
            this.dgvDocForm.AllowUserToAddRows = false;
            this.dgvDocForm.AllowUserToDeleteRows = false;
            this.dgvDocForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.name,
            this.age,
            this.sex,
            this.oldpatient});
            this.dgvDocForm.Location = new System.Drawing.Point(18, 107);
            this.dgvDocForm.Name = "dgvDocForm";
            this.dgvDocForm.ReadOnly = true;
            this.dgvDocForm.RowHeadersWidth = 51;
            this.dgvDocForm.RowTemplate.Height = 24;
            this.dgvDocForm.Size = new System.Drawing.Size(770, 331);
            this.dgvDocForm.TabIndex = 1;
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
            this.name.DataPropertyName = "pid";
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
            // oldpatient
            // 
            this.oldpatient.DataPropertyName = "oldpatient";
            this.oldpatient.HeaderText = "Old Patient";
            this.oldpatient.MinimumWidth = 6;
            this.oldpatient.Name = "oldpatient";
            this.oldpatient.ReadOnly = true;
            this.oldpatient.Width = 125;
            // 
            // btnShowPatient
            // 
            this.btnShowPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowPatient.Location = new System.Drawing.Point(659, 64);
            this.btnShowPatient.Name = "btnShowPatient";
            this.btnShowPatient.Size = new System.Drawing.Size(129, 37);
            this.btnShowPatient.TabIndex = 2;
            this.btnShowPatient.Text = "Show Patient";
            this.btnShowPatient.UseVisualStyleBackColor = true;
            this.btnShowPatient.Click += new System.EventHandler(this.btnShowPatient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(61, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblId.Location = new System.Drawing.Point(16, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID :";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.Location = new System.Drawing.Point(659, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 39);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowPatient);
            this.Controls.Add(this.dgvDocForm);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDocForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldpatient;
        private System.Windows.Forms.Button btnShowPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnLogout;
    }
}