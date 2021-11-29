using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class Urunler
    {
        public Urunler()
        {
            Siparislers = new HashSet<Siparisler>();
        }

        public Guid UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyat { get; set; }
        public string UrunResimYol { get; set; }
        public DateTime UrunOlusturmaZamani { get; set; }
        public Guid KategoriId { get; set; }

        public virtual Kategoriler Kategori { get; set; }
        public virtual ICollection<Siparisler> Siparislers { get; set; }
    }
}
