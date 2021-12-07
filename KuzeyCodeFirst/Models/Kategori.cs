﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KuzeyCodeFirst.Models.Abstracts;

namespace KuzeyCodeFirst.Models
{
    [Table("Kategoriler")]
    public class Kategori : BaseEntity, IKey<int>
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [StringLength(30, ErrorMessage = "Ad alanı en fazla 30 karakter olur")]
        public string Ad { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
  

        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
