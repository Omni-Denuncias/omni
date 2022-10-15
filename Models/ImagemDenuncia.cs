using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class ImagemDenuncia
    {
        public int IdDenuncia { get; set; }
        
        [Key]
        public int IdImagemDenuncia { get; set; }
        public byte[] VbImagemDenuncia { get; set; }
    }
}