using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Cariler
	{
        [Key]
        public int CariId { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		[Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
		public string CariAd { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        public string CariSoyad { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(13)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        public string CariSehir { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(50)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        public string CariMail { get; set; }
		public bool Durum { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }


	}
}
