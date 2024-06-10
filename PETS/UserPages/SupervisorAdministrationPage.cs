using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class SupervisorAdministrationPage : Form
    {
        public SupervisorAdministrationPage()
        {
            InitializeComponent();
            LoadSupervisors();
        }

        private void LoadSupervisors()
        {
            List<Supervisor> supervisors = DBConnection.GetAllSupervisors();
            supervisorDataGridView.Rows.Clear();
            foreach (var supervisor in supervisors)
            {
                supervisorDataGridView.Rows.Add(supervisor.SupervisorID, supervisor.FirstName, supervisor.LastName, supervisor.PhoneNumber, supervisor.Login, supervisor.RoleID, supervisor.Email);
            }
        }

        private void supervisorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "Edit Supervisor" column
            if (e.ColumnIndex == supervisorDataGridView.Columns["editSupervisorButtonColumn"].Index && e.RowIndex >= 0)
            {
                int supervisorId = (int)supervisorDataGridView.Rows[e.RowIndex].Cells["supervisorIDColumn"].Value;
                Supervisor supervisor = DBConnection.GetSupervisorById(supervisorId); // Fetch the supervisor details by supervisor ID

                SupervisorEditForm editSupervisorForm = new SupervisorEditForm(supervisor);
                editSupervisorForm.ShowDialog();
                LoadSupervisors(); // Refresh the supervisor list after editing
            }
            // Check if the clicked cell is part of the "Delete Supervisor" column
            else if (e.ColumnIndex == supervisorDataGridView.Columns["deleteSupervisorButtonColumn"].Index && e.RowIndex >= 0)
            {
                int supervisorId = (int)supervisorDataGridView.Rows[e.RowIndex].Cells["supervisorIDColumn"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this supervisor?", "Delete Supervisor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = DBConnection.DeleteSupervisor(supervisorId);
                    if (success)
                    {
                        MessageBox.Show("Supervisor deleted successfully.");
                        LoadSupervisors(); // Refresh the supervisor list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supervisor.");
                    }
                }
            }
        }
    }
}
