using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Zdroj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Nazev { get; set; }
        
        [ForeignKey(nameof(ZdrojKategorieId))]
        public ZdrojKategorie ZdrojKategorie { get; set; }
        public int ZdrojKategorieId { get; set; }
    }
}