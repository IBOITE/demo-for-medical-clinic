

namespace goz_klinigi
{
    using System;
    using System.Collections.Generic;
    
    public partial class HASTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HASTA()
        {
            this.ODEMEs = new HashSet<ODEME>();
            this.RANDEVUs = new HashSet<RANDEVU>();
        }
    
        public int hastaNo { get; set; }
        public string hastaAdi { get; set; }
        public string hastaSoyadi { get; set; }
        public string hastaAdresi { get; set; }
        public string hastaTelefonu { get; set; }
        public string hastaDurumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ODEME> ODEMEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANDEVU> RANDEVUs { get; set; }
    }
}
