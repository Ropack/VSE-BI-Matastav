using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Zakaznik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Nazev { get; set; }

        [ForeignKey(nameof(ZakaznikKategorieId))]
        public ZakaznikKategorie ZakaznikKategorie { get; set; }
        public int ZakaznikKategorieId { get; set; }
    }
}