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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagement
{
    public partial class CustomersManagement : Form
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-G42PFL3;Initial Catalog=EventManagement;Integrated Security=True;");
        private int idUpdate = 0;
        public CustomersManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CustomersManagement_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            if (dataGridView2.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                FirstName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();



                LastName.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();

                Phone.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                Email.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                idUpdate = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);


            }

            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnEdit.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSelectedEvent();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnEdit.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Customers] (FirstName,LastName,Phone,Email) VALUES (@FirstName,@LastName,@Phone,@Email)", cn);

                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", LastName.Text);
                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);

                cmd.ExecuteNonQuery();
                cn.Close();
                Console.WriteLine("Customer added with succss !");
                LoadDataIntoDataGridView();

                // Optionally, clear the form or refresh the DataGridView to reflect the new data
                // ClearForm();
                // RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VenueId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Customer with id: {idUpdate}?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                int rowIndex = dataGridView2.CurrentCell.RowIndex;
                if (dataGridView2.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    idUpdate = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                 
                    DeleteSelectedEvent();
                }
                else
                {
                    Console.WriteLine("no row selected !");
                }
            }
        }
        private void DeleteSelectedEvent()
        {
            try
            {
                cn.Open();

                // Construct the DELETE command
                SqlCommand cmd = new SqlCommand($"DELETE FROM Customers WHERE Id ={idUpdate} ", cn);
                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected by the delete
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Customer with ID {idUpdate} deleted successfully!");

                    // Reload the data into the DataGridView
                    cn.Close();
                    LoadDataIntoDataGridView();
                }
                else
                {
                    Console.WriteLine($"Customer with ID {idUpdate} not found.");
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void UpdateSelectedEvent()
        {
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand($"UPDATE Customers SET FirstName = @FirstName,LastName = @LastName, Phone= @Phone , Email = @Email  WHERE Id = {idUpdate}", cn);

                // Add parameters for the update command
                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);



                cmd.Parameters.AddWithValue("@LastName", LastName.Text);

                cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                cmd.Parameters.AddWithValue("@Email", Email.Text);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected by the update
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Event updated successfully! ID: {idUpdate}");

                }
                else
                {
                    Console.WriteLine($"Event with ID {idUpdate} not found.");
                }

                cn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                cn.Open();
                string select = "SELECT * FROM Customers";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, cn);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView2.DataSource = table;
                Console.WriteLine("load with success !!");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
    }

}
