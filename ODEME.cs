

namespace goz_klinigi
{
    using System;
    using System.Collections.Generic;
    
    public partial class ODEME
    {
        public int odemeNo { get; set; }
        public Nullable<System.DateTime> odemeTarihi { get; set; }
        public string odemeSekli { get; set; }
        public Nullable<decimal> odemeMiktari { get; set; }
        public Nullable<int> hastaNo { get; set; }
        public Nullable<int> fatureNo { get; set; }
    
        public virtual HASTA HASTA { get; set; }
    }
}
