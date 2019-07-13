﻿namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Point(double longitude, double latitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}