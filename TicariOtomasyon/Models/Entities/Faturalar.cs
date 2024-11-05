using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Faturalar
	{
		[Key]
		public int Id { get; set; }
		[Column(TypeName = "Char")]
		[StringLength(1)]
		public string FaturaSeriNo { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(6)]
		public string FaturaSıraNo { get; set; }
		public DateTime FaturaTarih { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(60)]
		public string VergiDairesi { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(5)]
        public string Saat {  get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string TeslimEden {  get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string TeslimAlan {  get; set; }
		public decimal Toplam { get; set; }
		public ICollection<FaturaKalem> FaturaKalems { get; set;}
	}
}
