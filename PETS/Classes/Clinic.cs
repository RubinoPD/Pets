namespace PETS.Classes
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string ClinicAddress { get; set; }

        public Clinic(int clinicID, string clinicName, string clinicAddress)
        {
            ClinicID = clinicID;
            ClinicName = clinicName;
            ClinicAddress = clinicAddress;
        }

        public override string ToString()
        {
            return ClinicName;
        }
    }
}
