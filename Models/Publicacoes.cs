using System;
using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class Publicacoes
    {
        [Key]
        public int IdPublicacao { get; set; }
        public int IdTipoPublicacao { get; set; }
        public string TextoPublicacao { get; set; }
        public string LinkPublicacao { get; set; }
        public DateTime? DataInicioExibicao { get; set; }
        public DateTime? DataFimExibicao { get; set; }
        public int SensibilidadePublicacao { get; set; }
        public int PrioridadePublicacao { get; set; }
    }
}