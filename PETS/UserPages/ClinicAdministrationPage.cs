using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class ClinicAdministrationPage : Form
    {
        public ClinicAdministrationPage()
        {
            InitializeComponent();
            LoadClinics();
        }

        private void LoadClinics()
        {
            List<Clinic> clinics = DBConnection.GetAllClinics();
            clinicDataGridView.Rows.Clear();
            foreach (var clinic in clinics)
            {
                clinicDataGridView.Rows.Add(clinic.ClinicID, clinic.ClinicName, clinic.Address);
            }
        }

        private void clinicDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "Edit Clinic" column
            if (e.ColumnIndex == clinicDataGridView.Columns["editClinicButtonColumn"].Index && e.RowIndex >= 0)
            {
                int clinicId = (int)clinicDataGridView.Rows[e.RowIndex].Cells["clinicIDColumn"].Value;
                Clinic clinic = DBConnection.GetClinicById(clinicId); // Fetch the clinic details by clinic ID

                ClinicEditForm editClinicForm = new ClinicEditForm(clinic);
                editClinicForm.ShowDialog();
                LoadClinics(); // Refresh the clinic list after editing
            }
            // Check if the clicked cell is part of the "Delete Clinic" column
            else if (e.ColumnIndex == clinicDataGridView.Columns["deleteClinicButtonColumn"].Index && e.RowIndex >= 0)
            {
                int clinicId = (int)clinicDataGridView.Rows[e.RowIndex].Cells["clinicIDColumn"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this clinic?", "Delete Clinic", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = DBConnection.DeleteClinic(clinicId);
                    if (success)
                    {
                        MessageBox.Show("Clinic deleted successfully.");
                        LoadClinics(); // Refresh the clinic list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete clinic.");
                    }
                }
            }
        }
    }
}
