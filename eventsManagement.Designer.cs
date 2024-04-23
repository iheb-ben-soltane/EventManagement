using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    partial class eventsManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-G42PFL3;Initial Catalog=EventManagement;Integrated Security=True;");

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
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VenueId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.CustomerName = new System.Windows.Forms.ComboBox();
            this.VenueName = new System.Windows.Forms.ComboBox();
            this.Customers = new System.Windows.Forms.Button();
            this.Venues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(544, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 41);
            this.label12.TabIndex = 30;
            this.label12.Text = "Manage Events";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 398);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EventName
            // 
            this.EventName.BackColor = System.Drawing.Color.Azure;
            this.EventName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.EventName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.Location = new System.Drawing.Point(183, 528);
            this.EventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(175, 30);
            this.EventName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(101, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "CustomerName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(1131, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "VenueId";
            // 
            // VenueId
            // 
            this.VenueId.BackColor = System.Drawing.Color.Azure;
            this.VenueId.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.VenueId.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueId.Location = new System.Drawing.Point(1242, 514);
            this.VenueId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VenueId.Name = "VenueId";
            this.VenueId.Size = new System.Drawing.Size(175, 30);
            this.VenueId.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(731, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "VenueName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(387, 629);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "CustomerId";
            // 
            // CustomerId
            // 
            this.CustomerId.BackColor = System.Drawing.Color.Azure;
            this.CustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.CustomerId.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.Location = new System.Drawing.Point(528, 625);
            this.CustomerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(175, 30);
            this.CustomerId.TabIndex = 40;
            this.CustomerId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(763, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Duration";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Date
            // 
            this.Date.CalendarForeColor = System.Drawing.Color.LightSalmon;
            this.Date.CalendarMonthBackground = System.Drawing.Color.SeaShell;
            this.Date.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.Date.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.Date.CalendarTrailingForeColor = System.Drawing.Color.Coral;
            this.Date.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(528, 525);
            this.Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(175, 30);
            this.Date.TabIndex = 45;
            this.Date.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(451, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Duration
            // 
            this.Duration.BackColor = System.Drawing.Color.Azure;
            this.Duration.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Duration.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(881, 629);
            this.Duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(175, 30);
            this.Duration.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(1142, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightYellow;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Location = new System.Drawing.Point(1307, 314);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightYellow;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(1307, 228);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 41);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightYellow;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEdit.Location = new System.Drawing.Point(1307, 228);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 41);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightYellow;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Location = new System.Drawing.Point(1307, 150);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 41);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Azure;
            this.Status.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "waiting for confirmation",
            "confirmed",
            "rescheduled",
            "cancelled",
            "passed"});
            this.Status.Location = new System.Drawing.Point(1242, 625);
            this.Status.Margin = new System.Windows.Forms.Padding(4);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(175, 30);
            this.Status.TabIndex = 52;
            this.Status.Text = "Select";
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.Azure;
            this.CustomerName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CustomerName.FormattingEnabled = true;
            this.CustomerName.Location = new System.Drawing.Point(183, 625);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(175, 30);
            this.CustomerName.TabIndex = 53;
            this.CustomerName.Text = "Select";
            // 
            // VenueName
            // 
            this.VenueName.BackColor = System.Drawing.Color.Azure;
            this.VenueName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VenueName.FormattingEnabled = true;
            this.VenueName.Items.AddRange(new object[] {
            "waiting for confirmation",
            "confirmed",
            "rescheduled",
            "cancelled",
            "passed"});
            this.VenueName.Location = new System.Drawing.Point(881, 518);
            this.VenueName.Margin = new System.Windows.Forms.Padding(4);
            this.VenueName.Name = "VenueName";
            this.VenueName.Size = new System.Drawing.Size(175, 30);
            this.VenueName.TabIndex = 54;
            this.VenueName.Text = "Select";
            this.VenueName.SelectedIndexChanged += new System.EventHandler(this.VenueName_SelectedIndexChanged);
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.LightYellow;
            this.Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customers.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.Color.DarkBlue;
            this.Customers.Location = new System.Drawing.Point(183, 11);
            this.Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(143, 41);
            this.Customers.TabIndex = 55;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = false;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Venues
            // 
            this.Venues.BackColor = System.Drawing.Color.LightYellow;
            this.Venues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Venues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Venues.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venues.ForeColor = System.Drawing.Color.DarkBlue;
            this.Venues.Location = new System.Drawing.Point(34, 11);
            this.Venues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Venues.Name = "Venues";
            this.Venues.Size = new System.Drawing.Size(143, 41);
            this.Venues.TabIndex = 56;
            this.Venues.Text = "Venues";
            this.Venues.UseVisualStyleBackColor = false;
            this.Venues.Click += new System.EventHandler(this.Venues_Click);
            // 
            // eventsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 697);
            this.Controls.Add(this.Venues);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.VenueName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VenueId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Name = "eventsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events Management";
            this.Load += new System.EventHandler(this.eventsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VenueId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox CustomerName;
        private System.Windows.Forms.ComboBox VenueName;
        private Button Customers;
        private Button Venues;
    }
}