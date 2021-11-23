using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Kontrakt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public decimal Cena { get; set; }
        public decimal Vydaje { get; set; }
        public decimal Marze { get; set; }
        public double DobaTrvaniVeDnech { get; set; }
        public DateTime Datum { get; set; }

        
        [ForeignKey(nameof(ZdrojId))]
        public Zdroj Zdroj { get; set; }
        public int ZdrojId { get; set; }

        [ForeignKey(nameof(ZakaznikId))]
        public Zakaznik Zakaznik { get; set; }
        public int ZakaznikId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }
        public string RegionId { get; set; }
    }
}