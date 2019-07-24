namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            TacoBell tacoBell = new TacoBell();
            double longitude;
            double latitude;
            // Do not fail if one record parsing fails, return null
            // TODO Implement
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            string[] cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
             if (cells.Length < 3 || cells.Length > 4)
             {
                // Log that and return null
                logger.LogError("Array length incoreect.");
                
                return null;
             }

            // grab the latitude from your array at index 0
            string s_latitude = cells[0];
            // grab the longitude from your array at index 1
            string s_longitude = cells[1];
            // grab the name from your array at index 2
            tacoBell.Name = cells[2];
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            logger.LogInfo("Changing longitude into a double");
            bool sucess = double.TryParse(s_longitude, out longitude);
            logger.LogInfo("Changing latitude into a double");
            bool Sucess = double.TryParse(s_latitude, out latitude);
            if (Sucess == false || sucess == false)
            {
                logger.LogError("latitude or longitude is not a number");
                return null;
            }

            // You'll need to create a TacoBell class
            // that conforms to ITrackable
            Point loc = new Point(latitude,longitude);
            tacoBell.Location = loc;
            return tacoBell;

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            
        }
        
    }
}