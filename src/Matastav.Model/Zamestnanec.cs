using System.ComponentModel.DataAnnotations.Schema;

namespace Matastav.Model
{
    public class Zamestnanec
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Jmeno { get; set; }

        [ForeignKey(nameof(ZamestnanecPoziceId))]
        public ZamestnanecPozice ZamestnanecPozice { get; set; }
        public int ZamestnanecPoziceId { get; set; }
    }
}