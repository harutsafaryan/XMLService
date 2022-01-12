
namespace IMyWindowsFormsApp.Forms
{
    partial class SecondForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblGuid = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Teacher Id";
            // 
            // lblGuid
            // 
            this.lblGuid.AutoSize = true;
            this.lblGuid.Location = new System.Drawing.Point(147, 39);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Size = new System.Drawing.Size(39, 13);
            this.lblGuid.TabIndex = 1;
            this.lblGuid.Text = "lblGuid";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(150, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(258, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(150, 90);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(258, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 116);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(258, 20);
            this.txtAge.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(54, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(54, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(54, 119);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(476, 88);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(476, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(12, 160);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.ReadOnly = true;
            this.grdStudents.Size = new System.Drawing.Size(776, 278);
            this.grdStudents.TabIndex = 11;
            this.grdStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudents_CellClick);
            this.grdStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudents_CellDoubleClick);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblGuid);
            this.Controls.Add(this.lblId);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView grdStudents;
    }
}