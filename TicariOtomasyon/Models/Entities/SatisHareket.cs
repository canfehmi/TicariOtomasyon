using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Entities
{
	public class SatisHareket
	{
		[Key]
		public int Id { get; set; }
        public Urun Urun { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
