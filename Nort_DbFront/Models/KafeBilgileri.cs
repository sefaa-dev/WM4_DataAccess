using System;
using System.Collections.Generic;

#nullable disable

namespace Nort_DbFront.Models
{
    public partial class KafeBilgileri
    {
        public KafeBilgileri()
        {
            Katlars = new HashSet<Katlar>();
        }

        public Guid KafeId { get; set; }
        public string KafeAdi { get; set; }
        public string KafeLogo { get; set; }
        public DateTime KatOlusturmaZamani { get; set; }

        public virtual ICollection<Katlar> Katlars { get; set; }
    }
}
