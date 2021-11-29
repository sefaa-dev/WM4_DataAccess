using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class Siparisler
    {
        public Guid SiparisId { get; set; }
        public int UrunAdet { get; set; }
        public decimal BirimFiyat { get; set; }
        public DateTime SiparisOlusturmaZamani { get; set; }
        public Guid MasaId { get; set; }
        public Guid UrunId { get; set; }

        public virtual Masalar Masa { get; set; }
        public virtual Urunler Urun { get; set; }
    }
}
