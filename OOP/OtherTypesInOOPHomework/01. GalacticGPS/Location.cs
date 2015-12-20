using System;

    public struct Location
    {
    private double longitude;
    private double latitude;
    private Planet planet;

    public double Longitude
    {
        get
        {
            return this.longitude;
        }
        set
        {
            if (value < -180 || value > 180)
            {
                throw new ArgumentOutOfRangeException("Longitude must be between -180 and 180 degrees inclusive.");
            }
            this.longitude = value;
        }
    }
    public double Latitude
    {
        get
        {
            return this.latitude;
        }
        set
        {
            if (value < -90 || value > 90)
            {
                throw new ArgumentOutOfRangeException("Latitude must be between -90 and 90 degrees inclusive.");
            }
            this.latitude = value;
        }
    }
    public Planet Planet { get { return this.planet; } set { this.planet = value; } }

    public Location(double latitude, double lng, Planet plan):this()
    {
        
        this.Longitude = lng;
        this.Latitude = latitude;
        this.Planet = plan;

    }
    public override string ToString()
    {
        return string.Format("{0}, {1} -{2}", this.Latitude, this.Longitude, this.Planet);
    }
}
