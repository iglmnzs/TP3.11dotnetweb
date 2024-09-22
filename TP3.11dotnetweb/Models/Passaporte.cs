using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TP3._11dotnetweb.Models
{
    public class Passaporte
    {
        [Key]
        [ForeignKey("Pessoa")]
        public int PassaporteId { get; set; }
        public int Numero {  get; set; }
        public Pessoa Pessoa { get; set; } //Outra parte do relacionamento
    }
}
