

namespace goz_klinigi
{
    using System;
    using System.Collections.Generic;
    
    public partial class FATURE
    {
        public int fatureNo { get; set; }
        public Nullable<System.DateTime> fatureTarihi { get; set; }
        public Nullable<int> randevuNo { get; set; }
    
        public virtual RANDEVU RANDEVU { get; set; }
    }
}
