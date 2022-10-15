using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class TiposDenuncia
    {
        [Key]
        public int IdTipoDenuncia { get; set; }
        public string DescricaoTipoDenuncia { get; set; }
        public int PontuacaoTipoDenuncia { get; set; }
    }
}