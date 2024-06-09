using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class VetAdministrationPage : Form
    {
        public VetAdministrationPage()
        {
            InitializeComponent();
            LoadVets();
        }

        private void LoadVets()
        {
            List<Vet> vets = DBConnection.GetAllVets();
            vetDataGridView.Rows.Clear();
            foreach (var vet in vets)
            {
                vetDataGridView.Rows.Add(vet.VetID, vet.VetName, vet.VetLastName, vet.CliniID);
            }
        }

        private void vetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "Edit Vet" column
            if (e.ColumnIndex == vetDataGridView.Columns["editVetButtonColumn"].Index && e.RowIndex >= 0)
            {
                int vetId = (int)vetDataGridView.Rows[e.RowIndex].Cells["vetIDColumn"].Value;
                Vet vet = DBConnection.GetVetById(vetId); // Fetch the vet details by vet ID

                VetEditForm editVetForm = new VetEditForm(vet);
                editVetForm.ShowDialog();
                LoadVets(); // Refresh the vet list after editing
            }
            // Check if the clicked cell is part of the "Delete Vet" column
            else if (e.ColumnIndex == vetDataGridView.Columns["deleteVetButtonColumn"].Index && e.RowIndex >= 0)
            {
                int vetId = (int)vetDataGridView.Rows[e.RowIndex].Cells["vetIDColumn"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this vet?", "Delete Vet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = DBConnection.DeleteVet(vetId);
                    if (success)
                    {
                        MessageBox.Show("Vet deleted successfully.");
                        LoadVets(); // Refresh the vet list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete vet.");
                    }
                }
            }
        }
    }
}
