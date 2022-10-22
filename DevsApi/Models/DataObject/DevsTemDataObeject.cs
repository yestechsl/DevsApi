using System.ComponentModel.DataAnnotations;

namespace DevsApi.Models.DataObject
{
    public class DevsTemDataObeject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "please Eneter name Field required")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "please Eneter the Programming Language being Field required")]
        [MaxLength(50)]
        public string ProgrammingLanguage { get; set; }

        [Required(ErrorMessage = "please provide a brief dscription about u projects")]
        [MaxLength(300)]
        public string Project { get; set; }

        [Required(ErrorMessage = "please provide current location")]
        [MaxLength(50)]
        public string location { get; set; }

        public DateTime CreatedDate { get; set; }


        public string CreatedBy { get; set; }
    }
}
