﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyCodeFirst.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [StringLength(30,ErrorMessage = "Ad alanı en fazla 30 karakterden olur")]
        public string Ad { get; set; }
        [StringLength(250)]
        public string Aciklama { get; set; }

        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
