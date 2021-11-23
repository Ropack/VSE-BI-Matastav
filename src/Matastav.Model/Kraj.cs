using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Kraj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Nazev { get; set; }
    }
}