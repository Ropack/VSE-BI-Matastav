using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Polozka
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public decimal CastkaPlan { get; set; }
        public decimal CastkaSkutecnost { get; set; }
        public decimal CastkaRozdil { get; set; }
        public DateTime Datum { get; set; }
        public Pobocka Pobocka { get; set; }

        [ForeignKey(nameof(PolozkaDruhId))]
        public PolozkaDruh PolozkaDruh { get; set; }
        public int PolozkaDruhId { get; set; }
    }
}