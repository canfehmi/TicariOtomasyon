﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class Urun
	{
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(250)]
		public string UrunGorsel { get; set; }
        public virtual Kategori Kategori   { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }


	}
}
