using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AziendaSpedizioni.Models
{
    public class StatoSpedizione
    {
        [Key]
        public int IdStato { get; set; }

        [Required(ErrorMessage = "Si prega di specificare l'ID della Spedizione.")]
        public int IdSpedizione { get; set; }

        [Required(ErrorMessage = "Si prega di specificare lo Stato della spedizione.")]
        public string StatoConsegna { get; set; }

        [Required(ErrorMessage = "Si prega di specificare il Luogo della spedizione.")]
        public string LuogoPacco { get; set; }

        public string Descrizione { get; set; }

        [Required(ErrorMessage = "Si prega di specificare la Data e Ora dell'aggiornamento.")]
        [DataType(DataType.DateTime)]
        public DateTime DataOraAggiornamento { get; set; }
    }
}