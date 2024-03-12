using System.ComponentModel.DataAnnotations;

namespace AxICloudWebAPi.Models
{
    public class States
    {
        [Key]
        public int Id { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
    }
}
