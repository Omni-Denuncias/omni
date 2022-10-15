using System.ComponentModel.DataAnnotations;

namespace omni.Models
{
    public class Cidadao
    {
        [Key]
        public int IdCidadao { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cep { get; set; }
        public string TituloEleitor { get; set; }
        public string ZonaEleitoral { get; set; }
        public string Secao { get; set; }
        public int PontuacaoCidadao { get; set; }
    }
}