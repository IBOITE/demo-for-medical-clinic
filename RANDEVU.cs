

namespace goz_klinigi
{
    using System;
    using System.Collections.Generic;
    
    public partial class RANDEVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RANDEVU()
        {
            this.FATUREs = new HashSet<FATURE>();
        }
    
        public int randevuNo { get; set; }
        public Nullable<System.DateTime> randevuTarihi { get; set; }
        public string randevuNedeni { get; set; }
        public string randevuSuresi { get; set; }
        public Nullable<int> doktorNo { get; set; }
        public Nullable<int> hastaNo { get; set; }
    
        public virtual DOKTOR DOKTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATURE> FATUREs { get; set; }
        public virtual HASTA HASTA { get; set; }
    }
}
