using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AziendaSpedizioni.Models
{
    public class Spedizione
    {
        [Key]
        public int IdSpedizione { get; set; }

        [Required(ErrorMessage = "Si prega di specificare l'ID del Cliente.")]
        public int IdUtente { get; set; }

        [Required(ErrorMessage = "Si prega di specificare la Data di Spedizione.")]
        [DataType(DataType.Date)]
        public DateTime DataSpedizione { get; set; }

        [Required(ErrorMessage = "Si prega di specificare il Peso della spedizione.")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Si prega di specificare la Città Destinataria.")]
        public string CittaDestinataria { get; set; }

        [Required(ErrorMessage = "Si prega di specificare l'Indirizzo del Destinatario.")]
        public string IndirizzoDestinatario { get; set; }

        [Required(ErrorMessage = "Si prega di specificare il Nome del Destinatario.")]
        public string NomeDestinatario { get; set; }

        [Required(ErrorMessage = "Si prega di specificare il Costo della spedizione.")]
        public decimal CostoSpedizione { get; set; }

        [Required(ErrorMessage = "Si prega di specificare la Data di Consegna Prevista.")]
        [DataType(DataType.Date)]
        public DateTime DataConsegnaPrevista { get; set; }
    }
}