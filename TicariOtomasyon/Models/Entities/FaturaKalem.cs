﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Entities
{
	public class FaturaKalem
	{
		[Key]
		public int Id { get; set; }
		[Column(TypeName = "Varchar")]
		[StringLength(100)]
		public string Aciklama { get; set; }
		public int Miktar { get; set; }
		public decimal BirimFiyat { get; set; }
		public decimal Tutar { get; set; }
		public virtual Faturalar Faturalar { get; set; }

	}
}
