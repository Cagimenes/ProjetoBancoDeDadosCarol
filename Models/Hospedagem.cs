using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Hospedagem")]
    public class Hospedagem
    {
        [Column("HospedagemId")]
        [Display(Name = "Código do Hospedagem")]
        public int HospedagemId { get; set; }

        [Column("DiasHospedagem")]
        [Display(Name = "Dias da Hospedagem")]
        public int DiasHospedagem { get; set; }

        [Column("DataIda")]
        [Display(Name = "Data da Ida")]
        public DateTime DataIda { get; set; }

        [Column("DataVolta")]
        [Display(Name = "Data da Volta")]
        public DateTime DataVolta { get; set; }

        [Column("QtdPessoas")]
        [Display(Name = "Quantidade de Pessoas")]
        public int QtdPessoas { get; set; }

        [ForeignKey("DestinoId")]
        public int DestinoId { get; set; }
        public Destino? Destino { get; set; }

        [ForeignKey("HotelId")]
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
