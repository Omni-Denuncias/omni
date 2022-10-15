using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class StatusDenuncia
    {
        [Key]
        public int IdStatus { get; set; }
        public string DescricaoStatus { get; set; }
    }
}