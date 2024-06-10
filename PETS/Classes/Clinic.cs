namespace PETS.Classes
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }

        public Clinic(int clinicID, string clinicName, string address, int cityID, string cityName)
        {
            ClinicID = clinicID;
            ClinicName = clinicName;
            Address = address;
            CityID = cityID;
            CityName = cityName;
        }

        public override string ToString()
        {
            return ClinicName;
        }
    }
}
