using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Prijem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public decimal CastkaPlan { get; set; }
        public decimal CastkaSkutecnost { get; set; }
        public decimal CastkaRozdil { get; set; }
        public DateTime Datum { get; set; }

        [ForeignKey(nameof(ZdrojId))]
        public Zdroj Zdroj { get; set; }
        public int ZdrojId { get; set; }
    }
}