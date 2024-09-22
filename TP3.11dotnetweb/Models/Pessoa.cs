using System.ComponentModel.DataAnnotations;

namespace TP3._11dotnetweb.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public Passaporte? Passaporte { get; set; }


    }
}
