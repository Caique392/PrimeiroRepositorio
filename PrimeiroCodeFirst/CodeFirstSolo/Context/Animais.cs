using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSolo.Context
  
{
    public class Animais
    {
        public int id { get; set; }

        [StringLength(100, MinimumLength = 15, ErrorMessage = "Deve ter no mínimo 15 e no máximo 100")]
        public string Nome { get; set; }    
        public DateTime? Agendamento { get; set; }

        [StringLength(20)]
        public string? Telefone  { get; set; }

        [StringLength(100)]
        public string NomePet { get; set; }
        [StringLength(100)]
        public string Tipo { get; set; }
        [StringLength(100)]

        public string Raça { get; set; }

    }
}
