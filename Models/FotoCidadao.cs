using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class FotoCidadao
    {
        [Key]
        public int IdCidadao { get; set; }
        public byte[] VbFotoCidadao { get; set; }
    }
}