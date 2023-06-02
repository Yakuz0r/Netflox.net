using Microsoft.AspNetCore.Http;

namespace Netflox.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string ImageUrl { get; set; }
        public string NameMovie { get; set; } = default!;
        public float Recommendation { get; set; }
        public string Time { get; set; }
        public string Director { get; set; }
        public string Actor { get; set; }
        public string Synopsis { get; set; }




    }
}
