using System.ComponentModel.DataAnnotations;

namespace jobHunt.Models
{
    public class Registeruser
    {
        [Key]
        public string uemail { get; set; }
        public string name { get; set; }
       
        public string upass { get; set; }
        public string upassc { get; set; }
        public string ucountry { get; set; }
        public string ucity { get; set; }
        public string uphone { get; set; }

        public string gender { get; set; }
        public enum Gender
        {
            Male,
            Female,
            Other
        }
    }
}
