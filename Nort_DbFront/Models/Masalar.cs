using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class Masalar
    {
        public Masalar()
        {
            Siparislers = new HashSet<Siparisler>();
        }

        public Guid MasaId { get; set; }
        public string MasaAdi { get; set; }
        public int MasaSira { get; set; }
        public DateTime MasaOlusturmaZamani { get; set; }
        public Guid KatId { get; set; }
        public bool Durum { get; set; }

        public virtual Katlar Kat { get; set; }
        public virtual ICollection<Siparisler> Siparislers { get; set; }
    }
}
