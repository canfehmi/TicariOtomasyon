using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Personel
	{
        [Key]
        public int Id { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string PersonelAd { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string PersonelSoyad { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(250)]
		public string PersonelGorsel { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }
		public virtual Departman Departman { get; set; }
    }
}
