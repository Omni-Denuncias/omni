using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace omni.Models
{
    public class Apontamentos
    {
        [ForeignKey("IdDenuncia")]
        public int IdDenuncia { get; set; }

        [Key]
        public int IdApontamento { get; set; }
        public DateTime? MomentoApontamento { get; set; }
        public string DescricaoApontamento { get; set; }
    }
}