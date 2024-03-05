using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AziendaSpedizioni.Models
{
    public class Utente
    {
        [Key]
        public int IdUtente { get; set; }

        [Required(ErrorMessage = "Il campo Email è obbligatorio.")]
        [EmailAddress(ErrorMessage = "Inserire un indirizzo email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Il campo Password è obbligatorio.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Si prega di specificare se il cliente è un'azienda.")]
        public bool Azienda { get; set; }

        [Required(ErrorMessage = "Il campo Nome è obbligatorio.")]
        public string Nome { get; set; }

        public string Cognome { get; set; }

        [StringLength(16, ErrorMessage = "Il Codice Fiscale deve essere lungo massimo 16 caratteri.")]
        public string CodiceFiscale { get; set; }

        [StringLength(11, ErrorMessage = "La Partita IVA deve essere lunga massimo 11 caratteri.")]
        public string PartitaIVA { get; set; }

        public bool Admin { get; set; }
    }
}