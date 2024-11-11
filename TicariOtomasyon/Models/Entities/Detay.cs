using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
    public class Detay
    {
        [Key]
        public int DetayId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string UrunBilgi { get; set; }
    }
}
