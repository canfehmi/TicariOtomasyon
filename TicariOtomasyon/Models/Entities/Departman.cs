using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Departman
	{
		[Key]
		public int Id { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string DepartmanAdi { get; set; }
		public bool Durum {  get; set; }
		public ICollection<Personel> Personels { get; set; }
	}
}
