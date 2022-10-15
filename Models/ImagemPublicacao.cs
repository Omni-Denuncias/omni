using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class ImagemPublicacao
    
    {
        public int IdPublicacao { get; set; }

        [Key]
        public int IdPublicacaoImagem { get; set; }
        public byte[] VbPublicacaoImagem { get; set; }
    }
}