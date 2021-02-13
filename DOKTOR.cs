

namespace goz_klinigi
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOKTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKTOR()
        {
            this.RANDEVUs = new HashSet<RANDEVU>();
        }
    
        public int doktorNo { get; set; }
        public string doktorAdi { get; set; }
        public string doktorSoyadi { get; set; }
        public string e_mail { get; set; }
        public string sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANDEVU> RANDEVUs { get; set; }
    }
}
