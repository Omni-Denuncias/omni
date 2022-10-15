using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class TipoPublicacao
    {
        [Key]
        public int IdTipoPublicacao { get; set; }
        public string DescricaoTipoPublicacao { get; set; }
    }
}