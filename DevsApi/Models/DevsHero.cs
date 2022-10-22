using DevsApi.Controllers;
using DevsApi.Data;
using System.ComponentModel.DataAnnotations;

namespace DevsApi.Models
{
    public class DevsHero
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       
        public string ProgrammingLanguage { get; set; }

        public string Project { get; set; }

        
        public string location { get; set; } 
        
        public DateTime CreatedDate { get; set; }


        public string CreatedBy { get; set; }
    }
}
