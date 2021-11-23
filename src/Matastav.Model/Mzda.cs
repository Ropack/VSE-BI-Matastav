using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Mzda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public decimal Castka { get; set; }
        public DateTime Datum { get; set; }
        
        [ForeignKey(nameof(PobockaId))]
        public Pobocka Pobocka { get; set; }
        public int PobockaId { get; set; }
        
        [ForeignKey(nameof(ZamestnanecId))]
        public Zamestnanec Zamestnanec { get; set; }
        public int ZamestnanecId { get; set; }
    }
}