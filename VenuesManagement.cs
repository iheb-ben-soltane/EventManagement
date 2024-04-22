using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class VenuesManagement : Form
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-G42PFL3;Initial Catalog=EventManagement;Integrated Security=True;");
        private int idUpdate = 0;

        public VenuesManagement()
        {
            InitializeComponent();
        }

        private void VenuesManagement_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Venues] (Name, Capacity, Address, Manager, ManagerPhone) VALUES (@Name, @Capacity, @Address, @Manager, @ManagerPhone)", cn);

                cmd.Parameters.AddWithValue("@Name", VenueName.Text);
                cmd.Parameters.AddWithValue("@Capacity", VenueCapacity.Text);
                cmd.Parameters.AddWithValue("@Address", VenueLocation.Text);
                cmd.Parameters.AddWithValue("@Manager", VenueManager.Text);
                cmd.Parameters.AddWithValue("@ManagerPhone", VenueManagerPhone.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Venue added successfully!");
                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_click(object sender, EventArgs e)
        {

            UpdateSelectedVenue();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnEdit.Visible = true;
        }

        private void btnEdit_click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                VenueName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                VenueCapacity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                VenueLocation.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                VenueManager.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                VenueManagerPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                idUpdate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Console.WriteLine(idUpdate);
            }

            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Venue with id: {idUpdate}?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                idUpdate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                DeleteSelectedVenue();
            }
        }

        private void UpdateSelectedVenue()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Venues SET Name = @Name, Capacity = @Capacity, Address = @Address, Manager = @Manager, ManagerPhone = @ManagerPhone WHERE Id = {idUpdate}", cn);

                cmd.Parameters.AddWithValue("@Name", VenueName.Text);
                cmd.Parameters.AddWithValue("@Capacity", VenueCapacity.Text);
                cmd.Parameters.AddWithValue("@Address", VenueLocation.Text);
                cmd.Parameters.AddWithValue("@Manager", VenueManager.Text);
                cmd.Parameters.AddWithValue("@ManagerPhone", VenueManagerPhone.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Venue updated successfully! ID: {idUpdate}");
                }
                else
                {
                    MessageBox.Show($"Venue with ID {idUpdate} not found.");
                }

                cn.Close();
                LoadDataIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteSelectedVenue()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Venues WHERE Id ={idUpdate} ", cn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Venue with ID {idUpdate} deleted successfully!");
                }
                else
                {
                    MessageBox.Show($"Venue with ID {idUpdate} not found.");
                }

                cn.Close();
                LoadDataIntoDataGridView();
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
                string select = "SELECT * FROM Venues";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, cn);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
