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
using System.Xml.Linq;

namespace EventManagement
{
    public partial class eventsManagement : Form
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-G42PFL3;Initial Catalog=EventManagement;Integrated Security=True;");
        private int idUpdate = 0;
        public eventsManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void eventsManagement_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
           

        }

        private void btnUpdate_click(object sender, EventArgs e)
        {
                UpdateSelectedEvent();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnEdit.Visible = true;
        }

        private void btnEdit_click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                EventName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Date.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                VenueId.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                VenueName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                CustomerName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                CustomerId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Duration.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                Status.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                idUpdate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);


            }

            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnEdit.Visible = false;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Events] (Name, Date, VenueId, VenueName, CustomerName, CustomerId, Duration, Status) VALUES (@Name, @Date, @VenueId, @VenueName, @CustomerName, @CustomerId, @Duration, @Status)", cn);
              
                cmd.Parameters.AddWithValue("@Name", EventName.Text);
                cmd.Parameters.AddWithValue("@Date", Date.Value);
                cmd.Parameters.AddWithValue("@VenueId", VenueId.Text);
                cmd.Parameters.AddWithValue("@VenueName", VenueName.Text);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                cmd.Parameters.AddWithValue("@CustomerId", CustomerId.Text);
                cmd.Parameters.AddWithValue("@Duration", Duration.Text);
                cmd.Parameters.AddWithValue("@Status", Status.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                Console.WriteLine("event added with succss !");

                // Optionally, clear the form or refresh the DataGridView to reflect the new data
                // ClearForm();
                // RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                cn.Open();
                string select = "SELECT * FROM Events"; 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, cn);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateSelectedEvent()
        {
            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand($"UPDATE Events SET Name = @Name, Date = @Date, VenueId = @VenueId, VenueName = @VenueName, CustomerName = @CustomerName, CustomerId = @CustomerId, Duration = @Duration, Status = @Status WHERE Id = {idUpdate}", cn);

                // Add parameters for the update command
                cmd.Parameters.AddWithValue("@Name", EventName.Text);
                cmd.Parameters.AddWithValue("@Date", Date.Value);
                cmd.Parameters.AddWithValue("@VenueId", VenueId.Text);
                cmd.Parameters.AddWithValue("@VenueName", VenueName.Text);
                cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                cmd.Parameters.AddWithValue("@CustomerId", CustomerId.Text);
                cmd.Parameters.AddWithValue("@Duration", Duration.Text);
                cmd.Parameters.AddWithValue("@Status", Status.Text);

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
                LoadDataIntoDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Event with id: {idUpdate}?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    idUpdate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
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
                SqlCommand cmd = new SqlCommand($"DELETE FROM Events WHERE Id ={idUpdate} ", cn);
                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected by the delete
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Event with ID {idUpdate} deleted successfully!");

                    // Reload the data into the DataGridView
                    cn.Close();
                    LoadDataIntoDataGridView();
                }
                else
                {
                    Console.WriteLine($"Event with ID {idUpdate} not found.");
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }






    }
}
