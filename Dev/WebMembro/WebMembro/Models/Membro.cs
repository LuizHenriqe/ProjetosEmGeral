using System.ComponentModel.DataAnnotations;

namespace WebMembro.Models
{
    public class Membro
    {
        [Key]
        public int MemberID { get; set; }

        [Display(Name = "Nome")]
        public string MemberName { get; set; }

        [Display(Name = "Email")]
        public string MemberEmail { get; set; }
    }
}
