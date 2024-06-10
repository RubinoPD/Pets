namespace PETS.Classes
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public City(int cityID, string cityName)
        {
            CityID = cityID;
            CityName = cityName;
        }

        public override string ToString()
        {
            return CityName;
        }
    }
}
