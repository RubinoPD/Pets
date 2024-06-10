namespace PETS.Classes
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }

        public Clinic(int clinicID, string clinicName, string address, int cityID)
        {
            ClinicID = clinicID;
            ClinicName = clinicName;
            Address = address;
            CityID = cityID;
        }

        public override string ToString()
        {
            return ClinicName;
        }
    }
}
