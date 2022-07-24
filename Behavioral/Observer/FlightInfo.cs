namespace Observer
{
    public class FlightInfo
    {
        public string FlightNumber { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Height { get; set;}
        public int Speed { get; set; }
        public FlightInfo(string flightNumber, float latitude, 
                                    float longitude, float height, int speed)
        {
            FlightNumber = flightNumber;
            Latitude = latitude;
            Longitude = longitude;
            Height = height;
            Speed = speed;
        }
        public override string ToString()
        {
            return $"FlightNumber: {FlightNumber}, Latitude: {Latitude}, Longitude: {Longitude}, Height: {Height}, Speed: {Speed}";
        }
    }



}
