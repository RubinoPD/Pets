namespace PETS.Classes
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }

        public Clinic(int clinicID, string clinicName, string address)
        {
            ClinicID = clinicID;
            ClinicName = clinicName;
            Address = address;
        }

        public override string ToString()
        {
            return ClinicName;
        }
    }
}
