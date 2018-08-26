namespace api.Models
{
    /// <summary>
    /// A model of a restaurant for storing in a Database
    /// Hours and Picture URLs are stored in seperate tables.
    /// </summary>
    public class DbRestaurant
    {
        public string Name { get; set; }
        
        public string Uuid { get; set; }
        
        public float Rating { get; set; }
        
        public long NumReviews { get; set; }
        
        public string Description { get; set; }
        
        public string Address { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }
        
        public bool CheckInAllowed { get; set; }
    }
}