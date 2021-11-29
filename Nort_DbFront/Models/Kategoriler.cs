using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public Guid KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public string KategoriResimYol { get; set; }
        public DateTime KategoriOlusturmaZamani { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
