using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class Katlar
    {
        public Katlar()
        {
            Masalars = new HashSet<Masalar>();
        }

        public Guid KatId { get; set; }
        public string KatAdi { get; set; }
        public int KatSira { get; set; }
        public string KatKod { get; set; }
        public DateTime KatOlusturmaZamani { get; set; }
        public Guid KafeId { get; set; }

        public virtual KafeBilgileri Kafe { get; set; }
        public virtual ICollection<Masalar> Masalars { get; set; }
    }
}
