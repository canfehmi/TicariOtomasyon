using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Gider
	{
		[Key]
		public int Id { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(100)]
		public string Aciklama { get; set; }
		public DateTime Tarih { get; set; }
		public decimal Tutar { get; set; }
	}
}
