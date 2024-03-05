using AziendaSpedizioni.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AziendaSpedizioni.Dati
{
    public class MyDbContext : DbContext
    {
        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Spedizione> Spedizioni { get; set; }
        public DbSet<StatoSpedizione> StatoSpedizioni { get; set; }

        // Costruttore che accetta una stringa di connessione
        public MyDbContext() : base("name=ConnectionString")
        {
        }

        internal void Add(Utente utente)
        {
            throw new NotImplementedException();
        }

        internal void Add(Spedizione spedizione)
        {
            throw new NotImplementedException();
        }

        internal void Add(StatoSpedizione statoSpedizioni)
        {
            throw new NotImplementedException();
        }
    }
}