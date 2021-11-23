using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Nazev { get; set; }
        
        [ForeignKey(nameof(KrajId))]
        public Kraj Kraj { get; set; }
        public string KrajId { get; set; }
    }
}