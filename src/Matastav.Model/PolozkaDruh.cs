using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class PolozkaDruh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Nazev { get; set; }
    }
}