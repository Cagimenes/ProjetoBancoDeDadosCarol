using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Transporte")]
    public class Transporte
    {
        [Column("TransporteId")]
        [Display(Name = "Código do Transporte")]
        public int Id { get; set; }

        [Column("NomeTansporte")]
        [Display(Name = "Nome do Transporte")]
        public string NomeTansporte { get; set; } = string.Empty;
    }
}
